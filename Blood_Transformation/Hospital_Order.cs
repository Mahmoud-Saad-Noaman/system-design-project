using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Transformation
{
    public class Hospital_Order
    {
        // last and first names of the patient 
        private string _patient_fname;
        private string _patient_lname;
        private string _blood_type;
        private int _amount;


        // setter and getter for patient first and last name 
        public string Patient_fname
        {
            get { return _patient_fname; }
            set { _patient_fname = value; }
        }

        public string Patient_lname
        {
            get { return _patient_lname; }
            set { _patient_lname = value; }
        }

        public string Blood_type
        {
            get { return _blood_type; }
            set { _blood_type = value; }
        }

        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
    }


}
