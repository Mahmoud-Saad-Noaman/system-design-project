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

namespace Blood_Transformation
{
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }


        // create an public instance of signup_data_class
        signup_data_class signup_data = new signup_data_class();

        //private void button1_Click(object sender, EventArgs e)
       //{
            // check if the txt_email is a valid email

            
            //Form4 f4 = new Form4();
            //f4.Show();
            //this.Hide();
        //}

        private void txt_email_Enter(object sender, EventArgs e)
        {
            if(txt_email.Text == "i.e johndoe@gmail.com")
            {
                txt_email.Text = "";
                txt_email.ForeColor = Color.Black;
            }
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (txt_email.Text == "")
            {
                txt_email.Text = "i.e johndoe@gmail.com";
                txt_email.ForeColor = Color.Silver;
            }
        }

        //private void txt_password_Enter(object sender, EventArgs e)
        //{
        //    if (txt_password.Text == "at least 8 characters")
        //    {
        //        txt_password.Text = "";
        //        txt_password.ForeColor = Color.Black;
        //    }
        //}

        //private void txt_password_Leave(object sender, EventArgs e)
        //{
        //    if (txt_password.Text == "")
        //    {
        //        txt_password.Text = "at least 8 characters";
        //        txt_password.ForeColor = Color.Silver;
        //    }
        //}

        //private void txt_con_password_Enter(object sender, EventArgs e)
        //{
        //    if(txt_con_password.Text == "confirm password")
        //    {
        //        txt_con_password.Text = "";
        //        txt_con_password.ForeColor = Color.Black;
        //    }
        //}

        //private void txt_con_password_Leave(object sender, EventArgs e)
        //{
        //    if (txt_con_password.Text == "")
        //    {
        //        txt_con_password.Text = "confirm password";
        //        txt_con_password.ForeColor = Color.Silver;
        //    }
        //}

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void next_button_Click(object sender, EventArgs e)
        {

            // check if the email is valid 
            if (txt_email.Text == "EMAIL ADDRESS")
            {
                MessageBox.Show("Please enter a valid email address");
            }

            // check if contains @
            else if (!txt_email.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address");
            }

            else if (txt_password.Text == "at least 8 characters")
            {
                MessageBox.Show("Please enter a valid password");
            }

            else if (txt_con_password.Text == "")
            {
                MessageBox.Show("Please retype your password");
            }

            else if (txt_password.Text != txt_con_password.Text)
            {
                MessageBox.Show("Password does not match");
            }

            else
            {
                // set email and password to the sigleton class
                signup_data.Email = txt_email.Text;
                signup_data.Password = txt_password.Text;
                signup f4 = new signup(signup_data);
                f4.Show();
                this.Hide();
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
