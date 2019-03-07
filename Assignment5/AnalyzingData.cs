using System;

namespace Assignment5
{
    class AnalyzingData
    {

        public delegate void ArrayAnalysisDelegate(int[] numbers);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] numbers = new int[] {};
        }

        public static int minimumEntry(int[] numbers) 
        {
            int min = numbers[0];

            foreach (int number in numbers)
            {
                if(number < min) 
                {
                    min = number;
                }
            }

            return min;

        }

        public static int maximumEntry(int[] numbers)
        {
            int max = numbers[0];

            foreach (int number in numbers)
            {
                if(number > max) 
                {
                    max = number;
                }
            }

            return max;
        }

        public static int medianValue()
        {

        }

        public static int averageValue() 
        {

        }

        public static int standardDeviation() 
        {

        }

    }
}
