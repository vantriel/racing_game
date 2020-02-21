using System.Reflection;

namespace racing_game
{
    public class CCar
    {
        //fields
        private double _acceleration;
        private int _vMax;
        private string _name;
        private string _brand;
        private double _delay;
        private int _power;
        private double _zth;
        //constructor
        public CCar() {}
        
        public CCar(double acceleration, int vMax, string name, string brand, double delay, int power, double zth)
        {
            this._acceleration = acceleration;
            this._vMax = vMax;
            this._name = name;
            this._brand = brand;
            this._delay = delay;
            this._power = power;
            this._zth = zth;
        }
        //properties
        public double Acceleration //Acceleration of car
        {
            get => _acceleration;
            set => _acceleration = value; 
        }
        public int VMax //VMax
        {
            get => _vMax;
            set => _vMax = value;
        }
        public string Name //Name of car
        {
            get => _name;
            set => _name = value;
        }
        public string Brand //Brand of car
        {
            get => _brand;
            set => _brand = value;
        }
        public double Delay //Delay
        {
            get => _delay;
            set => _delay = value;
        }
        public int Power //Power
        {
            get => _power;
            set => _power = value;
        }
        public double Zth //Zero to Hundred
        {
            get => _zth;
            set => _zth = value;
        }
    }

    //methods

    //events
}