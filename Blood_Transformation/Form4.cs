using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;


namespace Blood_Transformation
{
    public partial class signup : MaterialForm
    {
        // this stores the data from the previous form as well as this form
        signup_data_class second_form_signup = new signup_data_class();

        public signup(signup_data_class signup_data)
        {
            InitializeComponent();
            //webBrowser1.ScriptErrorsSuppressed = true;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);


            txt_city.Items.Add("Alexandria");
            txt_city.Items.Add("Aswan");
            txt_city.Items.Add("Asyut");
            txt_city.Items.Add("Beheira");
            txt_city.Items.Add("Bani Sweif");
            txt_city.Items.Add("Cairo");            
            txt_city.Items.Add("Dakahlia");
            txt_city.Items.Add("Damietta");
            txt_city.Items.Add("Fayoum");
            txt_city.Items.Add("Gharbia");
            txt_city.Items.Add("Giza");
            txt_city.Items.Add("Helwan");
            txt_city.Items.Add("Hurghada");
            txt_city.Items.Add("Ismailia");
            txt_city.Items.Add("Kafr Al Sheikh");
            txt_city.Items.Add("Luxor");
            txt_city.Items.Add("Mahalla");
            txt_city.Items.Add("Mansoura");
            txt_city.Items.Add("Matrouh");
            txt_city.Items.Add("Menoufia");
            txt_city.Items.Add("Minya");
            txt_city.Items.Add("Nasser City");
            txt_city.Items.Add("New valley");
            txt_city.Items.Add("Port Said");
            txt_city.Items.Add("Qalyubia");
            txt_city.Items.Add("qena");
            txt_city.Items.Add("sharqia");
            txt_city.Items.Add("Shoubra");
            txt_city.Items.Add("Sohag");            
            txt_city.Items.Add("Suez");
            txt_city.Items.Add("Tanta");
            txt_city.SelectedIndex = 5;


            // set the data from the previous form
            second_form_signup.Email = signup_data.Email;
            second_form_signup.Password = signup_data.Password;


        }

        //public Form4(signup_data_class signup_data)
        //{
            //second_form_signup.Email = signup_data.Email;
            //second_form_signup.Password = signup_data.Password;
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    Form2 f2 = new Form2();
        //    f2.Show();
        //    this.Hide();
        //}


        //private void txt_hospital_name_Enter(object sender, EventArgs e)
        //{
        //    if(txt_hospital_name.Text == "HOSPITAL NAME")
        //    {
        //        txt_hospital_name.Text = "";
        //        txt_hospital_name.ForeColor = Color.Black;
        //    }
        //}

        //private void txt_hospital_name_Leave(object sender, EventArgs e)
        //{
        //    if (txt_hospital_name.Text == "")
        //    {
        //        txt_hospital_name.Text = "HOSPITAL NAME";
        //        txt_hospital_name.ForeColor = Color.Silver;
        //    }
        //}

        

        //private void txt_hospital_address_Enter(object sender, EventArgs e)
        //{
        //    if(txt_hospital_address.Text == "HOSPITAL ADDRESS")
        //    {
        //        txt_hospital_address.Text = "";
        //        txt_hospital_address.ForeColor = Color.Black; ;
        //    }
        //}

        //private void txt_hospital_address_Leave(object sender, EventArgs e)
        //{
        //    if (txt_hospital_address.Text == "")
        //    {
        //        txt_hospital_address.Text = "HOSPITAL ADDRESS";
        //        txt_hospital_address.ForeColor = Color.Silver; 
        //    }
        //}

        //private void txt_city_Enter(object sender, EventArgs e)
        //{
        //    if( txt_city.Text == "CITY")
        //    {
        //        txt_city.Text = "";
        //        txt_city.ForeColor = Color.Black;
        //    }
        //}
        
        //private void txt_city_Leave(object sender, EventArgs e)
        //{
        //    if (txt_city.Text == "")
        //    {
        //        txt_city.Text = "CITY";
        //        txt_city.ForeColor = Color.Silver;
        //    }
        //}


        //private void txt_street_Enter(object sender, EventArgs e)
        //{
        //    if(txtbox_phone.Text == "STREET")
        //    {
        //        txtbox_phone.Text = "";
        //        txtbox_phone.ForeColor = Color.Black;
        //    }
        //}

        //private void txt_street_Leave(object sender, EventArgs e)
        //{
        //    if (txtbox_phone.Text == "")
        //    {
        //        txtbox_phone.Text = "STREET";
        //        txtbox_phone.ForeColor = Color.Silver;
        //    }
        //}

        //private void txt_longitude_Enter(object sender, EventArgs e)
        //{
        //    if(txt_longitude.Text == "LONGITUDE")
        //    {
        //        txt_longitude.Text = "";
        //        txt_longitude.ForeColor = Color.Black;
        //    }
        //}

        //private void txt_longitude_Leave(object sender, EventArgs e)
        //{
        //    if (txt_longitude.Text == "")
        //    {
        //        txt_longitude.Text = "LONGITUDE";
        //        txt_longitude.ForeColor = Color.Silver;
        //    }
        //}

