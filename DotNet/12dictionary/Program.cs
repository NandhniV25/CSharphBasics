using System.Collections;

namespace dictionary
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(1, "a");
            keyValuePairs.Add(5, "a");
            keyValuePairs.Add(23, "a");
            keyValuePairs.Add(6, "a");
            keyValuePairs.Add(7, "a");

            for (int i = 0; i<keyValuePairs.Count; i++)
            {
                Console.WriteLine($"{keyValuePairs.Keys.ElementAt(i)} : {keyValuePairs.Values.ElementAt(i)}");
            }

            Console.WriteLine("delete");
            keyValuePairs.Remove(23);
            for (int i = 0; i < keyValuePairs.Count; i++)
            {
                Console.WriteLine($"{keyValuePairs.Keys.ElementAt(i)} : {keyValuePairs.Values.ElementAt(i)}");
            }
        }
    }
}