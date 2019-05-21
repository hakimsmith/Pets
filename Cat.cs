using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetTeam
{
    class Cat
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }

        public Cat(string name, string species, int hunger, int boredom, int health)
        {
            Name = name;
            Species = species;
            Hunger = hunger;
            Boredom = boredom;
            Health = health;
        }

        public void Greet()
        {
            Console.WriteLine("I'm " + Name + "! My species is " + Species + ".");
        }

        public void Status()
        {
            Console.WriteLine(Name + "'s status is :");
            Console.WriteLine("Hunger: " + Hunger + "/20");
            Console.WriteLine("Bordeom: " + Boredom + "/20");
            Console.WriteLine("Health: " + Health + "/20");
        }

        public void Feed()
        {
            Hunger = (Hunger + 2);
        }

        public void Play()
        {
            Boredom = (Boredom + 3);
            Hunger = (Hunger - 1);
            Health = (Health - 1);
        }

        public void Doctor()
        {
            Health = (Health + 2);
        }

        public void Interact()
        {
            bool interacting = true;
            string interact = "";
            do
            {
                Console.WriteLine("1 = Feed: 2 = Play: 3 = Take your pet to the Vet: 4 = Quit Interacting");
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
                        Doctor();
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

        public void Addpet()
        {
            Console.WriteLine("What would you like to name your pet?");
            Name = Console.ReadLine();
            Console.WriteLine("What would you like its species?");
            Species = Console.ReadLine();
        }
    }
}