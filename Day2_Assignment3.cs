using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3.Accept following fields from user in dictionary. After inserting ask user's input to accept key to delete data from dictionary.
//If key does not exist then prompt message that Key does not exist in collection. If key exists then delete it.
namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>
            {
                {"key1","value1" },
                {"key2","value2" },
                {"key3","value3" }
            };
            string key = "key3";
            bool keyExists = dict.ContainsKey(key);
            if (keyExists)
            {
               
                //dict.Remove(key);
                Console.WriteLine("key is found",key);
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("key does not found", key);
                Console.ReadLine();
            }
        }
    }
}