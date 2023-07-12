using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Abstraction
{
    public abstract class Company // Abstract class
    {
        //property
        public string CompanyName { get; set; }
        public string CompanyDescription { get; set; }

        //constructor
        public Company(string companyName, string companyDescription)
        {
            CompanyName = companyName;
            CompanyDescription = companyDescription;
        }

        //function-abstract method does not have a body
        //method body is provided by the derived class(inherited from)
        public abstract void CompanyDetails();

    }
}
