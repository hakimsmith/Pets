using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetTeam
{
    class PetShelter
    {
        OrganicPet OrganicPet = new OrganicPet("no name", "no species");
        List<OrganicPet> OrganicPetsList = new List<OrganicPet>();
        RoboticPet RoboticPet = new RoboticPet("no name", "no species");
        List<RoboticPet> RoboticPetsList = new List<RoboticPet>();

        public void AddOrganicToShelter()
        {
            OrganicPet OrganicPet = new OrganicPet("no name", "no species");
            OrganicPet.AddPet();
            OrganicPetsList.Add(OrganicPet);
        }

        public void AddRoboticToShelter()
        {
            RoboticPet RoboticPet = new RoboticPet("no name", "no species");
            RoboticPet.AddPet();
            RoboticPetsList.Add(RoboticPet);
        }

        public void ShelterOrganicInfo()
        {
            int petNumber = 1;
            foreach (OrganicPet organicPet in OrganicPetsList)
            {
                Console.WriteLine("\nOrganic:");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(petNumber + ": Name: " + organicPet.Name + " Species: " + organicPet.Species + " Hunger: " + organicPet.Hunger + " Boredom: " + organicPet.Boredom + " Health: " + organicPet.Health);
                petNumber++;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void ShelterRoboticInfo()
        {
            int petNumber = 1;
            foreach (RoboticPet roboticPet in RoboticPetsList)
            {
                Console.WriteLine("\nRobots:");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"{petNumber}: Name: {roboticPet.Name} Species: {roboticPet.Species} Boredom: {roboticPet.Boredom} Oil: {roboticPet.Oil} Maintenance: {roboticPet.Maitenance}.");
                petNumber++;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void ShelterRoboticInteract()
        {
            bool interacting = true;
            string interact = "";
            do
            {
                Console.WriteLine("You are interacting with all of your robotic pets. Press any key to continue.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Interact all Menu");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" 1 : Oil all Robots:\n 2 : Play with all Robots:\n 3 : Perform maintenance on all Robots:\n 4 : Quit Interacting with all Robots");
                Console.ForegroundColor = ConsoleColor.White;
                interact = Console.ReadLine();
                switch (interact)
                {
                    case "1":
                        foreach (RoboticPet roboticPet in RoboticPetsList)
                        {
                            roboticPet.GetOil();
                        }
                        break;
                    case "2":
                        foreach (RoboticPet roboticPet in RoboticPetsList)
                        {
                            roboticPet.Play();
                        }
                        break;
                    case "3":
                        foreach (RoboticPet roboticPet in RoboticPetsList)
                        {
                            roboticPet.GetMaitenance();
                        }
                        break;
                    case "4":
                        {
                            interacting = false;
                        }
                        while (interacting) ;
                        break;
                }
            }

            while (interacting);
        }

        public void ShelterOrganicInteract()
        {
            bool interacting = true;
            string interact = "";
            do
            {
                Console.WriteLine("You are interacting with all of your organic pets. Press any key to continue.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Interact all Menu");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" 1 = Feed all pets:\n 2 = Play with all Pets:\n 3 = Take your pets to the Vet:\n 4 = Quit Interacting with all pets");

                Console.ForegroundColor = ConsoleColor.White;
                interact = Console.ReadLine();
                switch (interact)
                {
                    case "1":
                        foreach (OrganicPet organicPet in OrganicPetsList)
                        {
                            organicPet.Feed();
                        }
                        break;
                    case "2":
                        foreach (OrganicPet organicPet in OrganicPetsList)
                        {
                            organicPet.Play();
                        }
                        break;
                    case "3":
                        foreach (OrganicPet organicPet in OrganicPetsList)
                        {
                            organicPet.GoToDoctor();
                        }
                        break;
                    case "4":
                        {
                            interacting = false;
                        }
                        while (interacting) ;
                        break;
                }
            }
            while (interacting);
        }

        public void PetRoboticSelect()
        {
            Console.WriteLine("Enter the number of the pet you want to interact with.");
            ShelterRoboticInfo();
            int petListSelect = Convert.ToInt32(Console.ReadLine());
            RoboticPetsList[petListSelect - 1].InteractRobotic();
        }

        public void PetOrganicSelect()
        {
            Console.WriteLine("Enter the number of the robot you want interact with.");
            ShelterOrganicInfo();
            int petListSelect = Convert.ToInt32(Console.ReadLine());
            OrganicPetsList[petListSelect - 1].InteractOrganic();
        }

        public void PetOrganicAdopt()
        {
            Console.WriteLine("Enter the number of the organic pet you want adopt.");
            ShelterOrganicInfo();
            int petListSelect = Convert.ToInt32(Console.ReadLine());
            OrganicPetsList.RemoveAt(petListSelect - 1);
        }

        public void PetRoboticAdopt()
        {
            Console.WriteLine("Enter the number of the robotic pet you want adopt.");
            ShelterRoboticInfo();
            int petListSelect = Convert.ToInt32(Console.ReadLine());
            RoboticPetsList.RemoveAt(petListSelect - 1);
        }
        public void GetTick()
        {
            foreach (RoboticPet roboticPet in RoboticPetsList) 
            {
                roboticPet.Oil -= 1;
                roboticPet.Boredom -= 1;
                roboticPet.Maitenance -= 1;
            }
            foreach (OrganicPet organicPet in OrganicPetsList)
            {
                organicPet.Boredom -= 1;
                organicPet.Health -= 1;
                organicPet.Hunger -= 1;
            }
        }
        
    }
}
        

