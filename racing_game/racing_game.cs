using System;
using System.ComponentModel;
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
            var game = new CGameLogic();
            game.Start();
        }
    }
}