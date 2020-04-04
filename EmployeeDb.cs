using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace wsb
{
    class EmployeeDb
    {
        
        Employee[] employees = new Employee[100];
        int employeeIdx = 0;

        public void Add(Employee employee)
        {
            employees[employeeIdx++] = employee;
        }

        public void Print()
        {
            for (int employee = 0; employee < employeeIdx; employee++)
            {

            }
        }
    }
}
