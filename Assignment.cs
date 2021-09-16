using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] student = new string[5];
            string name;
            try
            {
                Console.WriteLine("enter students name");
                for (int i = 1; i <= 5; i++)
                {
                    name = Console.ReadLine();
                    student[i] = name;

                }
                Console.WriteLine("array of student ");
                for (int i = 0; i <= 4; i++)
                {
                    Console.WriteLine(student[i]);
                }
                name = Console.ReadLine();
                student[6] = name;

            }
            catch (IndexOutOfRangeException  e)
            {
                Console.WriteLine(e.Message);

            }
            catch (Exception)
            {
                Console.WriteLine("error");
            }
            Console.Read();


        }
    }
}