using System.Security.Cryptography.X509Certificates;

namespace _4MultipleInheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee googleEmployee = new Employee(101,"Nandhni", "Bangkok", 10000.9876, 1, "Google", "India");
            
            //Base Class function and property
            //parent Company Class
            googleEmployee.CompanyName = "Youtube";
            googleEmployee.DisplayCompanyDetails();

            //Derived Class function and property
            //child Employee Class
            googleEmployee.EmployeeCompanyDetails();
            googleEmployee.EmployeeDetails();

            //Interface function
            googleEmployee.SalaryDetails();

        }
    }
}