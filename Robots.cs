using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetTeam
{
    class Robots : Cat
    {
        public int Oil { get; set; }
        public int Performance { get; set; }

        public Robots(string name, string species, int oil, int performance) : base(name, species)
        {
            Oil = 15;
            Performance = 15;
        }

        public override void AddPet()
        {
            base.AddPet();
        }

        public override void PetStatus()
        {
        }


    }
}
