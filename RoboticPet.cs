using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetTeam
{
    internal class RoboticPet : Pet
    {
        public int Oil { get; set; }
        public int Maitenance { get; set; }

        public RoboticPet(string name, string species) : base(name, species)
        {
            Oil = 15;
            Maitenance = 15;
        }

        public void GetOil()
        {
            Oil += 1;
            Console.WriteLine($"You have oiled {Name}.");
        }

        public void GetMaitenance()
        {
            Maitenance += 1;
            Console.WriteLine($"You have performed maintenance on {Name}.");
        }

        public void InteractRobotic()
        {
            bool interacting = true;
            string interact = "";
            do
            {
                Console.WriteLine("You are interacting with " + Name + ". Press any key to continue.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Interact Menu");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" 1: Oil\n 2: Play\n 3: Perform Maintenance on your robot\n 4: Quit Interacting");
                Console.ForegroundColor = ConsoleColor.White;
                interact = Console.ReadLine();
                switch (interact)
                {
                    case "1":
                        GetOil();
                        break;
                    case "2":
                        Play();
                        break;
                    case "3":
                        GetMaitenance();
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
