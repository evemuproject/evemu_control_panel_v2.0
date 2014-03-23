namespace EveControlPanelApplication
{
    partial class mySqlLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mySqlLogin));
            this.loginInfoBox = new System.Windows.Forms.GroupBox();
            this.testConnectionButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveCloseWindow = new System.Windows.Forms.Button();
            this.databaseTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.hostaddressLabel = new System.Windows.Forms.Label();
            this.loginInfoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginInfoBox
            // 
            this.loginInfoBox.Controls.Add(this.testConnectionButton);
            this.loginInfoBox.Controls.Add(this.cancelButton);
            this.loginInfoBox.Controls.Add(this.saveCloseWindow);
            this.loginInfoBox.Controls.Add(this.databaseTextBox);
            this.loginInfoBox.Controls.Add(this.portTextBox);
            this.loginInfoBox.Controls.Add(this.passwordTextBox);
            this.loginInfoBox.Controls.Add(this.usernameTextBox);
            this.loginInfoBox.Controls.Add(this.hostTextBox);
            this.loginInfoBox.Controls.Add(this.databaseLabel);
            this.loginInfoBox.Controls.Add(this.portLabel);
            this.loginInfoBox.Controls.Add(this.passwordLabel);
            this.loginInfoBox.Controls.Add(this.usernameLabel);
            this.loginInfoBox.Controls.Add(this.hostaddressLabel);
            this.loginInfoBox.Location = new System.Drawing.Point(8, 11);
            this.loginInfoBox.Name = "loginInfoBox";
            this.loginInfoBox.Size = new System.Drawing.Size(200, 223);
            this.loginInfoBox.TabIndex = 0;
            this.loginInfoBox.TabStop = false;
            this.loginInfoBox.Text = "MySql Info";
            // 
            // testConnectionButton
            // 
            this.testConnectionButton.Location = new System.Drawing.Point(14, 159);
            this.testConnectionButton.Name = "testConnectionButton";
            this.testConnectionButton.Size = new System.Drawing.Size(103, 23);
            this.testConnectionButton.TabIndex = 12;
            this.testConnectionButton.Text = "Test Connection";
            this.testConnectionButton.UseVisualStyleBackColor = true;
            this.testConnectionButton.Click += new System.EventHandler(this.testConnectionButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(119, 188);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveCloseWindow
            // 
            this.saveCloseWindow.Location = new System.Drawing.Point(14, 188);
            this.saveCloseWindow.Name = "saveCloseWindow";
            this.saveCloseWindow.Size = new System.Drawing.Size(103, 23);
            this.saveCloseWindow.TabIndex = 11;
            this.saveCloseWindow.Text = "Save and Close";
            this.saveCloseWindow.UseVisualStyleBackColor = true;
            this.saveCloseWindow.Click += new System.EventHandler(this.saveCloseWindow_Click);
            // 
            // databaseTextBox
            // 
            this.databaseTextBox.Location = new System.Drawing.Point(87, 133);
            this.databaseTextBox.Name = "databaseTextBox";
            this.databaseTextBox.Size = new System.Drawing.Size(100, 20);
            this.databaseTextBox.TabIndex = 9;
            this.databaseTextBox.Text = "evemu";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(87, 107);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(100, 20);
            this.portTextBox.TabIndex = 8;
            this.portTextBox.Text = "3306";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(87, 82);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 7;
            this.passwordTextBox.Text = "evemu";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(87, 53);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 6;
            this.usernameTextBox.Text = "evemu";
            // 
            // hostTextBox
            // 
            this.hostTextBox.Location = new System.Drawing.Point(87, 27);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(100, 20);
            this.hostTextBox.TabIndex = 5;
            this.hostTextBox.Text = "localhost";
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Location = new System.Drawing.Point(11, 136);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(56, 13);
            this.databaseLabel.TabIndex = 4;
            this.databaseLabel.Text = "Database:";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(11, 111);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(29, 13);
            this.portLabel.TabIndex = 3;
            this.portLabel.Text = "Port:";
            this.portLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(11, 84);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password:";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(11, 57);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username:";
            // 
            // hostaddressLabel
            // 
            this.hostaddressLabel.AutoSize = true;
            this.hostaddressLabel.Location = new System.Drawing.Point(11, 30);
            this.hostaddressLabel.Name = "hostaddressLabel";
            this.hostaddressLabel.Size = new System.Drawing.Size(73, 13);
            this.hostaddressLabel.TabIndex = 0;
            this.hostaddressLabel.Text = "Host Address:";
            // 
            // mySqlLogin
            // 
            this.AcceptButton = this.saveCloseWindow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(218, 242);
            this.Controls.Add(this.loginInfoBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mySqlLogin";
            this.Text = "MySql Login Information";
            this.loginInfoBox.ResumeLayout(false);
            this.loginInfoBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox loginInfoBox;
        private System.Windows.Forms.Label databaseLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label hostaddressLabel;
        private System.Windows.Forms.Button saveCloseWindow;
        public System.Windows.Forms.TextBox databaseTextBox;
        public System.Windows.Forms.TextBox portTextBox;
        public System.Windows.Forms.TextBox passwordTextBox;
        public System.Windows.Forms.TextBox usernameTextBox;
        public System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button testConnectionButton;

        
    }
}