using System.Collections;

namespace hashtable
{
    class Program
    {
        public static void Main(string[] args)
        {
            Hashtable hash = new Hashtable(); // key, value
            hash.Add(1, "Nandhu");
            hash.Add(2, 34);
            hash.Add(3, "Venkat");
            hash.Add("A1", 67);
            hash.Add(65, null);

            //Console.WriteLine(hash["A1"]);
            //Console.WriteLine(hash[65]);

            foreach(DictionaryEntry item in hash)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }    

            hash.Remove(1); // 1 is the hash key. We have to specify the hast key in the remove
            Console.WriteLine("Delete");
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}