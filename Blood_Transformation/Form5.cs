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
    public partial class Form5 : MaterialForm
    {
        // create an public instance of Hospital_Order
        Hospital_Order final_order_info = new Hospital_Order();

        public Form5(Hospital_Order order_info)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);


            txt_blood_type.Items.Add("AB+");
            txt_blood_type.Items.Add("AB-");
            txt_blood_type.Items.Add("A+");
            txt_blood_type.Items.Add("A-");
            txt_blood_type.Items.Add("B+");
            txt_blood_type.Items.Add("B-");
            txt_blood_type.Items.Add("O+");
            txt_blood_type.Items.Add("O-");

            // set patient first and last name from the order_info object
            final_order_info = order_info;
        }


        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void txt_blood_type_Enter(object sender, EventArgs e)
        {
            if(txt_blood_type.Text == "BLOOD TYPE")
            {
                txt_blood_type.Text = "";
                txt_blood_type.ForeColor = Color.Black;
            }
        }
        private void txt_blood_type_Leave(object sender, EventArgs e)
        {
            if (txt_blood_type.Text == "")
            {
                txt_blood_type.Text = "BLOOD TYPE";
                txt_blood_type.ForeColor = Color.Silver;
            }
        }
        private void txt_liters_blood_Enter(object sender, EventArgs e)
        {
            if(txtbox_amount.Text == "LITERS OF BLOOD NEEDED")
            {
                txtbox_amount.Text = "";
                txtbox_amount.ForeColor = Color.Black;
            }
        }

        private void txt_liters_blood_Leave(object sender, EventArgs e)
        {
            if (txtbox_amount.Text == "")
            {
                txtbox_amount.Text = "LITERS OF BLOOD NEEDED";
                txtbox_amount.ForeColor = Color.Silver;
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            order f3 = new order();
            f3.Show();
            this.Hide();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("the request executed successfully");
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            // check if the amount given is a number 
            int amount;
            bool isNumeric = int.TryParse(txtbox_amount.Text, out amount);
            if(!isNumeric)
            {
                MessageBox.Show("Please enter a valid amount");
            }

            else
            {
                // store patient;s blood type and amount in the final_order_info object
                final_order_info.Amount = amount;
                final_order_info.Blood_type = txt_blood_type.Text;

                // make the connection string look for database in the project folder
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Blood_Delivery_Database.mdf;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // insert the patient's first and last name, blood type and amount into the database
                    using (SqlCommand command = new SqlCommand("INSERT INTO orders (order_account_ID, patient_firstname, patient_lastname, blood_type, amount) VALUES (@order_account_ID, @patient_firstname, @patient_lastname, @blood_type, @amount)", connection))
                    {
                        command.Parameters.AddWithValue("@order_account_ID", Current_User.user_id);
                        command.Parameters.AddWithValue("@patient_firstname", final_order_info.Patient_fname);
                        command.Parameters.AddWithValue("@patient_lastname", final_order_info.Patient_lname);
                        command.Parameters.AddWithValue("@blood_type", final_order_info.Blood_type);
                        command.Parameters.AddWithValue("@amount", final_order_info.Amount);
                        command.ExecuteNonQuery();
                    }
                }

                // return to the order form
                order f3 = new order();
                f3.Show();
                this.Hide();
            }
        }
    }
}
