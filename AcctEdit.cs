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
                try
                {
                    DBConnect.SQuery("INSERT INTO account (accountName, password) VALUES ('" + usernameTX.Text + "', '" + passwordTX.Text + "')");
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

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable data = new DataTable();
                data = DBConnect.AQuery("SELECT accountName FROM account WHERE accountName='" + usernameFindTX.Text + "*'");
                Console.WriteLine(data.Rows.ToString());
                foreach (DataRow row in data.Rows)
                {
                    Console.WriteLine(row);
                    usernameListBox.Items.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
