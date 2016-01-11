using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input of Company Information
            Console.WriteLine("Comapny Information");
            Console.WriteLine("Company Name: ");
            string c = Console.ReadLine();
            Console.WriteLine("Address: ");
            string l = Console.ReadLine();
            Console.WriteLine("Phone Number: ");
            string t = Console.ReadLine();
            Console.WriteLine("Fax Number: ");
            string f = Console.ReadLine();
            Console.WriteLine("Website:");
            string w = Console.ReadLine();
            Console.WriteLine("Manager Name: ");
            string m = Console.ReadLine();           
            //Input of Manager info
            Console.WriteLine("Manager Information");
            Console.WriteLine("Name: ");
            string n = Console.ReadLine();
            Console.WriteLine("Surname: ");
            string u = Console.ReadLine();
            Console.WriteLine("Phone Number: ");
            string h = Console.ReadLine();
            Console.Clear();
            //Completed Company information
            Console.WriteLine("Company Info:" + c + " " + l + " " + t + " " + f + " " + w + " " + m);
            //Complete Manager information
            Console.WriteLine("Manager Information: " + n + " " + u + " " + h);








        }
    }
}
