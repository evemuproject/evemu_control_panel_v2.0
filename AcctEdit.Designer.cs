﻿namespace EveControlPanelApplication
{
    partial class acctEditForm
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
            this.createAccountButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userList = new System.Windows.Forms.ComboBox();
            this.passwordTX = new System.Windows.Forms.TextBox();
            this.passwordL = new System.Windows.Forms.Label();
            this.usernameL = new System.Windows.Forms.Label();
            this.usernameTX = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.search = new System.Windows.Forms.Button();
            this.delCheckedButton = new System.Windows.Forms.Button();
            this.editAcctButton = new System.Windows.Forms.Button();
            this.usernameFindL = new System.Windows.Forms.Label();
            this.usernameFindTX = new System.Windows.Forms.TextBox();
<<<<<<< HEAD
            this.userDataList = new System.Windows.Forms.DataGridView();
=======
            this.usernameListBox = new System.Windows.Forms.ListBox();
>>>>>>> d1ff5f9a75006568b8f3a91911990d36650b45bf
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataList)).BeginInit();
            this.SuspendLayout();
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(19, 160);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(75, 23);
            this.createAccountButton.TabIndex = 0;
            this.createAccountButton.Text = "Create";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.userList);
            this.groupBox1.Controls.Add(this.passwordTX);
            this.groupBox1.Controls.Add(this.createAccountButton);
            this.groupBox1.Controls.Add(this.passwordL);
            this.groupBox1.Controls.Add(this.usernameL);
            this.groupBox1.Controls.Add(this.usernameTX);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 195);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Role";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userList
            // 
            this.userList.DisplayMember = "Dev";
            this.userList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userList.FormattingEnabled = true;
            this.userList.Items.AddRange(new object[] {
            "Dev",
            "Player"});
            this.userList.Location = new System.Drawing.Point(6, 110);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(100, 21);
            this.userList.TabIndex = 5;
            this.userList.ValueMember = "Dev";
            // 
            // passwordTX
            // 
            this.passwordTX.Location = new System.Drawing.Point(6, 71);
            this.passwordTX.Name = "passwordTX";
            this.passwordTX.Size = new System.Drawing.Size(100, 20);
            this.passwordTX.TabIndex = 4;
            // 
            // passwordL
            // 
            this.passwordL.AutoSize = true;
            this.passwordL.Location = new System.Drawing.Point(27, 54);
            this.passwordL.Name = "passwordL";
            this.passwordL.Size = new System.Drawing.Size(56, 13);
            this.passwordL.TabIndex = 3;
            this.passwordL.Text = "Password:";
            // 
            // usernameL
            // 
            this.usernameL.AutoSize = true;
            this.usernameL.Location = new System.Drawing.Point(27, 16);
            this.usernameL.Name = "usernameL";
            this.usernameL.Size = new System.Drawing.Size(58, 13);
            this.usernameL.TabIndex = 2;
            this.usernameL.Text = "Username:";
            // 
            // usernameTX
            // 
            this.usernameTX.Location = new System.Drawing.Point(6, 32);
            this.usernameTX.Name = "usernameTX";
            this.usernameTX.Size = new System.Drawing.Size(100, 20);
            this.usernameTX.TabIndex = 1;
            // 
            // groupBox2
            // 
<<<<<<< HEAD
            this.groupBox2.Controls.Add(this.userDataList);
            this.groupBox2.Controls.Add(this.search);
=======
            this.groupBox2.Controls.Add(this.usernameListBox);
>>>>>>> d1ff5f9a75006568b8f3a91911990d36650b45bf
            this.groupBox2.Controls.Add(this.delCheckedButton);
            this.groupBox2.Controls.Add(this.editAcctButton);
            this.groupBox2.Controls.Add(this.usernameFindL);
            this.groupBox2.Controls.Add(this.usernameFindTX);
            this.groupBox2.Location = new System.Drawing.Point(130, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 327);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Accounts";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(209, 23);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 7;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // delCheckedButton
            // 
            this.delCheckedButton.Location = new System.Drawing.Point(371, 24);
            this.delCheckedButton.Name = "delCheckedButton";
            this.delCheckedButton.Size = new System.Drawing.Size(75, 23);
            this.delCheckedButton.TabIndex = 6;
            this.delCheckedButton.Text = "Delete";
            this.delCheckedButton.UseVisualStyleBackColor = true;
            this.delCheckedButton.Click += new System.EventHandler(this.delCheckedButton_Click);
            // 
            // editAcctButton
            // 
            this.editAcctButton.Location = new System.Drawing.Point(290, 23);
            this.editAcctButton.Name = "editAcctButton";
            this.editAcctButton.Size = new System.Drawing.Size(75, 23);
            this.editAcctButton.TabIndex = 5;
            this.editAcctButton.Text = "Edit";
            this.editAcctButton.UseVisualStyleBackColor = true;
            // 
            // usernameFindL
            // 
            this.usernameFindL.AutoSize = true;
            this.usernameFindL.Location = new System.Drawing.Point(6, 26);
            this.usernameFindL.Name = "usernameFindL";
            this.usernameFindL.Size = new System.Drawing.Size(58, 13);
            this.usernameFindL.TabIndex = 4;
            this.usernameFindL.Text = "Username:";
            // 
            // usernameFindTX
            // 
            this.usernameFindTX.Location = new System.Drawing.Point(70, 26);
            this.usernameFindTX.Name = "usernameFindTX";
            this.usernameFindTX.Size = new System.Drawing.Size(133, 20);
            this.usernameFindTX.TabIndex = 8;
            // 
            // userDataList
            // 
            this.userDataList.AllowUserToAddRows = false;
            this.userDataList.AllowUserToDeleteRows = false;
            this.userDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataList.Location = new System.Drawing.Point(13, 52);
            this.userDataList.Name = "userDataList";
            this.userDataList.ReadOnly = true;
            this.userDataList.Size = new System.Drawing.Size(562, 269);
            this.userDataList.TabIndex = 9;
            // 
            // usernameListBox
            // 
            this.usernameListBox.FormattingEnabled = true;
            this.usernameListBox.Location = new System.Drawing.Point(6, 49);
            this.usernameListBox.Name = "usernameListBox";
            this.usernameListBox.Size = new System.Drawing.Size(138, 134);
            this.usernameListBox.TabIndex = 7;
            // 
            // acctEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 344);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "acctEditForm";
            this.Text = "Account Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passwordTX;
        private System.Windows.Forms.Label passwordL;
        private System.Windows.Forms.Label usernameL;
        private System.Windows.Forms.TextBox usernameTX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button delCheckedButton;
        private System.Windows.Forms.Button editAcctButton;
        private System.Windows.Forms.Label usernameFindL;
        private System.Windows.Forms.TextBox usernameFindTX;
<<<<<<< HEAD
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox userList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView userDataList;
=======
        private System.Windows.Forms.ListBox usernameListBox;
>>>>>>> d1ff5f9a75006568b8f3a91911990d36650b45bf
    }
}