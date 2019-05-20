using System;

namespace VirtualPetTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuChoice = "";
            bool playing = true;
            do
            {
                Console.WriteLine("1 = start: 2 = add pet: 3 = exit");
                menuChoice = Console.ReadLine();


                switch (menuChoice)
                {
                    case "1":
                        break;
                    case "2":
                        
                        Console.WriteLine("What would you like to name your pet?");
                        string Name = Console.ReadLine();
                        Console.WriteLine("What would you like its species?");
                        string Species = Console.ReadLine();

                        break;
                    case "3":
                        Environment.Exit(0);
                        break;

                    
                
                        





                }


/*

                if (menuChoice == "3")
                {
                    playing = false;
                }
                if (menuChoice == "2") 
*/
                    
            }

            
                while (playing) ;

            

            

            Cat fatCat = new Cat("Fatcat", "Tabbycat");
                
            Console.WriteLine("Good bye player.");
        }
    }
}