        //private void txt_latitude_Enter(object sender, EventArgs e)
        //{
        //    if(txt_latitude.Text == "LATITUDE")
        //    {
        //        txt_latitude.Text = "";
        //        txt_latitude.ForeColor = Color.Black;
        //    }
        //}

        //private void txt_latitude_Leave(object sender, EventArgs e)
        //{
        //    if (txt_latitude.Text == "")
        //    {
        //        txt_latitude.Text = "LATITUDE";
        //        txt_latitude.ForeColor = Color.Silver;
        //    }
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
            //String city = txt_city.Text;
            //string street = txtbox_phone.Text;
            //StringBuilder sb = new StringBuilder();
            //sb.Append("http://maps.google.com/maps?q=");

            //if(city != string.Empty)
            //{
            //    sb.Append(city + "," + "+");
            //}

            //if (street != string.Empty)
            //{
            //    sb.Append(street + "," + "+");
            //}

            //webBrowser1.Navigate(sb.ToString());
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    order f3 = new order();
        //    f3.Show();
        //    this.Hide();
        //}

        //private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        //{

        //}

        //private void submit_button_Click(object sender, EventArgs e)
        //{
            
        //}

        //private void back_button_Click(object sender, EventArgs e)
        //{
        //}

        //private void search_button_Click(object sender, EventArgs e)
        //{

        //}

        //private void Form4_Load(object sender, EventArgs e)
        //{

        //}

        private void submit_button_Click_1(object sender, EventArgs e)
        {
            // check if fields are empty or not
            if (txt_hospital_name.Text == "" || txt_hospital_address.Text == "" || txt_city.Text == "" || txtbox_phone.Text == "" || txt_latitude.Text == "" || txt_longitude.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }


            // check if long and lat are numbers or not
            else if (!float.TryParse(txt_latitude.Text, out float n) || !float.TryParse(txt_longitude.Text, out float m))
            {
                MessageBox.Show("Please enter a valid latitude and longitude");
            }

            // check phone number
            else if (txtbox_phone.Text.Length != 11)
            {
                MessageBox.Show("Please enter a valid phone number");
            }

            else
            {
                // store the data in the second_form_signup object
                second_form_signup.Hospital_name = txt_hospital_name.Text;
                second_form_signup.Hospital_address = txt_hospital_address.Text;
                second_form_signup.City = txt_city.Text;
                second_form_signup.Phone = txtbox_phone.Text;
                second_form_signup.Pickup_lat = float.Parse(txt_latitude.Text);
                second_form_signup.Pickup_long = float.Parse(txt_longitude.Text);

                // go to the login form
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();

                // make the connection string look for database in the project folder
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Blood_Delivery_Database.mdf;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // generate a random hospital 
                    Random rnd = new Random();
                    int hospital_ID = rnd.Next(1, 1000000);


                    // check if the hospital_ID already exists in the database by looping through the database
                    using (SqlCommand command2 = new SqlCommand("SELECT hospital_ID FROM hospitals", connection))
                    {
                        using (SqlDataReader reader = command2.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (hospital_ID == reader.GetInt32(0))
                                {
                                    hospital_ID = rnd.Next(1, 1000000);
                                }
                            }
                        }
                    }


                    // insert the data into the database the hospital_ID table
                    using (SqlCommand command3 = new SqlCommand("INSERT INTO hospitals (hospital_ID, hospital_name, hospital_address, city, phone_number, pickup_latitude, pickup_longitude) VALUES (@hospital_ID, @hospital_name, @hospital_address, @city, @phone_number, @pickup_latitude, @pickup_longitude)", connection))
                    {
                        command3.Parameters.AddWithValue("@hospital_ID", hospital_ID);
                        command3.Parameters.AddWithValue("@hospital_name", second_form_signup.Hospital_name);
                        command3.Parameters.AddWithValue("@hospital_address", second_form_signup.Hospital_address);
                        command3.Parameters.AddWithValue("@city", second_form_signup.City);
                        command3.Parameters.AddWithValue("@phone_number", second_form_signup.Phone);
                        command3.Parameters.AddWithValue("@pickup_latitude", second_form_signup.Pickup_lat);
                        command3.Parameters.AddWithValue("@pickup_longitude", second_form_signup.Pickup_long);
                        command3.ExecuteNonQuery();
                    }

                    // insert the data into the database the accounts_ID table 
                    using (SqlCommand command = new SqlCommand("INSERT INTO accounts (email, password, hospital_ID) VALUES (@Email, @Password, @hospital_ID)", connection))
                    {
                        // add the parameters to the query
                        command.Parameters.AddWithValue("@Email", second_form_signup.Email);
                        command.Parameters.AddWithValue("@Password", second_form_signup.Password);
                        command.Parameters.AddWithValue("@hospital_ID", hospital_ID);

                        // execute the query
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void back_button_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
