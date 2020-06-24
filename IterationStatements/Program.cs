﻿using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers" - DONE
            var numbers = new List<int>();

            //Create a variable of type int and initialize the variable with a value of 0

            int aNumb = 0;

            // Create a do-while loop
            do
            {
                // Increment your variable by 1
                ++aNumb;
                // Then add your variable to "numbers"
                numbers.Add(aNumb);
            } while (aNumb < 100);
            // While your variable is less than 100



            // Create a while loop

            while(aNumb<200)
            // While your variable is less than 200
            {
                // Increment your variable by 1
                ++aNumb;
                // Then add your variable to "numbers"
                numbers.Add(aNumb);
            }

            Console.WriteLine("Increase:");

            // Create a foreach loop
            foreach(var output in numbers)
            // Write your variable to the console

            Console.WriteLine($"{output}");
            Console.WriteLine("Decrease:");

            // Create a for loop
            for (int i = 199; i <= numbers.Count && i >= 0; i--) 
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the length of "numbers"
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            {
                // Write to the console "numbers" at index i
                Console.WriteLine($"{numbers[i]}");
            }
        }
    }
}
