using System;


namespace VirtualPetTeam
{
    class Program
    {
        static void Main(string[] args)
        {        
            Menus mainMenu = new Menus();
            Console.WriteLine("                                               WELCOME TO THE PET SHELTER!\n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n");
            mainMenu.GetMainMenu();
            Console.WriteLine("Thanks for playing!");
        } 
    }
}
