using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6HierarchicalInheritance
{
    public class Employee : Company
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }

        public Employee(int employeeId, string employeeName, string address, int companyId, string companyName, string location)
            : base(companyId, companyName, location)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            Address = address;
        }

        public void EmployeeDetails()
        {
            Console.WriteLine($" EmployeeName = {EmployeeName} and EmployeeAddress = {Address}");   
        }

        public void EmployeeCompanyDetails()
        {
            Console.WriteLine($" CompanyName = {CompanyName} and EmployeeName = {EmployeeName}");   
        }
    }
}
