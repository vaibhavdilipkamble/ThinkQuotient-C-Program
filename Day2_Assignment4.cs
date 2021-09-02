using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
       enum WeekDay { SUN, MON,TUE,WED,THU,FRI,SAT };
        static void Main(string[] args)
        {
            Console.WriteLine("DAY");
            int index = int.Parse(Console.ReadLine());
            WeekDay day = (WeekDay)index;

            switch (day)
            {
                case WeekDay.SUN:
                    Console.WriteLine("SUNDAY");
                    Console.ReadLine();
                    break;
                case WeekDay.MON:
                    Console.WriteLine("MONDAY");
                    Console.ReadLine();
                    break;
                case WeekDay.TUE:
                    Console.WriteLine("TUESDAY");
                    Console.ReadLine();
                    break;
                case WeekDay.WED:
                    Console.WriteLine("WEDNESDAY");
                    Console.ReadLine();

                    break;
                case WeekDay.THU:
                    Console.WriteLine("THURSADAY");
                    Console.ReadLine();
                    break;
                case WeekDay.FRI:
                    Console.WriteLine("FRIDAY");
                    Console.ReadLine();
                    break;
                case WeekDay.SAT:
                    Console.WriteLine("SATRDAY");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("NONE");
                    break;
                    Console.ReadLine();
            }



        }
    }
}