namespace _6HierarchicalInheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            ExternalEmployee exEmpObj = new ExternalEmployee(103, "Ashok", 1500000, 3, "Dell", "India");

            //Company
            exEmpObj.CompanyDetails();

            //ExternalEmployee
            exEmpObj.ExEmployeeCompanyDetails();

            //we cannot access the method of sibling classS
        }
    }
}