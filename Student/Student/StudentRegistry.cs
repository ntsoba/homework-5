using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    static class StudentRegistry
    {
        static List<Student> addstud = new List<Student>();

        public static void AddStudent(Student stud)
        {
            addstud.Add(stud);
        }

        public static void RemoveStudent(int b)
        {
           
            addstud.RemoveAt(b);

        }

        public static string GetAllInfo()
        {
            string studs = null;
            foreach (Student students in addstud)
            {
                studs = studs + students.GetStudentInfo() + students.ToString();
            }


            return studs;
        }

    }

}






