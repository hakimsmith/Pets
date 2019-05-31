using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetTeam
{
    public class OrganicPet : Pet
    {
        public int Health { get; set; }
        public int Hunger { get; set; }

        public OrganicPet(string name, string species) : base(name, species)
        {
            Health = 10;
            Hunger = 10;
        }

        public void Feed()
        {
            Hunger += 2;
            Console.WriteLine("You have fed " + Name);
        }

        public void GoToDoctor()
        {
            Health += 1;
            Console.WriteLine("You have took " + Name + " to the vet!");
        }

        public void InteractOrganic()
        {
            bool interacting = true;
            string interact = "";
            do
            {
                Console.WriteLine("You are interacting with " + Name + ". Press any key to continue.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Interact Menu");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(" 1: Feed\n 2: Play\n 3: Take your pet to the Vet\n 4: Quit Interacting");
                Console.ForegroundColor = ConsoleColor.White;
                interact = Console.ReadLine();
                switch (interact)
                {
                    case "1":
                        Feed();
                        break;
                    case "2":
                        Play();
                        break;
                    case "3":
                        GoToDoctor();
                        break;
                    case "4":

                        interacting = false;
                        break;
                }
            }
            while (interacting);
        }

    }
}
