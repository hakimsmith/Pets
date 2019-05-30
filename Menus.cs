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
            do
            {
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Main Menu");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" 1: Interact\n 2: Create Pet\n 3: Pet Info & Status\n 4: Adopt a Pet(Remove)\n 5: Exit");
                Console.ForegroundColor = ConsoleColor.White;
                menuChoice = Console.ReadLine();
                switch (menuChoice)
                {
                    case "1":
                        string subInteractMenu = "";
                        Console.WriteLine("1: Interact with Robotic Pet\n2: Interact with Organic Pet");
                        subInteractMenu = Console.ReadLine();
                        switch (subInteractMenu)
                        {
                            case "1":
                                string subRoboticInteractMenu = "";
                                Console.WriteLine("1: Interact with all Robotic Pets\n2: Interact with one Robot");
                                subRoboticInteractMenu = Console.ReadLine();
                                // (subRoboticInteractMenu == "1") ? shelter.RoboticInteract(); : (

                                switch (subRoboticInteractMenu)
                                {
                                    case "1":
                                        shelter.ShelterRoboticInteract();
                                        break;
                                    case "2":
                                        shelter.PetRoboticSelect();
                                        break;
                                }
                                break;
                            case "2":
                                string subOrganicInteractMenu = "";
                                Console.WriteLine("1: Interact with all Organic Pets\n2: Interact with one Organic Pets");
                                subOrganicInteractMenu = Console.ReadLine();
                                switch (subOrganicInteractMenu)
                                {
                                    case "1":
                                        shelter.ShelterOrganicInteract();
                                        break;
                                    case "2":
                                        shelter.PetOrganicSelect();
                                        break;
                                }
                                break;
                        }
                        break;

                    case "2":
                        Console.WriteLine("\nWhich type of pet would you like to create?\n");
                        Console.WriteLine("1: Create Organic Pet\n2: Create Robotic Pet ");
                        string AddPetMenu = "";
                        AddPetMenu = Console.ReadLine();
                        switch (AddPetMenu)
                        {
                            case "1":
                                shelter.AddOrganicToShelter();
                                break;
                            case "2":
                                shelter.AddRoboticToShelter();
                                break;
                        }
                       
                        break;

                    case "3":

                        shelter.ShelterOrganicInfo();
                        shelter.ShelterRoboticInfo();
                        break;

                    case "4":
                        string petAdoptChoice = "";
                        Console.WriteLine("1: Adopt a Robot\n2: Adopt an Organic Pet");
                        petAdoptChoice = Console.ReadLine();
                        switch (petAdoptChoice)
                        {
                            case "1":
                                shelter.PetRoboticAdopt();
                                break;

                            case "2":
                                shelter.PetOrganicSelect();
                                break;
                        }
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
            

