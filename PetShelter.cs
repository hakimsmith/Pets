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
                Console.ForegroundColor = ConsoleColor.DarkRed;
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
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{petNumber}: Name: {roboticPet.Name} Species: {roboticPet.Species} Boredom: {roboticPet.Boredom} Oil: {roboticPet.Oil} Maitenance: {roboticPet.Maitenance}.");
                petNumber++;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void ShelterInteract()
        {
            bool interacting = true;
            string interact = "";
            do
            {
               
                Console.WriteLine("You are interacting with all of your pets. Press any key to continue.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Interact all Menu");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(" 1 = Feed all pets:\n 2 = Play with all Pets:\n 3 = Take your pets to the Vet:\n 4 = Quit Interacting with all pets");
                Console.ForegroundColor = ConsoleColor.White;
                interact = Console.ReadLine();
                switch (interact)
                {
                    case "1":
                        foreach (Pet pet in petList)
                        {
                            pet.Feed();
                        }
                        break;
                    case "2":
                        foreach (Pet pet in petList)
                        {
                            pet.Play();
                        }
                        break;
                    case "3":
                        foreach (Pet pet in petList)
                        {
                            pet.GoToDoctor();
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
        
        public void PetSelect()
        {
            Console.WriteLine("Enter the number of the pet you want to interact with.");
            ShelterInfo();
            int petListSelect = Convert.ToInt32(Console.ReadLine());
            petList[petListSelect - 1].Interact();
        }
    }
}
        

