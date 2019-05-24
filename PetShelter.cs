﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetTeam
{
    class PetShelter
    {
        Cat newCat = new Cat("no name", "no species");
        List<Cat> petList = new List<Cat>();

        public void AddPetToShelter()
        {
            Cat newCat = new Cat("no name", "no species");
            newCat.AddPet();
            petList.Add(newCat);
        }

        public void ShelterInfo()
        {
            int petNumber = 1;
            foreach (Cat newCat in petList)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(petNumber + ": Name: " + newCat.Name + " Species: " + newCat.Species + " Hunger: " + newCat.Hunger + " Boredom: " + newCat.Boredom + " Health: " + newCat.Health);
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
                        foreach (Cat newCat in petList)
                        {
                            newCat.Feed();
                        }
                        break;
                    case "2":
                        foreach (Cat newCat in petList)
                        {
                            newCat.Play();
                        }
                        break;
                    case "3":
                        foreach (Cat newCat in petList)
                        {
                            newCat.GoToDoctor();
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
        

