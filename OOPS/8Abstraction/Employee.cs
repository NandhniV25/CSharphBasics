using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Abstraction
{
    public class Employee : Company //Company is an abstract class
    {
        //property
        public int EmployeeId { get; set; } 
        public string EmployeeName { get; set; }    
        public string EmployeeType { get; set; }

        //ctor constructor 
        public Employee(int employeeId, string employeeName, string employeeType,
            string companyName, string companyDescription) :
            base(companyName, companyDescription)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            EmployeeType = employeeType;
        }

        //function
        public void SalaryDetails()
        {
            if (EmployeeType.ToUpper() == "BOSS")
            {
                Salary();
            }
            else
            {
                Console.WriteLine(" You are not a boss ");
            }
        }
        private void Salary() // if we put private we can't access the information in the Program class file
        {
            Console.WriteLine(" Salary = 100000 ");
        }

        //Implement abstract class method or function
        public override void CompanyDetails()
        {
            Console.WriteLine($" Company Name = {CompanyName} and " +
                $"Company Descripition = {CompanyDescription}");
        }
    }
}
