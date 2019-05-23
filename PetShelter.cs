using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetTeam
{
    class PetShelter
    {
        List<Cat> petList = new List<Cat>();
        public void AddPetToShelter()
        {
            Cat newCat = new Cat("no name", "no species");
            newCat.AddPet();
            petList.Add(newCat);
        }
        public void ShelterInfo()
        {
            foreach (Cat newCat in petList)
            {
                Console.WriteLine(" Name: " + newCat.Name + " Species: " + newCat.Species + " Hunger: " + newCat.Hunger + " Boredom: " + newCat.Boredom + " Health: " + newCat.Health);
            }

        }
        public void ShelterInteract()
        {
            bool interacting = true;
            string interact = "";
            do
            {
                Console.WriteLine("You are interacting with your pet. Press any key to continue.");
                Console.ReadLine();
                Console.WriteLine(" 1 = Feed:\n 2 = Play:\n 3 = Take your pet to the Vet:\n 4 = Quit Interacting");
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
    }
        
}
