using System;

namespace DemoLibrary
{
    public class Persoon
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }

        public override string ToString()
        {
            return Voornaam + " " + Achternaam;
        }
    }
}
