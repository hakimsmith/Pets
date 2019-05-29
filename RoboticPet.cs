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
            Console.WriteLine($"You have performed maitenance on {Name}.");
        }

    }
}
