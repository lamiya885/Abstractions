using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Student
    {
        private static int _idStudent;
        public static int IdStudent
        {
            get
            {
                return _idStudent;
            }
            set
            {
                if (value >= 0)
                {
                    _idStudent = value;
                }
            }
        }

        public string FullName;
        public int Point;


        public Student(int id)
        {
            IdStudent = id;
        }

        public Student(string fullName, int point)
        {
            FullName = fullName;
            Point = point;
            IdStudent++;
        }

        public void StudentInfo()
        {
            Console.WriteLine($"telebeni adi:{FullName}, telebenin qiymti:{Point}");


        }





    }
}

