using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            char character = 'A'; //character uses single quote
            string firstName = "Mosh"; //string uses double quote
            bool isWorking = false;

            Console.WriteLine(number);

            //shortcuts
            Console.WriteLine(number); // cw + tap twice
            Console.WriteLine(count);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            try
            {

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
