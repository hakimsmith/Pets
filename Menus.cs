using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetTeam
{
    class Menus
    {
        public void Mainmenu()
        {
            string menuChoice = "";
            bool playing = true;
            Cat newCat = new Cat("no name", "no species");
            do
            {
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
                Console.WriteLine(" 1 = Interact: \n 2 = Add Pet:\n 3 = Pet Info:\n 4 = Pet Status:\n 5 = Exit:");
                menuChoice = Console.ReadLine();
                switch (menuChoice)
                {
                    case "1":
                        newCat.Interact();
                        break;

                    case "2":
                        newCat.AddPet();
                        break;

                    case "3":
                        newCat.PetInfo();
                        break;

                    case "4":
                        newCat.PetStatus();
                        break;

                    case "5":
                        playing = false;
                        break;
                }
            }
            while (playing);
        }
    }

}
            

