using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the entry number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter Developers and programming language");
            List<Tuple<int, string>> list = new List<Tuple<int, string>>(n);
            int j = 0;
            while(j<n)
            {
                string line = Console.ReadLine();
                string[] temp = line.Split(' ');
                list.Add(new Tuple<int, string>(int.Parse(temp[0]), temp[1]));
                j++;
            }
            list.Sort();
            j = 1;
            for (int i = n-1; i >= 0; i--)
            {
                Console.WriteLine("Rank" + "  " + list[i].Item2);
                j++;
            }
            Console.ReadLine();
        }
    }
}