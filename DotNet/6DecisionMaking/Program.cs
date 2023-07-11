using System.Globalization;
using System.Net.Http.Headers;

namespace DecisionMaking
{
    class Program
    {
        public static void Main(string[] args)
        {
            // IF  ELSE
            /*
            int a = 1;
            int b = 2;
            if (a > b)
            {
                Console.WriteLine("a is greater than b");
            }
            else if (a == b)
            {
                Console.WriteLine("a and b is equal");
            }
            else
            {
                Console.WriteLine("a is less than b");
            }*/

            //Nested IF
            Console.WriteLine("Enter age:");
            string ageString = Console.ReadLine();
            //int age = int.Parse(ageString);
            int age;
            bool result = int.TryParse(ageString, out age);
            Console.WriteLine(age);

            if (result)
            {
                if (age > 10)
                {
                    Console.WriteLine("Permission to Enter Mall");
                    if (age > 64)
                    {
                        Console.WriteLine("Permission to Shop in the Mall");
                    }
                    if (age > 18 && age < 50)
                    {
                        Console.WriteLine("Permission to Enter a theater");
                    }
                }
                else
                {
                    Console.WriteLine("Permission Denied");
                }
            }
            else
            {
                Console.WriteLine("Please Enter a Valid age");
            }

            //Switch using string
            Console.WriteLine("Enter colour");
            string colour = Console.ReadLine();
            switch(colour.ToLower())
            {
                case "red":
                    Console.WriteLine("you selected Red");
                    break;

                case "blue":
                    Console.WriteLine("you selected Blue");
                    break;

                case "Yellow":
                    Console.WriteLine("you selected Yellow");
                    break;

                default:
                    Console.WriteLine("invalid option");
                    break;

            }

            //switch using int
            Console.WriteLine("Enter age : ");
            string a = Console.ReadLine();
            int agee = int.Parse(a);
            switch(agee)
            {
                case 10:
                    Console.WriteLine("young");
                    break;
                case 25:
                    Console.WriteLine("teenage");
                    break;
                case 30:
                    Console.WriteLine("adult");
                    break;
                default :
                    Console.WriteLine("invalid");
                    break;
            }
        }
    }
}