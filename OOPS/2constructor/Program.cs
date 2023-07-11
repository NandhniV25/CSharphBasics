using _2constructor;
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

            //Company dellobj = new Company(3, "Dell");
            //dellobj.DisplayData();

            //Company facebookobj = new Company
            //{
            //    Id = 4,
            //    Name = "Facebook",
            //    Location = "India"
            //};
            //facebookobj.DisplayCompanyDetails();


            List<Company> companies = new List<Company>
            {
                new Company
                {
                    Id = 1,
                    Name = "Google",
                    Location ="India"
                },
                new Company
                {
                    Id = 2,
                    Name = "Youtube",
                    Location ="India"
                },
                new Company
                {
                    Id = 3,
                    Name = "Dell",
                    Location ="India"
                },
                new Company
                {
                    Id = 4,
                    Name = "Facebook",
                    Location ="India"
                }
            };

            foreach (var company in companies)
            {
                Console.WriteLine(company.Name);
                Console.WriteLine(company.Location);
            }
        }
    }
}