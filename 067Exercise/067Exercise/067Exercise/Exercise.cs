using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _067Exercise
{
    public class Exercise
    {
        public static void Exercise1()
        {
            Console.WriteLine("Please enter number separated by '-'");
            var input = Console.ReadLine();
            if(IsConsecutive(input, '-'))
                Console.WriteLine("Consecutive");
            else
                Console.WriteLine("Not Consecutive");

        }

        public static bool IsConsecutive(string input, char separator)
        {
            var strArr = input.Split(separator);
            var numArr = new int[strArr.Length];
            var index = 0;

            foreach (var str in strArr)
            {
                numArr[index] = Convert.ToInt32(str);
                if (index != 0)
                {
                    if (numArr[index] == numArr[index - 1] + 1 || numArr[index] == numArr[index - 1] - 1)
                    {

                    }
                    else
                    {
                        return false;
                    }
                }
                index++;
            }
            return true;
        }

        public static void Exercise2()
        {
            Console.WriteLine("Please enter numbers separated by hyphen");
            var rawInput = Console.ReadLine();

            if (!String.IsNullOrEmpty(rawInput))
            {
                var input = rawInput.Split('-');
                if (HasDuplicate(input))
                {
                    Console.WriteLine("Duplicate");
                }
            }


        }

        public static bool HasDuplicate(string[] input)
        {
            var tempList = new List<string>();
            for (var i = 0; i < input.Length; i++)
            {
                var newWord = input[i];
                foreach (var str in tempList)
                {
                    if (newWord == str)
                    {
                        return true;
                    }
                }
                tempList.Add(newWord);
            }
            return false;
        }

        public static void Exercise3()
        {
            Console.WriteLine("Please enter a time value in the 24-hour time format(e.g. 19:00)");
            var input = Console.ReadLine();

            try
            {
                var time = TimeSpan.Parse(input);
                Console.WriteLine("Ok");
            }
            catch
            {
                Console.WriteLine("Invalid Time");
            }
        }

        public static void Exercise4()
        {
            Console.WriteLine("Please enter words separeted by space");
            var input = Console.ReadLine();
            var upper = input.ToUpper();
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(upper);
            stringBuilder.Replace(" ", "");
            Console.WriteLine(stringBuilder);

        }

        public static void Exercise5()
        {
            Console.WriteLine("Please enter an English word");
            var input = Console.ReadLine();

            Console.WriteLine("There are {0} vowels in this word", CountVowels(input));
        }

        public static int CountVowels(string word)
        {
            
            var array = new char[5] { 'a', 'e', 'o', 'u', 'i' };
            var count = 0;

            foreach (char c in word.ToLower())
            {
                if (array.Contains(c))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
