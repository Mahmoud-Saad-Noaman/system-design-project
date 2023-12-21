using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Transformation
{
    public class signup_data_class
    {
        private string _email;
        private string _password;
        private string _phone;
        private string _hospital_name;
        private string _hospital_address;
        private float _pickup_lat;
        private float _pickup_long;
        private string _city;


        public string Email { 
            get
            { 
                return _email;
            }

            set
            { 
                // check if the email is valid
                if (value.Contains("@") && value.Contains(".com"))
                {
                    _email = value;
                }
                else
                {
                    MessageBox.Show("Invalid email");
                    //throw new Exception("Invalid email");
                }
            } 
        
        }
        public string Password {
            get 
            {
                return _password;
            } 
            set
            {
                // check if the password is at least 8 characters long
                if (value.Length >= 8)
                {
                    _password = value;
                }
                else
                {
                    MessageBox.Show("Password must be at least 8 characters long");
                    //throw new Exception("Password must be at least 8 characters long");
                }
            }
        }

        // make a setter that only accepts valid phone numbers 
        public string Phone {
            get { return _phone; }
            set 
            {
                // check if the phone number is valid, and not a string 
                if (value.Length == 11 && value.All(char.IsDigit))
                {
                    _phone = value;
                }
                else
                {
                    MessageBox.Show("Invalid phone number");
                    //throw new Exception("Invalid phone number");
                }
            }
        }



        public string Hospital_name { 
            get
            {
                return _hospital_name;
            }
            set
            {
                _hospital_name = value;
            }

        }

        public string Hospital_address { 
            get
            {
                return _hospital_address;
            }

            set
            {
                _hospital_address = value;
            }
                
        }


        // make a setter that accepts only valid pick lat and long

        public float Pickup_lat { 
            get
            {
                return _pickup_lat;
            } 

            set
            {
                // check if the pickup lat is valid
                if (value >= -90 && value <= 90)
                {
                    _pickup_lat = value;
                }
                else
                {
                    MessageBox.Show("Invalid pick latitude");
                    //throw new Exception("Invalid pick latitude");
                }
            }

        }

        public float Pickup_long
        {
            get
            {
                return _pickup_long;
            }

            set
            {
                // check if the pickup long is valid
                if (value >= -180 && value <= 180)
                {
                    _pickup_long = value;
                }
                else
                {
                    MessageBox.Show("Invalid pick longitude");
                    //throw new Exception("Invalid pick longitude");
                }
            }
        }


        public string City { 
            get
            {
                return _city;
            }

            set
            {
                _city = value;
            }
        }
    }
}
