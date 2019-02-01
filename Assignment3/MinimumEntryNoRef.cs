/*
    The array list of ints is a global variable.  The method accesses
    the array list directly and modifies it.  Since we are not
    passing the structure into the method, we are accessing the 
    value of the list, not the reference of the memory address.
 */

using System;
using System.Collections;

namespace Assignment3 {
    class MinimumEntryNoRef {

        static ArrayList nums;
        static void Main (string[] args) {

            nums = new ArrayList();

            nums.Add (5);
            nums.Add (2);
            nums.Add (-6);
            nums.Add (4);
            nums.Add (1);
            nums.Add (-18);
            nums.Add (-6);
            nums.Add (4);

            Console.WriteLine ("Adding numbers to array list...");

            MinimumEntry ();

            // Cast from Object to int
            Object minimumEntryOfList = nums[0];

            Console.WriteLine ("The smallest entry is " + (int) minimumEntryOfList);
        }

        public static void MinimumEntry () {
            nums.Sort();
        }
    }
}