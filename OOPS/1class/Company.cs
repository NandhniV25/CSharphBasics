using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1class
{
    public class Company
    {
        //Members
        public int id = 1;
        private string name = "Google";

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //public void Setter(string nameSetter)
        //{ 
        //    this.name = nameSetter; 
        //}

        //public string Getter()
        //{
        //    return this.name;
        //}

        //Function
        //public void DisplayCompanyDetails()
        //{
        //    Console.WriteLine($"Id = {id} and Company = {name}");
        //}

        public void DisplayCompanyDetails()
        {
            Console.WriteLine($"Id = {id} and Company = {Name}");
        }
    }
}
