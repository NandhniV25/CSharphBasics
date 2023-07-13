using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5MultilevelInheritance
{
    public class Company
    {
        //property
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }

        //constructor
        public Company(int companyId, string companyName, string location)
        {
            CompanyId = companyId;
            CompanyName = companyName;
            Location = location;
        }

        //method or function
        public void DisplayCompanyDetails()
        {
            Console.WriteLine($" Id = {CompanyId} and Name = {CompanyName} and Location = {Location}");
        }

        public void DisplayData()
        {
            Console.WriteLine($"Id = {CompanyId} and Company = {CompanyName}");
        }
    }
}
