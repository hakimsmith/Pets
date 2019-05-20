using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetTeam
{
    class Cat
    {

        public string Name { get; set; }
        public string Species { get; set; }
        


        public Cat(string name, string species)
        {
            Name = name;
            Species = species;


        }

        public void Greet()
        {
            Console.WriteLine("I'm" + Name + "My species is" + Species );
        }
    }
}