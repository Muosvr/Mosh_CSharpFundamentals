using System;


namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Count.Divisible(100);
            Console.WriteLine(number);

            Console.WriteLine("Sum is: {0}", Count.Add());
        }

    }
}
