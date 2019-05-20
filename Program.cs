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
                Console.WriteLine("1 = start: 2 = add pet: 3 = pet info: 4 = exit:");
                menuChoice = Console.ReadLine();


                switch (menuChoice)
                {
                    case "1":
                        break;
                    case "2":
                        Cat bigCat = new Cat("no name", "non species");
                        Console.WriteLine("What would you like to name your pet?");
                        bigCat.Name = Console.ReadLine();
                        Console.WriteLine("What would you like its species?");
                        bigCat.Species = Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine(" Your pet's name is" + bigCat.Name + ", the species" + bigCat.Species );
                        break;
                    case "4":
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
