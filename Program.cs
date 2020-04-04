using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsb
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee firstEmployee = new Employee("ABC", "DEF");
            firstEmployee.FirstName = "Chandler";
            firstEmployee.LastName = "Bing";
            firstEmployee.Salary = 3599.99m;
            firstEmployee.Age = 30;
            firstEmployee.ItsEducation = Employee.Education.Higher;
            //firstEmployee.PrintInfo();

            Employee secondEmployee = new Employee("ABC", "DEF");
            secondEmployee.FirstName = "Monica";
            secondEmployee.LastName = "Geller";
            secondEmployee.Salary = 4000.00m;
            secondEmployee.Age = 17;
            secondEmployee.ItsEducation = Employee.Education.Higher;
            //secondEmployee.PrintInfo();

            Employee thirdEmployee = new Employee("ABC", "DEF");
            thirdEmployee.FirstName = "Joey";
            thirdEmployee.LastName = "Tribbiani";
            thirdEmployee.Salary = 1000.00m;
            thirdEmployee.Age = 27;
            thirdEmployee.ItsEducation = Employee.Education.Secondary;

            

            Console.WriteLine(firstEmployee.IsAdult());
            Console.WriteLine(secondEmployee.IsAdult2());
            Console.WriteLine(firstEmployee.CheckLogin("ABC", "DEF"));
            Console.WriteLine("##########################");

            EmployeeDb database = new EmployeeDb();
            database.Add(firstEmployee);
            database.Add(secondEmployee);
            database.Add(thirdEmployee);
            database.Print();


            List<Employee> employeeLst = new List<Employee>();
            employeeLst.Add(firstEmployee);
            Console.WriteLine(employeeLst.Count);
            employeeLst.Add(secondEmployee);
            Console.WriteLine(employeeLst.Count);
            employeeLst.Add(thirdEmployee);
            Console.WriteLine(employeeLst.Count);

            for(int i=0; i<employeeLst.Count;i++)
            {
                employeeLst[i].PrintInfo();
            }

            foreach(var employee in employeeLst)
            {
                employee.PrintInfo();
            }

           
            

            Console.Read();
        }

        
    }
}
