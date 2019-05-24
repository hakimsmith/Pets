using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetTeam
{
    class Menus
    {  
        public void GetMainMenu()
        {
            
            string menuChoice = "";
            bool playing = true;
            PetShelter shelter = new PetShelter();
            Cat newCat = new Cat("no name", "no species");
            do
            {
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine(" 1 = Interact: \n 2 = Add Pet:\n 3 = Pet Info & Status:\n 4 = Exit:");
                menuChoice = Console.ReadLine();
                switch (menuChoice)
                {
                    case "1":
                        string subInteractMenu = "";
                        Console.WriteLine("1 = Interact with all; == 2 = Interact with single pet;");
                        subInteractMenu = Console.ReadLine();
                        switch (subInteractMenu)
                        {
                            case "1":
                                shelter.ShelterInteract();
                                break;
                            case "2":
                                shelter.PetSelect();
                                break;
                        }
                        break;

                    case "2":
                        shelter.AddPetToShelter();
                        break;

                    case "3":
                        
                        shelter.ShelterInfo();
                        break;

                    case "4":
                        playing = false;
                        break;
                }
               
            }
            while (playing);
        }
    }

}
            

