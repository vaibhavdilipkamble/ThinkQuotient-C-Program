using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialOFNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i, fact = 1, number;
            Console.Write("Enter The Number");
            number = int.Parse(Console.ReadLine());
            Console.Read();
            for(i=1;i<=number;i++)
            {
                fact=fact*i;
            }
            Console.Write("Factorial of" + number + "is"+fact);
            Console.Read();

        }
    }
}