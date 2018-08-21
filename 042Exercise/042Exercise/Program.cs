using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ex.1
            Console.WriteLine("Please enter one number");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input<10 && input > 1)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            */

            /* Ex. 2
            Console.WriteLine("Please enter first number: ");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number: ");
            var num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} is bigger", (num1<num2) ? num2 : num1);
            */

            /* Ex. 3
            Console.WriteLine("Please enter width of the image: ");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter height of the image: ");
            var height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The image is {0}",  (width < height) ? "portrait" : "landscape");
            */

            /*
            var points = 0;
            Console.WriteLine("Please enter the speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the vehicle speed: ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if(carSpeed <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else if(carSpeed > speedLimit)
            {
                points += (carSpeed - speedLimit) / 5;
            }
            Console.WriteLine("Points: {0}", points);

            if (points > 12)
            {
                Console.WriteLine("License Suspended");
            }
            */
        }

    }
}
