using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsb
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string Login { get; set; } 
        private string Password { get; set; } 

        public string FullName { get { return $"{FirstName} & {LastName}"; } }
       // public string FullName() => $"{FirstName} &{LastName}";

        private int age { get; set; }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public decimal Salary { get; set; }

        public enum Education
        {
            Primary,
            Secondary,
            Higher
        }

        public Employee(string login, string password)
        {
            Console.WriteLine("Im creating an object");
            Login = login;
            Password = password;
        }

        ~Employee() => Console.WriteLine("Bye x2");
       


        public Education ItsEducation { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine($"Name is: {FirstName} LastName is: {LastName}");
            //Console.WriteLine(LastName);
            Console.WriteLine(Age);
            Console.WriteLine(Salary);
            Console.WriteLine(ItsEducation);
        }
        
        public bool IsAdult()
        {
            if(Age>=18)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public bool IsAdult2()
        {
            return Age >= 18 ? true : false;
        }

        public bool CheckLogin(string login, string password)
        {
            if (Login == login && Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
