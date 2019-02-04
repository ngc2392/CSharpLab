/*
    Assignment: Once you're done, complete this assignment by writing a program 
    that reads in an integer n, and displays all prime numbers between 1 and n.
 */

using System;

namespace Assignment1
{
    class DisplayPrimeNumbers
    {
        static void Main(string[] args)
        {
            int userInput;
            Console.WriteLine("Please enter a number");
            userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You typed " + userInput);

            for (int i = 0; i < userInput; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static bool IsPrime(int numberToCheck)
        {
            // We'll count 1 as not prime.  I'm not sure though
            if (numberToCheck == 1)
            {
                return false;
            }
            else if (numberToCheck == 2)
            {
                return true;
            }
            else if (numberToCheck % 2 == 0)
            {
                return false;
            }
            else
            {
                for (int i = 3; i < numberToCheck; i++)
                {

                    if (numberToCheck % i == 0)
                    {
                        return false;
                    }

                }
            }
            // the number got past the for loop, so it must be prime
            return true;
        }
    }
}