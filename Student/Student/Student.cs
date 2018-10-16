using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        public string firstname;
        public string lastname;
        public string date;
        public StudentAddress studentAddress;

        

        public Student(string firstname, string lastname, string date, StudentAddress studentAddress)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.date = date;
            this.studentAddress = studentAddress;
        }


        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }


        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public StudentAddress Studentaddress
        {
            get { return studentAddress; }
            set { studentAddress = value; }
        }

        public string GetStudentInfo()
        {
            if(Firstname == null || Firstname.Trim().Length == 0) {

                return $"Помилка            ";

            }else if(Lastname == null || Lastname.Trim().Length == 0)
            {
                return $"Помилка            ";
            }
            else if (Date == null || Date.Trim().Length == 0)
            {
                return $"Помилка            ";

            }else return "\n Firstname: " + Firstname + "   Lastname: " + Lastname + "   Date: " + Date + Studentaddress;
        }
    }


}
