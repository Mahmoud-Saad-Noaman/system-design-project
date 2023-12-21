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
    public partial class order : MaterialForm
    {
        public order()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }


        private void txt_patients_fname_Enter(object sender, EventArgs e)
        {
            if(txt_patients_fname.Text == "i.e john")
            {
                txt_patients_fname.Text = "";
                txt_patients_fname.ForeColor = Color.Black;
            }
        }

        private void txt_patients_fname_Leave(object sender, EventArgs e)
        {
            if (txt_patients_fname.Text == "")
            {
                txt_patients_fname.Text = "i.e john";
                txt_patients_fname.ForeColor = Color.Silver;
            }
        }

        private void txt_patients_lname_Enter(object sender, EventArgs e)
        {
            if(txt_patients_lname.Text == "i.e doe")
            {
                txt_patients_lname.Text = "";
                txt_patients_lname.ForeColor = Color.Black;
            }
        }

        private void txt_patients_lname_Leave(object sender, EventArgs e)
        {
            if (txt_patients_lname.Text == "")
            {
                txt_patients_lname.Text = "i.e doe";
                txt_patients_lname.ForeColor = Color.Silver;
            }

        }

        //private void txt_phone_Enter(object sender, EventArgs e)
        //{
        //    if(txt_phone.Text == "PHONE NUMBER")
        //    {
        //        txt_phone.Text = "";
        //        txt_phone.ForeColor = Color.Black;
        //    }
        //}

        //private void txt_phone_Leave(object sender, EventArgs e)
        //{
        //    if (txt_phone.Text == "")
        //    {
        //        txt_phone.Text = "PHONE NUMBER";
        //        txt_phone.ForeColor = Color.Silver;
        //    }
        //}

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
            
        }

        //private void cont_Click(object sender, EventArgs e)
        //{
        //    Form5 f5 = new Form5();
        //    f5.Show();
        //    this.Hide();
        //}


        private void continue_button_Click(object sender, EventArgs e)
        {
            // check if name contains numbers
            if (txt_patients_fname.Text.Any(char.IsDigit) || txt_patients_lname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid name");
            }

            // check if patients first and last name is valid 
            else if (txt_patients_fname.Text == "i.e john" || txt_patients_lname.Text == "i.e doe")
            {
                MessageBox.Show("Please enter a valid name");
            }


            else
            {
                Hospital_Order order_info = new Hospital_Order();
                order_info.Patient_fname = txt_patients_fname.Text;
                order_info.Patient_lname = txt_patients_lname.Text;
                Form5 f5 = new Form5(order_info);
                f5.Show();
                this.Hide();
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

    }
}
