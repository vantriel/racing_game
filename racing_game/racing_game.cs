using System;
using System.Globalization;
using System.Text;

// ReSharper disable UseStringInterpolation
// ReSharper disable IdentifierTypo
// ReSharper disable SpecifyACultureInStringConversionExplicitly
// ReSharper disable HeapView.ObjectAllocation.Evident

namespace racing_game
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //create menusystem class
            var menu = new CMenu();
            //render titlescreen
            menu.TitleScreen();
            //creation of car objects
            var car0 = new CCar();
            var car1 = new CCar();
            //menu system
            Console.WriteLine("Car 1\nName of car:");
            car0.Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Zero to hundred time:");
            car0.Zth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Car 2\nName of car:");
            car1.Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Zero to hundred time:");
            car1.Zth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Summary\nCar 1:\nName: {0}\nZero to hundred time: {1}\nCar 2:\nName: {2}\nZero to hundred time: {3}\n\n", car0.Name, Convert.ToString(car0.Zth), car1.Name, Convert.ToString(car1.Zth));
        }
    }
}