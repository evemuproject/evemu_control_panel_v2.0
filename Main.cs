using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EveControlPanelApplication
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void loginPrefToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mySqlLogin dlg = new mySqlLogin();
            dlg.Show();
        }

        private void clearLoginPrefToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EvECP\\ecp_config.xml");
            MessageBox.Show("The config is now cleared!", "Config cleared!", MessageBoxButtons.OK);
        }

        private void accountManagmentButton_Click(object sender, EventArgs e)
        {
            acctEditForm acctEdit = new acctEditForm();
            acctEdit.Show();
        }

        private void charEditButton_Click(object sender, EventArgs e)
        {

        }

        private void itemEditorButton_Click(object sender, EventArgs e)
        {

        }

        private void databaseFunctionsButton_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("EveCP Copyright by EveProject\nProjectpage: https://github.com/evemuproject\nWebsite: http://evemu.org\n\nDevelopers:\n\nReveMu\nHurracane\nMurdockGT\nGooMan", "About EveCP", MessageBoxButtons.OK);
            About aboutForm = new About();
            aboutForm.Show();
        }

        private void editPathsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serverinfo serverForm = new Serverinfo();
            serverForm.Show();
        }

        private void clearPathsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EvECP\\ecp_paths.xml");
            MessageBox.Show("The paths are now cleared!", "Paths cleared!", MessageBoxButtons.OK);
        }
    }
}
