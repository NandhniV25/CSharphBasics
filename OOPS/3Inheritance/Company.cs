using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Inheritance
{
    //Parent Class / Base Class / Super Class
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }

        //Constructor
        public Company(int companyid, string companyname, string location)
        {
            CompanyId = companyid;
            CompanyName = companyname;
            Location = location;
        }

        //Function
        public void DisplayCompanyDetails()
        {
            Console.WriteLine($"Id = {CompanyId} and Company = {CompanyName} and Location = {Location}");
        }

        public void DisplayData()
        {
            Console.WriteLine($"Id = {CompanyId} and Company = {CompanyName}");
        }
    }
}
