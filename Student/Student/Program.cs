using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<Student> list = new List<Student>();

            // list.Add(new Student() {firstname = Console.ReadLine(), lastname = Console.ReadLine(), date = Console.ReadLine()});

            // Console.WriteLine();
            // foreach (Student students in list)
            // {
            //     Console.WriteLine(students);
            // }


            Console.WriteLine("Enter 1 to add the students, 2 to delete, 3 to look throught, 4 to exit:");


            for (int a = 1; a <= 4; a++)
            {
                string output = Console.ReadLine();

                if (output == null || output.Trim().Length == 0)
                {
                    
                    Console.WriteLine("Error");
                    Console.WriteLine("Enter 1 to add the students, 2 to delete, 3 to look throught, 4 to exit:");
                    a = int.Parse(Console.ReadLine());
                    if (a > 4)
                    {
                        Console.WriteLine("Error");
                        Console.WriteLine("Enter 1 to add the students, 2 to delete, 3 to look throught, 4 to exit:");
                        a = int.Parse(Console.ReadLine());
                        if (a == 1)
                        {
                            Console.WriteLine("Enter the name, surname, date, country, town, address");

                            StudentRegistry.AddStudent(new Student(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), new StudentAddress(Console.ReadLine(), Console.ReadLine(), Console.ReadLine())));
                           

                            Console.WriteLine("Enter 1 to add the students, 2 to delete, 3 to look throught, 4 to exit:");

                        }
                        else if (a == 2)
                        {
                            
                            Console.WriteLine("Delete student with index ");
                            Console.WriteLine(StudentRegistry.GetAllInfo());
                            int b = int.Parse(Console.ReadLine());
                            StudentRegistry.RemoveStudent(b);
                            Console.WriteLine("Enter 1 to add the students, 2 to delete, 3 to look throught, 4 to exit:");

                        }
                        else if (a == 3)
                        {
                            Console.WriteLine(StudentRegistry.GetAllInfo());
                            Console.WriteLine("Enter 1 to add the students, 2 to delete, 3 to look throught, 4 to exit:");

                        }
                        else if (a == 4)
                        {
                            Console.WriteLine("To exit - push the button Enter");
                            Console.ReadKey();
                        }
                    }
                    else {
                        Console.WriteLine("Enter 1 to add the students, 2 to delete, 3 to look throught, 4 to exit:");
                        a = int.Parse(output);
                        if (a == 1)
                        {
                            Console.WriteLine("Enter the name, surname, date, country, town, address");

                            StudentRegistry.AddStudent(new Student(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), new StudentAddress(Console.ReadLine(), Console.ReadLine(), Console.ReadLine())));
                           

                            Console.WriteLine("Enter 1 to add the students, 2 to delete, 3 to look throught, 4 to exit:");

                        }
                        else if (a == 2)
                        {
                           
                            Console.WriteLine("Delete student with index ");
                            Console.WriteLine(StudentRegistry.GetAllInfo());
                            int b = int.Parse(Console.ReadLine());
                            StudentRegistry.RemoveStudent(b);
                            Console.WriteLine("Enter 1 to add the students, 2 to delete, 3 to look throught, 4 to exit:");

                        }
                        else if (a == 3)
                        {
                            Console.WriteLine(StudentRegistry.GetAllInfo());
                            Console.WriteLine("Enter 1 to add the students, 2 to delete, 3 to look throught, 4 to exit:");

                        }
                        else if (a == 4)
                        {
                            Console.WriteLine("To exit - push the button Enter");
                            Console.ReadKey();
                        }
                    }
                }else
                {
                    
                    a = int.Parse(output);
                    if (a == 1)
                    {
                        Console.WriteLine("Enter the name, surname, date, country, town, address");

                        StudentRegistry.AddStudent(new Student(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), new StudentAddress(Console.ReadLine(), Console.ReadLine(), Console.ReadLine())));
                       

                        Console.WriteLine("Enter 1 to add the students, 2 to delete, 3 to look throught, 4 to exit:");

                    }
                    else if (a == 2)
                    {
                        
                        Console.WriteLine("Delete student with index ");
                        Console.WriteLine(StudentRegistry.GetAllInfo());
                        int b = int.Parse(Console.ReadLine());
                        StudentRegistry.RemoveStudent(b);
                        Console.WriteLine("Enter 1 to add the students, 2 to delete, 3 to look throught, 4 to exit:");

                    }
                    else if (a == 3)
                    {
                        Console.WriteLine(StudentRegistry.GetAllInfo());
                        Console.WriteLine("Enter 1 to add the students, 2 to delete, 3 to look throught, 4 to exit:");

                    }
                    else if (a == 4)
                    {
                        Console.WriteLine("To exit - push the button Enter");
                        Console.ReadKey();
                    }
                }
                }


            }
        }

    }


