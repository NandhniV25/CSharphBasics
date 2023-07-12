using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Inheritance
{
    public class Employee : Company  // inherits parent class
    {
        //Child Class / Derived Class / Sub Class

        //prop tab shortcut to create property
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }

        //ctor tab shortcut to create construtor
        public Employee(int companyid, string companyname, string location) : base(companyid, companyname, location)
        {
            
        }
    }
}
