﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _055Exercise
{
    class Exercise
    {
        public static void Exercise1()
        {
            var names = new List<string>();

            Console.WriteLine("Please enter names:");
            while(true)
            {
                var newName = Console.ReadLine();
                if (newName == "")
                {
                    break;
                }
                else
                {
                    names.Add(newName);
                }
                
                
            }
            switch (names.Count)
            {
                case 1:
                    Console.WriteLine("{0} Liked your post!",names[0]);
                    break;
                case 2:
                    Console.WriteLine("{0} and {1} liked your post!", names[0], names[1]);
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("{0}, {1} and others liked your post!", names[0], names[1]);
                    break;
            }
        }

        public static void Exercise2()
        {
            Console.WriteLine("Please enter your name");
            var name = Console.ReadLine();
            var length = name.Length;
            var array = new char[length];
            for(var i = 0; i<length; i++)
            {
                array[length-i-1] = name[i];
            }
            var reverse = new string(array);
            Console.WriteLine("Reversed name is " + reverse);
        }

        public static void Exercise3()
        {
            var array = new int[5];
            bool ok = false;
            var index = 0;

            while (true)
            {
                Console.WriteLine("Please enter a number(5 total): ");
                var newNum = Convert.ToInt32(Console.ReadLine());

                foreach(var num in array)
                {
                    if(num == newNum)
                    {
                        Console.WriteLine("Please try again");
                        ok = false;
                        break;
                    }
                    else
                    {
                        ok = true;
                    }
                }

                if (ok)
                {
                    array[index] = newNum;
                    index++;
                }


                if (index >= 5)
                {
                    break;
                }
            }

            Array.Sort(array);
            Console.WriteLine("The sorted array is: ");
            Console.WriteLine(string.Join(",",array));
        }

        public static void Exercise4()
        {
            var list = new List<int>();

            while (true)
            {
                Console.WriteLine("Please enter a number: ");
                var input = Console.ReadLine();
                var unique = true;


                if(input == "Quit")
                {
                    break;
                }
                else
                {
                    var newNum = Convert.ToInt32(input);

                    foreach (var num in list)
                    {
                        if (num == newNum)
                        {
                            unique = false;
                        }
                    }
                    if (unique)
                        list.Add(newNum);
                }
            }

            Console.WriteLine("Unique numbers are: " + string.Join(",", list));
        }

        public static void Exercise5()
        {
            while(true)
            {
                Console.WriteLine("Please enter five numbers separated by comma:");
                var input = Console.ReadLine().Split(',');
                var result = new int[3];
                if (input.Length < 5)
                {
                    Console.WriteLine("Invalid list");
                }
                else
                {
                    var array = new int[input.Length];
                    var index = 0;
                    foreach(var str in input)
                    {
                        array[index++] = Convert.ToInt32(str);
                    }
                    Array.Sort(array);
                    Array.Copy(array, result, 3);

                    Console.WriteLine("The smallest three numbers are: " + string.Join(",", result));
                    break;
                }
            }
            
        }
    }
}
