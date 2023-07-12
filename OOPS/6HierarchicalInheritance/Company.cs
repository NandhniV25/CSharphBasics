using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6HierarchicalInheritance
{
    public class Company
    {
        //property
        public int CompanyId { get; set; }  
        public string CompanyName { get; set; }
        public string Location { get; set; }

        //constructor ctor
        public Company(int companyId, string companyName, string location)
        {
            CompanyId = companyId;
            CompanyName = companyName;
            Location = location;
        }

        //function
        public void CompanyDetails()
        {
            Console.WriteLine($" CompanyId = {CompanyId} and CompanyName = {CompanyName} and Location = {Location}");
        }
    }
}
