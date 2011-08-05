namespace EveControlPanelApplication 
{

    partial class Main
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
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginPrefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLoginPrefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.featuresGroupBox = new System.Windows.Forms.GroupBox();
            this.accountManagmentButton = new System.Windows.Forms.Button();
            this.marketManagmentButton = new System.Windows.Forms.Button();
            this.itemEditorButton = new System.Windows.Forms.Button();
            this.stuffEditorButton = new System.Windows.Forms.Button();
            this.databaseFunctionsButton = new System.Windows.Forms.Button();
            this.insuranceManagerButton = new System.Windows.Forms.Button();
            this.raceEditorButton = new System.Windows.Forms.Button();
            this.oreEditorButton = new System.Windows.Forms.Button();
            this.evemuXmlEditor = new System.Windows.Forms.Button();
            this.evemuServerControlButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.featuresGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(380, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginPrefToolStripMenuItem,
            this.clearLoginPrefToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "MySql Login";
            // 
            // loginPrefToolStripMenuItem
            // 
            this.loginPrefToolStripMenuItem.Name = "loginPrefToolStripMenuItem";
            this.loginPrefToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.loginPrefToolStripMenuItem.Text = "Login Pref";
            this.loginPrefToolStripMenuItem.Click += new System.EventHandler(this.loginPrefToolStripMenuItem_Click);
            // 
            // clearLoginPrefToolStripMenuItem
            // 
            this.clearLoginPrefToolStripMenuItem.Name = "clearLoginPrefToolStripMenuItem";
            this.clearLoginPrefToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.clearLoginPrefToolStripMenuItem.Text = "Clear Login Pref";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // featuresGroupBox
            // 
            this.featuresGroupBox.Controls.Add(this.evemuServerControlButton);
            this.featuresGroupBox.Controls.Add(this.evemuXmlEditor);
            this.featuresGroupBox.Controls.Add(this.oreEditorButton);
            this.featuresGroupBox.Controls.Add(this.raceEditorButton);
            this.featuresGroupBox.Controls.Add(this.insuranceManagerButton);
            this.featuresGroupBox.Controls.Add(this.databaseFunctionsButton);
            this.featuresGroupBox.Controls.Add(this.stuffEditorButton);
            this.featuresGroupBox.Controls.Add(this.itemEditorButton);
            this.featuresGroupBox.Controls.Add(this.marketManagmentButton);
            this.featuresGroupBox.Controls.Add(this.accountManagmentButton);
            this.featuresGroupBox.Location = new System.Drawing.Point(12, 27);
            this.featuresGroupBox.Name = "featuresGroupBox";
            this.featuresGroupBox.Size = new System.Drawing.Size(333, 220);
            this.featuresGroupBox.TabIndex = 1;
            this.featuresGroupBox.TabStop = false;
            this.featuresGroupBox.Text = "Features";
            // 
            // accountManagmentButton
            // 
            this.accountManagmentButton.Location = new System.Drawing.Point(34, 19);
            this.accountManagmentButton.Name = "accountManagmentButton";
            this.accountManagmentButton.Size = new System.Drawing.Size(131, 23);
            this.accountManagmentButton.TabIndex = 0;
            this.accountManagmentButton.Text = "Account Managment";
            this.accountManagmentButton.UseVisualStyleBackColor = true;
            // 
            // marketManagmentButton
            // 
            this.marketManagmentButton.Location = new System.Drawing.Point(34, 48);
            this.marketManagmentButton.Name = "marketManagmentButton";
            this.marketManagmentButton.Size = new System.Drawing.Size(131, 23);
            this.marketManagmentButton.TabIndex = 2;
            this.marketManagmentButton.Text = "Market Managment";
            this.marketManagmentButton.UseVisualStyleBackColor = true;
            // 
            // itemEditorButton
            // 
            this.itemEditorButton.Location = new System.Drawing.Point(34, 77);
            this.itemEditorButton.Name = "itemEditorButton";
            this.itemEditorButton.Size = new System.Drawing.Size(131, 23);
            this.itemEditorButton.TabIndex = 3;
            this.itemEditorButton.Text = "Item/Ship Editor";
            this.itemEditorButton.UseVisualStyleBackColor = true;
            // 
            // stuffEditorButton
            // 
            this.stuffEditorButton.Location = new System.Drawing.Point(171, 77);
            this.stuffEditorButton.Name = "stuffEditorButton";
            this.stuffEditorButton.Size = new System.Drawing.Size(131, 23);
            this.stuffEditorButton.TabIndex = 4;
            this.stuffEditorButton.Text = "*.Stuff Editor";
            this.stuffEditorButton.UseVisualStyleBackColor = true;
            // 
            // databaseFunctionsButton
            // 
            this.databaseFunctionsButton.Location = new System.Drawing.Point(34, 106);
            this.databaseFunctionsButton.Name = "databaseFunctionsButton";
            this.databaseFunctionsButton.Size = new System.Drawing.Size(131, 23);
            this.databaseFunctionsButton.TabIndex = 5;
            this.databaseFunctionsButton.Text = "Database Management";
            this.databaseFunctionsButton.UseVisualStyleBackColor = true;
            // 
            // insuranceManagerButton
            // 
            this.insuranceManagerButton.Location = new System.Drawing.Point(34, 135);
            this.insuranceManagerButton.Name = "insuranceManagerButton";
            this.insuranceManagerButton.Size = new System.Drawing.Size(131, 23);
            this.insuranceManagerButton.TabIndex = 6;
            this.insuranceManagerButton.Text = "Insurance Manager";
            this.insuranceManagerButton.UseVisualStyleBackColor = true;
            // 
            // raceEditorButton
            // 
            this.raceEditorButton.Location = new System.Drawing.Point(34, 164);
            this.raceEditorButton.Name = "raceEditorButton";
            this.raceEditorButton.Size = new System.Drawing.Size(131, 23);
            this.raceEditorButton.TabIndex = 7;
            this.raceEditorButton.Text = "Race Editor";
            this.raceEditorButton.UseVisualStyleBackColor = true;
            // 
            // oreEditorButton
            // 
            this.oreEditorButton.Location = new System.Drawing.Point(34, 193);
            this.oreEditorButton.Name = "oreEditorButton";
            this.oreEditorButton.Size = new System.Drawing.Size(131, 23);
            this.oreEditorButton.TabIndex = 8;
            this.oreEditorButton.Text = "Ore and Mineral Editor";
            this.oreEditorButton.UseVisualStyleBackColor = true;
            // 
            // evemuXmlEditor
            // 
            this.evemuXmlEditor.Location = new System.Drawing.Point(171, 48);
            this.evemuXmlEditor.Name = "evemuXmlEditor";
            this.evemuXmlEditor.Size = new System.Drawing.Size(131, 23);
            this.evemuXmlEditor.TabIndex = 2;
            this.evemuXmlEditor.Text = "EveMu XML Editor";
            this.evemuXmlEditor.UseVisualStyleBackColor = true;
            // 
            // evemuServerControlButton
            // 
            this.evemuServerControlButton.Location = new System.Drawing.Point(171, 19);
            this.evemuServerControlButton.Name = "evemuServerControlButton";
            this.evemuServerControlButton.Size = new System.Drawing.Size(131, 23);
            this.evemuServerControlButton.TabIndex = 9;
            this.evemuServerControlButton.Text = "EveMu Server Control";
            this.evemuServerControlButton.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 259);
            this.Controls.Add(this.featuresGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Eve Control Panel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.featuresGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginPrefToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearLoginPrefToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox featuresGroupBox;
        private System.Windows.Forms.Button itemEditorButton;
        private System.Windows.Forms.Button marketManagmentButton;
        private System.Windows.Forms.Button accountManagmentButton;
        private System.Windows.Forms.Button evemuServerControlButton;
        private System.Windows.Forms.Button evemuXmlEditor;
        private System.Windows.Forms.Button oreEditorButton;
        private System.Windows.Forms.Button raceEditorButton;
        private System.Windows.Forms.Button insuranceManagerButton;
        private System.Windows.Forms.Button databaseFunctionsButton;
        private System.Windows.Forms.Button stuffEditorButton;
    }
}

