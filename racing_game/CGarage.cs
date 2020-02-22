// ReSharper disable HeapView.ObjectAllocation.Evident
namespace racing_game
{
    public class CGarage
    {
        //fields
        private CCar[] _inv = new CCar[2];
        
        //constructor
        public CGarage() { }

        public CGarage(CCar[] inv)
        {
            this._inv = inv;
        }
        
        //properties
        public CCar[] Inv
        {
            get => _inv;
            set => _inv = value;
        }
    }
}