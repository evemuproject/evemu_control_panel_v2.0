using System;
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

        }
    }
}
