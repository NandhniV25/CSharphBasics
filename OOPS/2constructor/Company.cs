using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2constructor
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        //Constructor
        public Company()
        { 
        }

        public Company(int id, string name) 
        {
            Id = id;
            Name = name;
        }

        public Company(int id, string name, string location)
        {
            Id = id;
            Name = name;
            Location = location;
        }

        //Function
        public void DisplayCompanyDetails()
        {
            Console.WriteLine($"Id = {Id} and Company = {Name} and Location = {Location}");
        }

        public void DisplayData()
        {
            Console.WriteLine($"Id = {Id} and Company = {Name}");
        }
    }
}
