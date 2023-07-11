namespace _1class
{
    class Program
    {
        public static void Main(string[] args)
        {
            Company googleobj = new Company();
            //Overwrite
            //googleobj.id = 2;
            //googleobj.name = "Youtube";
            googleobj.DisplayCompanyDetails(); //ctrl + space to display suggestions

            //create another object and print the second company name without overwrite
            //Company youtubeobj = new Company();
            //youtubeobj.id = 2;
            //youtubeobj.name = "Youtube";
            //youtubeobj.DisplayCompanyDetails();

            //private name using getter method to display and setter method to assign
            //Company youtubeobj = new Company();
            //youtubeobj.id = 2;
            //youtubeobj.Setter("Youtube");
            //Console.WriteLine("Id = {0}", youtubeobj.id);
            //Console.WriteLine("Name = {0}", youtubeobj.Getter());
            //youtubeobj.DisplayCompanyDetails();

            //private name and simplified setter and getter methods 
            Company youtubeobj = new Company();
            youtubeobj.id = 2;
            youtubeobj.Name= "Youtube";
            Console.WriteLine("Id = {0}", youtubeobj.id);
            Console.WriteLine("Name = {0}", youtubeobj.Name);
            youtubeobj.DisplayCompanyDetails();

        }
    }
}