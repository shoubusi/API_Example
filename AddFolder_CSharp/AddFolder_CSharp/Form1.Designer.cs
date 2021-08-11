namespace AddFolder_CSharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VaultsLabel = new System.Windows.Forms.Label();
            this.VaultsComboBox = new System.Windows.Forms.ComboBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.AddFolder = new System.Windows.Forms.Button();
            this.FolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            //
            //VaultsLabel
            //
            this.VaultsLabel.AutoSize = true;
            this.VaultsLabel.Location = new System.Drawing.Point(13, 26);
            this.VaultsLabel.Name = "VaultsLabel";
            this.VaultsLabel.Size = new System.Drawing.Size(94, 13);
            this.VaultsLabel.TabIndex = 0;
            this.VaultsLabel.Text = " Select vault view:";
            //
            //VaultsComboBox
            //
            this.VaultsComboBox.FormattingEnabled = true;
            this.VaultsComboBox.Location = new System.Drawing.Point(16, 42);
            this.VaultsComboBox.Name = "VaultsComboBox";
            this.VaultsComboBox.Size = new System.Drawing.Size(121, 21);
            this.VaultsComboBox.TabIndex = 1;
            //
            //BrowseButton
            //
            this.BrowseButton.Location = new System.Drawing.Point(16, 85);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(186, 23);
            this.BrowseButton.TabIndex = 3;
            this.BrowseButton.Text = "Browse for parent folder...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(BrowseButton_Click);
            //
            //ListBox
            //
            this.ListBox.FormattingEnabled = true;
            this.ListBox.HorizontalScrollbar = true;
            this.ListBox.Location = new System.Drawing.Point(16, 114);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(259, 43);
            this.ListBox.TabIndex = 4;
            //
            //AddFolder
            //
            this.AddFolder.Location = new System.Drawing.Point(84, 178);
            this.AddFolder.Name = "AddFolder";
            this.AddFolder.Size = new System.Drawing.Size(98, 23);
            this.AddFolder.TabIndex = 5;
            this.AddFolder.Text = "Add folder";
            this.AddFolder.UseVisualStyleBackColor = true;
            this.AddFolder.Click += new System.EventHandler(AddFolder_Click);
            //
            //Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 215);
            this.Controls.Add(this.AddFolder);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.VaultsComboBox);
            this.Controls.Add(this.VaultsLabel);
            this.Name = "Form1";
            this.Text = "Add folder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label VaultsLabel;
        internal System.Windows.Forms.ComboBox VaultsComboBox;
        internal System.Windows.Forms.Button BrowseButton;
        internal System.Windows.Forms.ListBox ListBox;
        internal System.Windows.Forms.Button AddFolder;
        internal System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog1;
    }
}