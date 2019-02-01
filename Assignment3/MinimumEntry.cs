using System;
using System.Collections;

namespace Assignment3
{
    class MinimumEntry
    {
        static void Main(string[] args)
        {

            ArrayList nums = new ArrayList();

            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            nums.Add(4);

            Console.WriteLine("Adding numbers to array list...");

            int minimumEntryOfList = minimumEntry(nums);

            Console.WriteLine("The smallest entry is " + minimumEntryOfList);
        }

        public static int minimumEntry(ArrayList numbers) 
        {
            int min = int.MaxValue;
            foreach (int i in numbers)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }
    }
}
