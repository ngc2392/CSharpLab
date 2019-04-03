using System;

namespace Assignment5
{
    class AnalyzingData
    {

        
        public delegate int ArrayAnalysisDelegate(int[] numbers);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] numbers = new int[] {1,3,15,8,3,6,11,77,9,8,15,17};

            ArrayAnalysisDelegate minEntryDelegate = new ArrayAnalysisDelegate(minimumEntry);
            ArrayAnalysisDelegate maxEntryDelegate = new ArrayAnalysisDelegate(maximumEntry);
            ArrayAnalysisDelegate medianValueDelegate = new ArrayAnalysisDelegate(medianValue);
            //ArrayAnalysisDelegate averageValueDelegate = new ArrayAnalysisDelegate(averageValue);
            //ArrayAnalysisDelegate standardDeviationDelegate = new ArrayAnalysisDelegate(standardDeviation);

            minEntryDelegate(numbers);
            maxEntryDelegate(numbers);
            medianValueDelegate(numbers);
    
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

            Console.WriteLine("Minimum entry " + min);
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
            
            Console.WriteLine("Maximum entry " + max);
            return max;
        }

        
        public static int medianValue(int[] numbers)
        {
            int median = 0;

            Array.Sort(numbers);
            if(numbers.Length % 2 == 0) { //even number of entries
                double val = (numbers[(numbers.Length/2)-1] + numbers[(numbers.Length/2)])/2.0;
                Console.WriteLine("Median value is " + val);
            } else { //odd number of entries
                int iteration = 0;
                foreach (int i in numbers) {
                    iteration++;
                    if(iteration == (numbers.Length / 2)+1) {
                        Console.WriteLine("Median value is " + i);
                        return i;
                    }
                }
            }
            return median;
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

        // https://stackoverflow.com/a/5336513/9599554
        /* 
        public static int standardDeviation(int[] numbers) 
        {

            
        }
        */

    }
}
