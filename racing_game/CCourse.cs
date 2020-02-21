namespace racing_game
{
    public class CCourse
    {
        //fields
        private string _name;
        private string _location;
        private double _length;
        //constructor
        public CCourse() {}

        public CCourse(string name, string location, double length)
        {
            this._name = name;
            this._location = location;
            this._length = length;
        }
        //propeties
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string Location
        {
            get => _location;
            set => _location = value;
        }
        public double Length
        {
            get => _length;
            set => _length = value;
        }
        //methods

        //events
    }
}