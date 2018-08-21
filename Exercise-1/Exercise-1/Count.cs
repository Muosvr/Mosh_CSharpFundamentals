using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class Count
    {
        public static int Divisible(int num)
        {
            var result = 0;
            for (int i=1;i<=num; i++)
            {
                if (100 % i == 0)
                    result++;
            }

            return result;
        }

        public static int Add()
        {
            string input;
            do
            {
                input = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Continue");
            } while (input != "ok");

            return 10;
        }

    }
}
