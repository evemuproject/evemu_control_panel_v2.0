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
                }
                catch (InvalidExpressionException)
                {
                    MessageBox.Show("Error: You might not have installed MySql, please make you have done so.", "Error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error");
                }
            }
        }

        private void usernameFindTX_TextChanged(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            try
            {
                DataTable data = db.AQuery("SELECT accountName FROM account WHERE accountName='" + usernameFindTX.Text + "*'");
                foreach (DataRow row in data.Rows)
                {
                    usernameCheckedListBox.Items.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
