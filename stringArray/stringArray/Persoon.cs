namespace stringArray
{
    class Persoon
    {   
        //Fields
        private string _naam;

        //Properties
        public string Naam { get { return _naam; } }
        

        //Constructor
        public Persoon(string naam)
        {
            _naam = naam;
        }

    }
}
