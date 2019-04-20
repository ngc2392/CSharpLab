using System;

namespace Assignment5
{
    class AnalyzingData
    {

        
        public delegate double ArrayAnalysisDelegate(int[] numbers);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] numbers = new int[] {1,3,15,8,3,6,11,77,9,8,15,17};

            ArrayAnalysisDelegate minEntryDelegate = new ArrayAnalysisDelegate(minimumEntry);
            ArrayAnalysisDelegate maxEntryDelegate = new ArrayAnalysisDelegate(maximumEntry);
            ArrayAnalysisDelegate medianValueDelegate = new ArrayAnalysisDelegate(medianValue);
            ArrayAnalysisDelegate averageValueDelegate = new ArrayAnalysisDelegate(averageValue);
            ArrayAnalysisDelegate standardDeviationDelegate = new ArrayAnalysisDelegate(standardDeviation);

            Console.WriteLine("Minimum Entry: "+ minEntryDelegate(numbers));
            Console.WriteLine("Maximum Entry: " + maxEntryDelegate(numbers));
            Console.WriteLine("Median value: " + medianValueDelegate(numbers));
            Console.WriteLine("Average value: " + averageValueDelegate(numbers));
            Console.WriteLine("Standard Deviation value: " + standardDeviationDelegate(numbers));

        }

        public static double minimumEntry(int[] numbers) 
        {
            int min = numbers[0];

            foreach (int number in numbers)
            {
                if(number < min) 
                {
                    min = number;
                }
            }

            //Console.WriteLine("Minimum entry " + min);
            return min;

        }

        public static double maximumEntry(int[] numbers)
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
            //Console.WriteLine("Maximum entry " + max);
        }

        
        public static double medianValue(int[] numbers)
        {
            double median = 0;

            Array.Sort(numbers);
            if(numbers.Length % 2 == 0) { //even number of entries
                double val = (numbers[(numbers.Length/2)-1] + numbers[(numbers.Length/2)])/2.0;
                median = val;
                //Console.WriteLine("Median value is " + val);
            } else { //odd number of entries
                int iteration = 0;
                foreach (int i in numbers) {
                    iteration++;
                    if(iteration == (numbers.Length / 2)+1) {
                        //Console.WriteLine("Median value is " + i);
                        median = i;
                    }
                }
            }
            return median;
        }
        

        public static double averageValue(int[] numbers) 
        {

        int sum = 0;
        for(int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        double average = (double) sum / numbers.Length;

        return average;
        //Console.WriteLine("The average value is " + average);
      
}

        // https://stackoverflow.com/a/5336513/9599554
        
        public static double standardDeviation(int[] numbers) 
        {
            // get the mean
            double avg = averageValue(numbers);

            // for each number: subtract the Mean and square the result
            var squaredDifferences = new double[numbers.Length];

            var i = 0;
            foreach(var num in numbers) 
            {
                // subtract the Mean and square the result
                double temp = (avg - num);
                // squaredd difference
                double square = temp * temp;

                // add the squared difference
                squaredDifferences[i] = square;
                i++;
            }

            // get the mean of those squared differences
            double avgOfSquaredDifferences;

            double sum = 0;
            for (i = 0; i < squaredDifferences.Length; i++)
            {
                sum += squaredDifferences[i];
            }

            avgOfSquaredDifferences = (double)sum / numbers.Length;

            // take the square root
            double standardDeviation = Math.Sqrt(avgOfSquaredDifferences);

            // done
            return standardDeviation;
            
        }
        

    }
}
