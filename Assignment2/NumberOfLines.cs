using System;

namespace Assignment2
{
    class NumberOfLines
    {
        static void Main(string[] args)
        {
           Console.Write("Please enter a file name");

           string fileName = Console.ReadLine();

           int numberOfLinesInFile = System.IO.File.ReadAllLines(fileName).Length;

           Console.WriteLine("There are " + numberOfLinesInFile + " lines in the file");
        }
    }
}
