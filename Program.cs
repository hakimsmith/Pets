using System;

namespace VirtualPetTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            string startExit = "";
            bool playing = true;
            do
            {
                Console.WriteLine("1 = start: 2 = exit");
                startExit = Console.ReadLine();

                if (startExit == "2")
                {
                    playing = false;
                }

            } while (playing);
            
            Cat fatCat = new Cat("Fatcat", "Tabbycat");
                
            Console.WriteLine("Goodbye");
        }
    }
}
