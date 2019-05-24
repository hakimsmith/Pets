using System;

namespace VirtualPetTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Menus mainMenu = new Menus();
            Console.WriteLine("Welcome to the Pet Shelter.");
            mainMenu.GetMainMenu();
            Console.WriteLine("Thanks for playing!");
        } 
    }
}
