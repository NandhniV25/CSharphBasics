using _3Inheritance;
using System.Runtime.CompilerServices;

namespace _1class
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Company googleobj = new Company(1, "Google", "US");
            //googleobj.DisplayCompanyDetails(); //ctrl + space to display suggestions

            ////create another object and print the second company name without overwrite -constructor
            //Company youtubeobj = new Company(2, "Youtube", "India");
            //youtubeobj.DisplayCompanyDetails();

            //Company dellobj = new Company(3, "Dell", "Australia");
            //dellobj.DisplayData();

            //Company facebookobj = new Company(4, "Facebook", "China");
            //facebookobj.DisplayCompanyDetails();

            Employee googleEmployee = new Employee(1, "Google", "India");
            googleEmployee.DisplayCompanyDetails();
        }
    }
}