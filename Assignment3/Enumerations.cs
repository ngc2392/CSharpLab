using System;

namespace Assignment3
{

    enum VolumeLevels
    {
        low = 1,
        medium = 2,
        high = 3
    }
    class Enumerations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number from 1-3");

            int userInput = Convert.ToInt32(Console.ReadLine());

            string userChoice = ProcessUserInput(userInput);

            if (userChoice != "ERROR")
            {
                Console.WriteLine("You choose " + userChoice);
            }
            else
            {
                Console.WriteLine("Please enter correct input");
            }
        }

        static public string ProcessUserInput(int input)
        {

            String choice = "";
            switch (input)
            {
                case 1:
                    choice = Enum.GetName(typeof(VolumeLevels), 1);
                    return choice;
                case 2:
                    choice = Enum.GetName(typeof(VolumeLevels), 2);
                    return choice;
                case 3:
                    choice = Enum.GetName(typeof(VolumeLevels), 3);
                    return choice;
                default:
                    return "ERROR";
            }
        }
    }


}