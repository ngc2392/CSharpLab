using System;

namespace Assignment5
{
    class AnalyzingData
    {

        public delegate int ArrayAnalysisDelegate(int[] numbers);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] numbers = new int[] {};

             ArrayAnalysisDelegate minEntryDelegate = new ArrayAnalysisDelegate(minimumEntry);
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

        public static decimal averageValue(int[] numbers) 
        {

        int sum = 0;
        for(int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        decimal average = (decimal)sum / numbers.Length;

      
        return average;


}
        
        public static int standardDeviation(int[] numbers) 
        {

            // https://stackoverflow.com/a/5336513/9599554
        }

    }
}
