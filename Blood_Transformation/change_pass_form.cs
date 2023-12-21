using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Transformation
{
    public partial class change_pass_form : MaterialForm
    {
        public change_pass_form()
        {
            InitializeComponent();
        }

        private void change_pass_form_Load(object sender, EventArgs e)
        {

        }

        private void chng_pass_submit_Click(object sender, EventArgs e)
        {

            // check if email is empty or doesn't contain @
            if (email_txtbox.Text == "" || !email_txtbox.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address");
                return;
            }

            // check if new password is at least 8 characters
            else if (new_pass_txtbox.Text.Length < 8)
            {
                // check if password is less than 8 characters
                MessageBox.Show("Please enter a password with at least 8 characters");
                new_pass_txtbox.Focus();
                return;
            }

            else
            {
                // check if email exists in the database 
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Blood_Delivery_Database.mdf;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // check if email exists in the database
                    string query = "SELECT COUNT(*) FROM accounts WHERE email = '" + email_txtbox.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 0)
                    {
                        MessageBox.Show("This email does not exist in our database");
                        email_txtbox.Focus();
                        return;
                    }
                    
                    // check if the old password is correct
                    else
                    {
                        string query2 = "SELECT password FROM accounts WHERE email = '" + email_txtbox.Text + "'";
                        SqlCommand cmd2 = new SqlCommand(query2, connection);
                        string password = cmd2.ExecuteScalar().ToString();

                        if (password != old_pass_txtbox.Text)
                        {
                            MessageBox.Show("The old password is incorrect");
                            return;
                        }

                        // update the password in the database
                        else
                        {
                            string query3 = "UPDATE accounts SET password = '" + new_pass_txtbox.Text + "' WHERE email = '" + email_txtbox.Text + "'";
                            SqlCommand cmd3 = new SqlCommand(query3, connection);
                            cmd3.ExecuteNonQuery();
                            MessageBox.Show("Your password has been changed successfully");
                            return;
                        }
                    }
                }
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            // go back to form1
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }

}
