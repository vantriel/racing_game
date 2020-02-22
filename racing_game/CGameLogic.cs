// ReSharper disable UseStringInterpolation
// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo
// ReSharper disable SpecifyACultureInStringConversionExplicitly
// ReSharper disable HeapView.ObjectAllocation.Evident


using System;

namespace racing_game
{
    
    public class CGameLogic
    {
        //create userinterface and hidden devutils class
        private readonly CUi _ui = new CUi();
        private readonly CDevUtils _dev = new CDevUtils();
        public void Start()
        {
            //Initialize console windows
            _ui.InitializeConsole();
            //render titlescreen
            _ui.TitleScreen();
            var exitV = 0;
            var garage = new CGarage();
            do
            {
                char input = _ui.MainMenu();
                switch (input)
                {
                    case '1':
                        this.Race(garage);
                        break;
                    case '2':
                        garage = this.Garage(garage);
                        break;
                    case 'd':
                        garage = _dev.utils(garage);
                        break;
                    case '3':
                        exitV = 1;
                        break;
                }
            } while (exitV.Equals(0));

        }

        private void Race(CGarage garage)
        {
            
        }

        private CGarage Garage(CGarage garage)
        {
            CGarage tmpGarage = garage;
            char input = _ui.GarageMenu();
            return tmpGarage;
        }
    }
}