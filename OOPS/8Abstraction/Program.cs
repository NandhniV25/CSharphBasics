namespace _8Abstraction
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee emp1Obj = new Employee(101, "Nandhni", "Normal", "Google", "Top 10 Company in world");
            emp1Obj.SalaryDetails();
            emp1Obj.CompanyDetails();
            //emp1Obj.Salary();

            Employee emp2Obj = new Employee(102, "Venkat", "Boss", "Amazon", "Top 5 Company in world");
            emp2Obj.SalaryDetails();
            emp2Obj.CompanyDetails();//abstract class cannot create obj

            //Company company = new Company(); // cannot create an object in the abstract class

        }
    }
}