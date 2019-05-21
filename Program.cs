using System;

namespace VirtualPetTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat newCat = new Cat("no name", "no species", 10, 10, 10);
            string menuChoice = "";
            bool playing = true;
            do
            {
                Console.WriteLine("1 = Interact: 2 = Add Pet: 3 = Pet Info: 4 = Exit: 5 = Pet Status:");
                menuChoice = Console.ReadLine();
                switch (menuChoice)
                { 
                    case "1":
                        newCat.Interact();  
                        break;

                    case "2":
                        newCat.Addpet();
                        break;
                       
                    case "3":
                        newCat.Greet(); 
                        break;

                    case "4":
                        Environment.Exit(0);
                        break;

                    case "5":
                        newCat.Status();  
                        break;
                }
            }
            while (playing);
        } 
    }
}
