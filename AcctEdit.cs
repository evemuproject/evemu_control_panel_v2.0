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
        //roles list
        private const long DEV = 5003499186008621056L;
        private const long PLAYER = 6917529027641081856L;

        public acctEditForm()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            if (usernameTX.Text != "" && passwordTX.Text != "" && userList.SelectedValue.ToString() != "")
            {
                try
                {
                    if (userList.SelectedIndex == 0) //Dev account
                    {
                        DBConnect.SQuery("INSERT INTO account (accountID, accountName, role, password, banned, online)" +
                                            "VALUES (NULL, '" + usernameTX.Text + "', " + DEV + ", '" + passwordTX.Text + "', 0, 0)");
                        MessageBox.Show("Dev account added!");
                    }
                    else if (userList.SelectedIndex == 1) //Player account
                    {
                        DBConnect.SQuery("INSERT INTO account (accountID, accountName, role, password, banned, online)" +
                                            "VALUES (NULL, '" + usernameTX.Text + "', " + PLAYER + ", '" + passwordTX.Text + "', 0, 0)");
                        MessageBox.Show("Player account added!");
                    }
                }
                catch (InvalidExpressionException)
                {
                    MessageBox.Show("Error: You might not have installed MySql, please make you have done so.", "Error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable data = new DataTable();
                data = DBConnect.AQuery("SELECT accountID, accountName, role, banned, logonCount `online` FROM account WHERE accountName like '" + usernameFindTX.Text + "%';");
                userDataList.DataSource = data;
                usernameFindTX.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delCheckedButton_Click(object sender, EventArgs e)
        {
            try
            {
              
                DBConnect.SQuery("DELETE FROM account WHERE accountName='" + userDataList.CurrentCell.Value + "'");
                userDataList.Rows.Remove(userDataList.CurrentRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void contextMenuCells_opened(object sender, EventArgs e)
        {
            if (userDataList.RowCount <= 0)
            {
                SendKeys.Send("{ESC}"); // don't know any other to cancel this event, canceling via CancelEventArgs doesn't work..
                MessageBox.Show("Please use search first");
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = DBConnect.AQuery("SELECT accountName, role FROM account WHERE accountName = '" + userDataList.SelectedRows[0].Cells[1].Value.ToString() + "';");
            if (data.Rows.Count == 1)
            {
                groupBox3.Visible = true;
                textBox2.Text = data.Rows[0][0].ToString();
                textBox2.Enabled = false;
                textBox1.Text = "";
                if (data.Rows[0][1].ToString() == "5003499186008621056")
                {
                    comboBox1.SelectedItem = "Dev";
                }
                else
                {
                    comboBox1.SelectedItem = "Player";
                }
            }
            else
            {
                MessageBox.Show("Nothing found");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                DBConnect.SQuery("UPDATE account SET role='" + DEV + "' WHERE accountName='" + textBox2.Text + "'");
            }
            else
            {
                DBConnect.SQuery("UPDATE account SET role='" + PLAYER + "' WHERE accountName='" + textBox2.Text + "'");
            }
            if (textBox1.Text != "")
            {
                DBConnect.SQuery("UPDATE account SET password='" + textBox1.Text + "' WHERE accountName='" + textBox2.Text + "'");
            }

            groupBox3.Visible = false;
            textBox2.Text = "";
            textBox2.Enabled = false;
            textBox1.Text = "";
            comboBox1.SelectedItem = "";

            MessageBox.Show("The edit was successull written to the database!", "Successfull!", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            textBox2.Text = "";
            textBox2.Enabled = false;
            textBox1.Text = "";
            comboBox1.SelectedItem = "";
        }
    }
}
