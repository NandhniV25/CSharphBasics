using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5MultilevelInheritance
{
    public class Employee : Company, IEmployeeSalary  //ctrl + .
    {
        //property
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }

        //constructor
        public Employee(int employeeId, string employeeName, string address, double salary, int companyId, string companyName, string location) : base(companyId, companyName, location)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            Address = address;
            Salary = salary;
        }

        //functions
        public void EmployeeDetails()
        {
            Console.WriteLine($" EmployeeName = {EmployeeName} and EmployeeAddress = {Address}");
        }

        public void EmployeeCompanyDetails()
        {
            Console.WriteLine($" EmployeeName = {EmployeeName} - CompanyName = {CompanyName} and Location = {Location}");
        }

        //interface method implementation

        public void SalaryDetails()
        {
            Console.WriteLine($" EmployeeName = {EmployeeName} and Salary = {Salary}");
        }
    }
}