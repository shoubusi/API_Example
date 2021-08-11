using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EPDM.Interop.epdm;
using Microsoft.VisualBasic;

namespace AddFolder_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private IEdmVault5 vault1 = null;

        public void Form1_Load(System.Object sender, System.EventArgs e)
        {
            try
            {
                IEdmVault5 vault1 = new EdmVault5();
                IEdmVault8 vault = (IEdmVault8)vault1;
                EdmViewInfo[] Views = null;

                vault.GetVaultViews(out Views, false);
                VaultsComboBox.Items.Clear();
                foreach (EdmViewInfo View in Views)
                {
                    VaultsComboBox.Items.Add(View.mbsVaultName);
                }
                if (VaultsComboBox.Items.Count > 0)
                {
                    VaultsComboBox.Text = (string)VaultsComboBox.Items[0];
                }
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                MessageBox.Show("HRESULT = 0x" + ex.ErrorCode.ToString("X") + " " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void BrowseButton_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                ListBox.Items.Clear();

                if (vault1 == null)
                {
                    vault1 = new EdmVault5();
                }
                if (!vault1.IsLoggedIn)
                {
                    //Log into selected vault as the current user
                    vault1.LoginAuto(VaultsComboBox.Text, this.Handle.ToInt32());
                }

                //Show the Browse For Folder dialog
                System.Windows.Forms.DialogResult DialogResult;
                DialogResult = FolderBrowserDialog1.ShowDialog();
                //If the user didn't click OK, exit
                if (!(DialogResult == System.Windows.Forms.DialogResult.OK))
                {
                    return;
                }

                ListBox.Items.Add(FolderBrowserDialog1.SelectedPath);

            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                MessageBox.Show("HRESULT = 0x" + ex.ErrorCode.ToString("X") + " " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void AddFolder_Click(System.Object sender, System.EventArgs e)
        {

            try
            {
                IEdmVault7 vault2 = null;
                if (vault1 == null)
                {
                    vault1 = new EdmVault5();
                }
                vault2 = (IEdmVault7)vault1;
                if (!vault1.IsLoggedIn)
                {
                    //Log into selected vault as the current user
                    vault1.LoginAuto(VaultsComboBox.Text, this.Handle.ToInt32());
                }

                IEdmFolder5 parentFolder = default(IEdmFolder5);
                parentFolder = vault2.GetFolderFromPath(ListBox.Items[0].ToString());

                dynamic folderName = "Temp";
                IEdmUserMgr5 usrMgr = default(IEdmUserMgr5);
                usrMgr = (IEdmUserMgr5)parentFolder.Vault;

                EdmFolderData data = default(EdmFolderData);
                data = new EdmFolderData();

                data.SetUserRights(usrMgr.GetUser("Engineer1").ID, (int)EdmRightFlags.EdmRight_Read | (int)EdmRightFlags.EdmRight_Lock);
                data.SetGroupRights(usrMgr.GetUserGroup("Administrators").ID, (int)EdmRightFlags.EdmRight_All);

                IEdmCard5 card = default(IEdmCard5);
                card = parentFolder.Vault.RootFolder.GetCard("doc");
                data.SetCardSource(card.ID, "doc");

                IEdmFolder5 folder = default(IEdmFolder5);
                folder = parentFolder.AddFolder(this.Handle.ToInt32(), folderName, data);
                Interaction.MsgBox("Created " + folderName + " successfully with ID, " + Conversion.Str(folder.ID) + ", in " + parentFolder.Name);


            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                MessageBox.Show("HRESULT = 0x" + ex.ErrorCode.ToString("X") + " " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
