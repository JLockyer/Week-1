using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_Part3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Read in the radius for the circle
            Console.WriteLine("Enter circle's radius: ");
            string radiusAsAString = Console.ReadLine();
            //{radiusAsString} converts to [radius]
            double radius = Convert.ToDouble(radiusAsAString);
            //The formulas for the perimeter of a circle
            double perimeter = 2 * Math.PI * radius;
            //formula for the area of a circle
            double area = Math.PI * radius * radius;
            Console.WriteLine("Perimeter of the circle is equal to: " + " " + perimeter);
            Console.WriteLine("Area of the circle is equal to: " + " " + area);




        }
    }
}
