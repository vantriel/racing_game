using System;
using System.IO;
// ReSharper disable IdentifierTypo

namespace racing_game
{
    public class CMenu
    {
        public void TitleScreen()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            var titleart = File.ReadAllText(@"strings\titleart.txt");  
            Console.WriteLine(titleart);
        }
        
        public void MainMenu()
        {
            
        }
    }
}