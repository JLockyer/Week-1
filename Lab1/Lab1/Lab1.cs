using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("User, enter a positive number");
            int userInput = int.Parse (Console.ReadLine());
            string StringInput = Console.ReadLine();
            string EvenOdd = ((userInput/2)=0) ? "even" : "odd";
            Console.WriteLine(EvenOdd);
            //Special class in C# --Convert



        }
    }
}
