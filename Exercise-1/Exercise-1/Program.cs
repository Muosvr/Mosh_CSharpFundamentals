using System;


namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex 1 & 2
            var number = Count.Divisible(100);
            Console.WriteLine(number);

            Console.WriteLine("Sum is: {0}", Count.Add());
            */

            /* Ex. 3
            Console.WriteLine("Please enter a number");
            var num =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factorial is: {0}", Count.Factorial(num));
            */

            /* Ex. 4
            var random = new Random();
            var num = random.Next(1, 10);
            bool win = false;
            Console.WriteLine("Random number: {0}", num);
            for (int i = 0; i<4; i++)
            {
                Console.WriteLine("Please enter a guess: ");
                var input = Convert.ToInt32(Console.ReadLine());
                if(input == num)
                {
                    Console.WriteLine("You won");
                    win = true;
                    break;
                    
                }
            }

            if (!win)
            {
                Console.WriteLine("You lost");
            }
            */

            /*
            Console.WriteLine("Please enter numers separated by comma: ");
            string input = Console.ReadLine();
            var placeHolder = 0;
            foreach(var c in input)
            {
                if(c != ',')
                {
                    var num = Convert.ToInt32(c) - '0';
                    
                    if(placeHolder < num)
                    {
                        placeHolder = num;
                    }
                }
            }

            Console.WriteLine("Max number is: {0}", placeHolder);
            */

        }

    }
}
