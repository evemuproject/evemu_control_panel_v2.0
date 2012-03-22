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
    public partial class acctEditForm : Form
    {
        public acctEditForm()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            if (usernameTX.Text != "" && passwordTX.Text != "")
            {
                DBConnect db = new DBConnect();
                try
                {
                    db.SQuery("INSERT INTO account (accountName, password) VALUES ('" + usernameTX.Text + "', '" + passwordTX.Text + "')");
                    MessageBox.Show("Account '" + usernameTX.Text + "' has been created. Have fun!", "Yay!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error");
                }
            }
        }

        private void usernameFindTX_TextChanged(object sender, EventArgs e)
        {
            usernameListBox.Items.Clear();
            DBConnect db = new DBConnect();
            try
            {
               foreach (DataRow row in db.AQuery("SELECT accountName FROM account WHERE(accountName like \'" + usernameFindTX.Text + "%\')").Rows)
                {
                    usernameListBox.Items.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
