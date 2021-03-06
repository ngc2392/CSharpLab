﻿using System;
using System.Collections;

namespace Assignment3
{
    class MinimumEntry
    {
        static void Main(string[] args)
        {
            ArrayList nums = new ArrayList();

            nums.Add(5);
            nums.Add(2);
            nums.Add(-6);
            nums.Add(4);
            nums.Add(1);
            nums.Add(-18);
            nums.Add(-6);
            nums.Add(4);

            Console.WriteLine("Adding numbers to array list...");

            int minimumEntryOfList = FindMinimumEntry(nums);

            Console.WriteLine("The smallest entry is " + minimumEntryOfList);
        }

        public static int FindMinimumEntry(ArrayList numbers)
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