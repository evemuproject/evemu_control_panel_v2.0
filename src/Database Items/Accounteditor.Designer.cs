namespace EveControlPanelApplication
{
    partial class accountEditorForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAccountGroupbox = new System.Windows.Forms.GroupBox();
            this.addNewAccount = new System.Windows.Forms.Button();
            this.newAcctLevel = new System.Windows.Forms.ComboBox();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.newUsername = new System.Windows.Forms.TextBox();
            this.newAccountRoleLabel = new System.Windows.Forms.Label();
            this.newAccountPasswordLabel = new System.Windows.Forms.Label();
            this.newAccountUserTextbox = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.newAccountGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(254, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // newAccountGroupbox
            // 
            this.newAccountGroupbox.Controls.Add(this.addNewAccount);
            this.newAccountGroupbox.Controls.Add(this.newAcctLevel);
            this.newAccountGroupbox.Controls.Add(this.newPassword);
            this.newAccountGroupbox.Controls.Add(this.newUsername);
            this.newAccountGroupbox.Controls.Add(this.newAccountRoleLabel);
            this.newAccountGroupbox.Controls.Add(this.newAccountPasswordLabel);
            this.newAccountGroupbox.Controls.Add(this.newAccountUserTextbox);
            this.newAccountGroupbox.Location = new System.Drawing.Point(12, 27);
            this.newAccountGroupbox.Name = "newAccountGroupbox";
            this.newAccountGroupbox.Size = new System.Drawing.Size(229, 139);
            this.newAccountGroupbox.TabIndex = 4;
            this.newAccountGroupbox.TabStop = false;
            this.newAccountGroupbox.Text = "New Accounts";
            // 
            // addNewAccount
            // 
            this.addNewAccount.Location = new System.Drawing.Point(128, 100);
            this.addNewAccount.Name = "addNewAccount";
            this.addNewAccount.Size = new System.Drawing.Size(90, 23);
            this.addNewAccount.TabIndex = 4;
            this.addNewAccount.Text = "Create Account";
            this.addNewAccount.UseVisualStyleBackColor = true;
            this.addNewAccount.Click += new System.EventHandler(this.addNewAccount_Click);
            // 
            // newAcctLevel
            // 
            this.newAcctLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newAcctLevel.FormattingEnabled = true;
            this.newAcctLevel.Items.AddRange(new object[] {
            "SUPER ADMIN",
            "PLAYER",
            "ADMIN",
            "GAME MASTER HIGH",
            "GAME MASTER LOW"});
            this.newAcctLevel.Location = new System.Drawing.Point(97, 73);
            this.newAcctLevel.Name = "newAcctLevel";
            this.newAcctLevel.Size = new System.Drawing.Size(121, 21);
            this.newAcctLevel.TabIndex = 3;
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(97, 45);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(121, 20);
            this.newPassword.TabIndex = 2;
            // 
            // newUsername
            // 
            this.newUsername.Location = new System.Drawing.Point(97, 19);
            this.newUsername.Name = "newUsername";
            this.newUsername.Size = new System.Drawing.Size(121, 20);
            this.newUsername.TabIndex = 1;
            // 
            // newAccountRoleLabel
            // 
            this.newAccountRoleLabel.AutoSize = true;
            this.newAccountRoleLabel.Location = new System.Drawing.Point(12, 73);
            this.newAccountRoleLabel.Name = "newAccountRoleLabel";
            this.newAccountRoleLabel.Size = new System.Drawing.Size(79, 13);
            this.newAccountRoleLabel.TabIndex = 2;
            this.newAccountRoleLabel.Text = "Account Level:";
            // 
            // newAccountPasswordLabel
            // 
            this.newAccountPasswordLabel.AutoSize = true;
            this.newAccountPasswordLabel.Location = new System.Drawing.Point(35, 48);
            this.newAccountPasswordLabel.Name = "newAccountPasswordLabel";
            this.newAccountPasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.newAccountPasswordLabel.TabIndex = 1;
            this.newAccountPasswordLabel.Text = "Password:";
            // 
            // newAccountUserTextbox
            // 
            this.newAccountUserTextbox.AutoSize = true;
            this.newAccountUserTextbox.Location = new System.Drawing.Point(33, 22);
            this.newAccountUserTextbox.Name = "newAccountUserTextbox";
            this.newAccountUserTextbox.Size = new System.Drawing.Size(58, 13);
            this.newAccountUserTextbox.TabIndex = 0;
            this.newAccountUserTextbox.Text = "Username:";
            // 
            // accountEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 183);
            this.Controls.Add(this.newAccountGroupbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "accountEditorForm";
            this.Text = "Account Managment";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.newAccountGroupbox.ResumeLayout(false);
            this.newAccountGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox newAccountGroupbox;
        private System.Windows.Forms.Label newAccountRoleLabel;
        private System.Windows.Forms.Label newAccountPasswordLabel;
        private System.Windows.Forms.Label newAccountUserTextbox;
        private System.Windows.Forms.Button addNewAccount;
        public System.Windows.Forms.ComboBox newAcctLevel;
        public System.Windows.Forms.TextBox newPassword;
        public System.Windows.Forms.TextBox newUsername;
    }
}