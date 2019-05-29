using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetTeam
{
    class PetShelter
    {
        Pet pet = new Pet("no name", "no species");
        List<Pet> petList = new List<Pet>();

        public void AddPetToShelter()
        {
            Pet pet = new Pet("no name", "no species");
            pet.AddPet();
            petList.Add(pet);
        }

        public void ShelterInfo()
        {
            int petNumber = 1;
            foreach (Pet pet in petList)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(petNumber + ": Name: " + pet.Name + " Species: " + pet.Species + " Hunger: " + pet.Hunger + " Boredom: " + pet.Boredom + " Health: " + pet.Health);
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
        

