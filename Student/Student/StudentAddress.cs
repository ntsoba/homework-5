using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class StudentAddress
    {
        public string country;
        public string town;
        public string address;

        public StudentAddress(string country, string town, string address)
        {
            this.country = country;
            this.town = town;
            this.address = address;
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string Town
        {
            get { return town; }
            set { town = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public override string ToString()
        {
            if (Country == null || Country.Trim().Length == 0)
            {

                return $"Помилка            ";

            }
            else if (Town == null || Town.Trim().Length == 0)
            {
                return $"Помилка            ";
            }
            else if (Address == null || Address.Trim().Length == 0)
            {
                return $"Помилка            ";

            }
            else return "    Country: " + Country + "    Town: " + Town + "     Address: " + Address + " \n";
        }
    }
}
