using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_Part2
{
    class Program
    {
        static void Main(string[] args)
        {

            //User enters 5 numebers and computer outputs the sum of those 5 numbers
            Console.WriteLine("Enter 5 Numbers: ");
            Console.WriteLine("First Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Second Number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Third Number");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Fourth Number");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("Fifth Number");
            int g = int.Parse(Console.ReadLine());
            int j = (a + b + d + e + g);
            Console.WriteLine("Sum of numbers equals to: " + j);

        }
    }
}
