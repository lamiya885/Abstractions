using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Group
    {
        public string GroupNo;
        private int _studentLimit;
        public int StudentLimit
        {
            get
            {
                return _studentLimit;
            }
            set
            {
                if (value > 5 && value < 18)
                {
                    _studentLimit = value;
                }
            }
        }

        private Student[] students;
        public string pattern1 = @"^[A-Z]{2}\d{3}$";

        public Group(string groupNo, int studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
        }

        public void CheckGroupNo(string groupNo)
        {
            if (Regex.IsMatch(groupNo, pattern1))
            {
                Console.WriteLine($"{groupNo}qrup nomresi dogrudur! ");

            }
            else
            {
                Console.WriteLine($"{groupNo}qrup nomresi yanlisdir! ");
            }




        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            if (students.Length > StudentLimit)
            {
                Console.WriteLine($"{GroupNo} doludur ");
            }
            else
            {
                students[students.Length - 1] = student;
            }
        }
        public void GetStudent(int id)
        {

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].IdStudent = id)
                {
                    Console.WriteLine(students[i].StudentInfo);
                }
                else
                {
                    Console.WriteLine($"{id}-a uygunt telebe yoxdur");
                }

            }

        }
        public void GetAllStudents()
        {
            Student[] foundedStudents = new Student[students.Length];
            for (int i = 0;i < students.Length; i++)
            {
                foundedStudents[i] = students[i];
            }
            Console.WriteLine(foundedStudents);
        }
    }
}
