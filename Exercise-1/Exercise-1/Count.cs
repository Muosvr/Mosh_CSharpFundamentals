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
            
            var run = true;
            int sum = 0;
            do
            {
                Console.WriteLine("Input: ");
                string input = Convert.ToString(Console.ReadLine());
                
                
                if (input == "ok")
                {
                    run = false;
                }
                else
                {
                    int newNum = Convert.ToInt32(input);
                    if (newNum > 10 || newNum < 1)
                    {
                        Console.WriteLine("Input needs to be between 1 and 10");
                    }
                    sum += Convert.ToInt32(input);
                }
            } while (run);

            return sum;
        }

    }
}
