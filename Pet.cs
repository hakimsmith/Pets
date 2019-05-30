using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetTeam
{
    class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }     
        public int Boredom { get; set; }     

        public Pet(string name, string species)
        {
            Name = name;
            Species = species;           
            Boredom = 10;            
        }

        public void Play()
        {
            Boredom += 3;   
            Console.WriteLine("You have played with " + Name);
        }

        public void AddPet()
        {
            Console.WriteLine("What would you like to name your pet?");
            Name = Console.ReadLine();
            Console.WriteLine("What would you like its species to be?");
            Species = Console.ReadLine();
        }
    }
}