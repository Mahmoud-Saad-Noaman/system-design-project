using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Blood_Transformation
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            order f3 = new order();
            f3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void txt_emai_Enter(object sender, EventArgs e)
        {
            if(txtbox_email.Text == "EMAIL ADDRESS")
            {
                txtbox_email.Text = "";
                txtbox_email.ForeColor = Color.Black;
            }
        }

        private void txt_emai_Leave(object sender, EventArgs e)
        {
            if( txtbox_email.Text == "")
            {
                txtbox_email.Text = "EMAIL ADDRESS";
                txtbox_email.ForeColor = Color.Silver;
            }
        }

        //private void txt_password_Enter(object sender, EventArgs e)
        //{
        //    if (txt_confirm_password.Text == "PASSWORD")
        //    {
        //        txt_confirm_password.Text = "";
        //        txt_confirm_password.ForeColor = Color.Black;
        //    }
        //}

        //private void txt_password_Leave(object sender, EventArgs e)
        //{
        //    if (txt_confirm_password.Text == "")
        //    {
        //        txt_confirm_password.Text = "PASSWORD";
        //        txt_confirm_password.ForeColor = Color.Silver;
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            // check if email is valid 
            if (txtbox_email.Text == "EMAIL ADDRESS")
            {
                MessageBox.Show("Please enter your email address");
                txtbox_email.Focus();
                return;
            }
            // check if email contains @
            else if (!txtbox_email.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address");
                txtbox_email.Focus();
                return;
            }

            // check if the passowrd is at least 8 characters
            else if (txt_confirm_password.Text.Length < 8)
            {
                MessageBox.Show("Please enter a password with at least 8 characters");
                txt_confirm_password.Focus();
                return;
            }

            // check if password and confirm password are the same
            if(txt_confirm_password.Text != txt_confirm_password.Text)
            {
                MessageBox.Show("Please enter the same password");
                txt_confirm_password.Focus();
                return;
            }


            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Blood_Delivery_Database.mdf;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM accounts WHERE Email = '" + txtbox_email.Text + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                
                // check if password is correct
                if (reader.Read())
                {
                    if (reader["Password"].ToString() == txt_confirm_password.Text)
                    {
                        MessageBox.Show("Login Successful");

                        // set current_user class id to the id of the user that logged in
                        Current_User.user_id = Convert.ToInt32(reader["accounts_ID"].ToString());

                        // show order form
                        order f3 = new order();
                        f3.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password");
                        txt_confirm_password.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Email");
                    txtbox_email.Focus();
                    return;
                }


            }

            //order f3 = new order();
            //f3.Show();
            //this.Hide();
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void txtbox_email_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_confirm_password_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void change_pass_button_Click(object sender, EventArgs e)
        {
            // create a new change_pass_form and open it
            change_pass_form pass_form = new change_pass_form();
            pass_form.Show();
            this.Hide();
        }
    }
}
