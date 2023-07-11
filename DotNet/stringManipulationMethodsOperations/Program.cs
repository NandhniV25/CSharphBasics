namespace stringManipulationMethodsOperations
{
    class Program
    {
        public static void Main(string[] args)
        {
            string name = "Nandhni";
            int age = 26;
            string location = "Thailand";

            //string Manipulation - concatenation
            Console.WriteLine("Hi I am " + name + " from " + location + ". \nMy age is " + age);

            //string Manipulation - formatting
            Console.WriteLine("Hi I am {0} from {1}. \nMy age is {2}", name, location, age);

            //string Manipulation - interpolation 
            Console.WriteLine($"Hi I am {name} from {location}. \nMy age is {age}");

            //string Manipulation - verbatim
            Console.WriteLine(@"Hi I am {0} from {1}. \nMy age is {2}", name, location, age);


            string firstName = "Nandhni";
            string lastName = " G A ";
            string fullName = string.Concat( " " + firstName, lastName + " " );

            //string methods
            Console.WriteLine(firstName.ToUpper() + " " + lastName.ToLower());
            Console.WriteLine(fullName.Trim());
            Console.WriteLine(firstName.Substring(2));

            //string operations
            Console.WriteLine(firstName.IndexOf('n'));
            bool data = String.IsNullOrWhiteSpace(fullName);
            Console.WriteLine(data);
        }
    }
}