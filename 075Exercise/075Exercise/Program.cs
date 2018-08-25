using System;
using System.IO;
using System.Text;

namespace _075Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"d:\CareerDev\Mosh_CSharpFundamentals\075Exercise\Hello.txt";
            Program exercise = new Program();
            //exercise.Exercise1(path);
            Console.WriteLine("The longest word is " + exercise.Exercise2(path));
        }

        public void Exercise1(string path)
        {
            var file = File.ReadAllText(path);
            var array = file.Split(' ');
            //var input = File.Exists(@"d:\CareerDev\Mosh_CSharpFundamentals\Hello.txt");

            Console.WriteLine("There are {0} words in this file", array.Length);
            //Console.WriteLine(input);
        }

        public string Exercise2(string path)
        {
            var file = File.ReadAllText(path);
            var array = file.Split(' ');
            var longestWord = new StringBuilder();
            
            foreach (string word in array)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord.Clear();
                    longestWord.Append(word);
                }  
            }

            return longestWord.ToString();
        }
    }
}
