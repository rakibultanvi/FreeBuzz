﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstGitHubApp
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                if (i % 3 == 0 && i%5==0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                //change code vvvvvv
 
            }
            Console.ReadKey();
        }
    }
}
