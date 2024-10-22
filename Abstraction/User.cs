using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Abstraction.Interfaces;

namespace Abstraction
{
    internal class User : IAccount
    {



        public string Fullname;
        public string Email;
        public string Password;
        public string Pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";


        private static  int _id;
        public int Id
            {
            get
            {
                return _id;
            }
            set
            {
                if (value >= 0)
                {
                    _id = value;
                }
            }
        }


        

        public void PasswordChecker(string password) 
        {
            Password = password;
            Console.WriteLine(" bu sertleri odeyen sifre daxil edini:(şifrədə minimum 8 character olmalıdır ,şifrədə ən az 1 böyük hərf olmalıdır,şifrədə ən az 1 kiçik hərf olmalıdır, şifrədə ən az 1 rəqəm olmalıdır)");
            if (Regex.IsMatch(Password, Pattern))
            {
                Console.WriteLine("sifre dogrudur !");
            }
            else
            {
                Console.WriteLine("sifre yuxarideki sertleri odemir");
            }
        
        }




        public  User(string fullName ,string email,string password)
        {
            Fullname = fullName;
            Email = email;
            Password = password;
            Id++;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"istifadecinin ID-si:{Id}, istifadecinin adi:{Fullname},istifadecinin email:{Email}");


        }
    }
}
