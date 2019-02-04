using System;

namespace Assignment4 
{
    class TestClass
     {
        static void Main (string[] args)
         {
            Fraction f1 = new Fraction (1, 3);
            Console.WriteLine (f1.ToString ());

            Console.WriteLine ("ADDITION:");

            Fraction add1 = new Fraction {
                Numerator = 1,
                Denominator = 8
            };

            Fraction add2 = new Fraction (1, 5);
            Fraction addition = add1 + add2;
            Console.WriteLine (addition.ToString ());

            Fraction addition2 = f1 + add2;
            Console.WriteLine (addition2.ToString ());

            Fraction add3 = new Fraction (1, 2);
            Console.WriteLine ((add3 + add3).ToString ());

            Console.WriteLine ((new Fraction (8, 27) + new Fraction (15, 47)).ToString ());

            // subtraction

            Console.WriteLine ("SUBTRACTION:");

            Console.WriteLine ((new Fraction (26, 41) - new Fraction (3, 5)).ToString ());
            Console.WriteLine ((new Fraction (8, 27) - new Fraction (15, 47)).ToString ());

            // Multiplication

            Console.WriteLine ("MULTIPLICATION:");

            Console.WriteLine ((new Fraction (2, 7) * new Fraction (8, 19)).ToString ());

            // Division
            Console.WriteLine ("DIVISION:");
            Console.WriteLine ((new Fraction (40, 5) / new Fraction (2, 3)).ToString ());

            // Error handling
            Fraction error = new Fraction 
            {
                Numerator = 5,
                Denominator = 0
            };

            Fraction a = new Fraction (1, 5);
            Fraction errorRes = error + a;
        }
    }
}