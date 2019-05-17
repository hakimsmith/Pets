using System;

namespace VirtualPetTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            string startExitDirections = "";
            do
            { 
            Console.WriteLine("1 = start: 2 = directions: 3 = exit");
            startExitDirections = Console.ReadLine();

                if (startExitDirections == "2")
                {
                    Console.WriteLine("directions");
                }

            if (startExitDirections == "3")
            {
                Environment.Exit(0);
            }
            }
            while (startExitDirections != "1");

            if (startExitDirections != "3" && startExitDirections != "2")
                {
                    Console.WriteLine("hello");






            }

        }
    }
}
