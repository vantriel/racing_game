using System;
using System.IO;
// ReSharper disable IdentifierTypo

namespace racing_game
{
    public class CUi
    {
        public void InitializeConsole()
        {
            Console.Clear();
            Console.Title = "racing_game";
            Console.CursorVisible = false;
            Console.SetWindowSize(70,30);
        }
        public char TitleScreen()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            var titleart = File.ReadAllText(@"Strings\titleart.txt");
            Console.WriteLine(titleart);
            Console.WriteLine("\nPress any key to continue...");
            char input = Console.ReadKey().KeyChar;
            return input;
        }
        
        public char MainMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            var mainmenu = File.ReadAllText(@"Strings\mainmenu.txt");  
            Console.WriteLine(mainmenu);
            char input = Console.ReadKey().KeyChar;
            return input;
        }

        public char GarageMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            var garagemenu = File.ReadAllText(@"Strings\garagemenu.txt");
            Console.WriteLine(garagemenu);
            char input = Console.ReadKey().KeyChar;
            return input;
        }
    }
}