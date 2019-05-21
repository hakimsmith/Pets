using System;

namespace VirtualPetTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat newCat = new Cat("no name", "no species");
            string menuChoice = "";
            bool playing = true;
            Console.WriteLine("Welcome to the Pet Shelter.");
            do
            {
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
                Console.WriteLine(" 1 = Interact: \n 2 = Add Pet:\n 3 = Pet Info:\n 4 = Pet Status:\n 5 = Exit:");
                menuChoice = Console.ReadLine();
                switch (menuChoice)
                { 
                    case "1":
                        newCat.Interact();  
                        break;

                    case "2":
                        newCat.AddPet();
                        break;
                       
                    case "3":
                        newCat.PetInfo(); 
                        break;

                    case "4":
                        newCat.PetStatus();
                        break;

                    case "5":
                        playing = false;
                        break;
                }
            }
            while (playing);
        } 
    }
}
