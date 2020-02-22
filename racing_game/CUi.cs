using System;
using System.IO;
using System.Linq;
// ReSharper disable SpecifyACultureInStringConversionExplicitly
// ReSharper disable HeapView.ObjectAllocation.Evident
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
            Console.SetWindowSize(90,30);
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
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            var garagemenu = File.ReadAllText(@"Strings\garagemenu.txt");
            Console.WriteLine(garagemenu);
            char input = Console.ReadKey().KeyChar;
            return input;
        }

        public void WinnerScreen(CCar winner)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();    
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\n");
            DrawCar();
            Console.WriteLine("\n\n{0} {1} won!\n\nPress any key to continue...", winner.Brand, winner.Name);
            Console.ReadKey();
        }
        public void DrawCar()
        {
            var car = File.ReadAllText(@"Strings\car.txt");   
            Console.WriteLine(car);
        }

        public CGarage CreateGarage(CGarage garage)
        {
            var i = 0;
            Console.WriteLine("\n\n");
            while (i <= garage.Inv.Length-1)
            {
                CCar car = new CCar();
                Console.Clear();
                string tmpI = Convert.ToString(i + 1);
                Console.WriteLine("Car {0}", tmpI);
                Console.WriteLine("\nBrand: ");
                String brand = Convert.ToString(Console.ReadLine());
                car.Brand = brand;
                Console.WriteLine("\nModel: ");
                String name = Convert.ToString(Console.ReadLine());
                car.Name = name;
                Console.WriteLine("\nZero to Hundred Kilometres-Time: ");
                Double zth = Convert.ToDouble(Console.ReadLine());
                car.Zth = zth;
                garage.Inv[i] = car;
                i++;
            }
            return garage;    
        }

        public void ViewGarage(CGarage garage)
        {
            var i = 0;
            Console.WriteLine("\n\n");
            while (i <= garage.Inv.Length-1)
            {
                string tmpI = Convert.ToString(i + 1);
                Console.WriteLine("Car {0}:\nBrand: {1}\nModel: {2}\nZero to Hundred Kilometers-Time: {3}\n\n", tmpI, garage.Inv[i].Brand, garage.Inv[i].Name, Convert.ToString(garage.Inv[i].Zth));
                i++;
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}