using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your First Number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Second Number:");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine($"Number {a} is Large");
                Console.ReadLine();
            }   else if (b > a) { 
                Console.WriteLine($"Number {b} is Large");
                Console.ReadLine();
              
        }
    }
}