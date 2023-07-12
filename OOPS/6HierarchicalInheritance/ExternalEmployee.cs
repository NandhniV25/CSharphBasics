using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6HierarchicalInheritance
{
    public class ExternalEmployee : Company
    {
        public  int  ExEmployeeId { get; set; }
        public string ExEmployeeName { get; set; }
        public double ExSalary { get; set; }

        public ExternalEmployee(int exEmployeeId, string exEmployeeName, double exSalary, int 
            companyId, string companyName, string location) :
            base(companyId, companyName, location)
        {
            ExEmployeeId = exEmployeeId;
            ExEmployeeName = exEmployeeName;
            ExSalary = exSalary;
        }

        public void ExEmployeeCompanyDetails()
        {
            Console.WriteLine($" ExternalEmployeeName = {ExEmployeeName} and CompanyName = {CompanyName}");
        }
    }
}
