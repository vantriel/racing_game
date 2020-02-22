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
        private CAudio _audio = new CAudio();
        public void Start()
        {
            //Initialize console windows
            _ui.InitializeConsole();
            _audio.PlayLoop();
            //render titlescreen
            _ui.TitleScreen();
            _audio.Stop();
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
            if (garage.Inv[0].Equals(null))
            {
                Console.WriteLine("Please create a garage first!");
            }
            else
            {
                Console.Beep();
                if(garage.Inv[0].Zth >= garage.Inv[1].Zth)
                { 
                    _ui.WinnerScreen(garage.Inv[1]);
                }
                if (garage.Inv[0].Zth <= garage.Inv[1].Zth)
                { 
                    _ui.WinnerScreen(garage.Inv[0]);              
                }

                if (garage.Inv[0].Zth.Equals(garage.Inv[1].Zth))
                {
                    Console.WriteLine("Nobody won! :(");   
                }
            }
        }

        private CGarage Garage(CGarage garage)
        {
            var tmpExitV = 0;
            CGarage tmpGarage = garage;
            do
            {
                char input = _ui.GarageMenu();
                switch (input)
                {
                    case '1':
                        _ui.CreateGarage(tmpGarage);
                        break;
                    case '2':
                        _ui.ViewGarage(tmpGarage);
                        break;
                    case '3':
                        tmpExitV = 1;
                        break;
                    default:
                        break;
                }
            } while (tmpExitV.Equals(0));

            return tmpGarage;
        }
    }
}