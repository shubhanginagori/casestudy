using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    class holiday
    {
        static void Main(string[] args)
        {
            int dayno = int.Parse(Console.ReadLine());
            switch (dayno)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine($"Working day");
                    break;
                case 6:
                case 7:
                    Console.WriteLine($"Holiday");
                    break;
                default:
                    Console.WriteLine($"enter valid day number");
                    break;
            }
        }
    }
}
