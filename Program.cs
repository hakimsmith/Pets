using System;

namespace VirtualPetTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat newCat = new Cat("no name", "no species", 10, 10, 10);
            string menuChoice = "";
            bool playing = true;
            do
            {
                Console.WriteLine("1 = Interact: 2 = Add Pet: 3 = Pet Info: 4 = Exit: 5 = Pet Status:");
                menuChoice = Console.ReadLine();


                switch (menuChoice)
                { 
                    case "1":
                        bool interacting = true;
                        string interact = ""; 
                        do
                        {
                            Console.WriteLine("1 = Feed: 2 = Play: 3 = Take your pet to the Vet: 4 = Quit Interacting");
                            interact = Console.ReadLine();
                            switch (interact)
                            {
                                case "1":
                                    newCat.Feed();
                                    break;
                                case "2":
                                    newCat.Play();
                                    break;
                                case "3":
                                    newCat.Doctor();
                                    break;
                                case "4":
                                    {
                                        interacting = false;
                                    }
                                    break;
                            }
                        }
                        while (interacting);
                        break;

                    case "2":
                        Console.WriteLine("What would you like to name your pet?");
                        newCat.Name = Console.ReadLine();
                        Console.WriteLine("What would you like its species?");
                        newCat.Species = Console.ReadLine();
                        break;
                       
                    case "3":
                        newCat.Greet(); 
                        break;

                    case "4":
                        Environment.Exit(0);
                        break;

                    case "5":
                        newCat.Status();  
                        break;
                }
            }
                while (playing) ;
            Console.WriteLine("Good-bye player.");
        } 
    }
}
