using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 5;
            int b = 10;
            Console.WriteLine("The answer is " + (a + b));

            double c = 4.2345;
            double d = 12;

            Console.WriteLine("The answer is " + (c+d));

            float e = 1.3413241234F;
            float f = 3.5F;

            bool boolean1 = true;


            a = 10;
            while(a != 5){
                Console.WriteLine("In the loop");
                a--;
            }


        }
    }
}
