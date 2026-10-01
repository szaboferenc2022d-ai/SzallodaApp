using System;
using System.Collections.Generic;
using System.Text;

namespace SzallodaApp
{
    internal class Szoba
    {
        public int Szobaszam { get; }
        protected int alapar { get; set; }
        public int Alapar
        {
            get { return alapar; }
            set
            {
                if (value < 0)
                {
                    throw new("Az alapár nem lehet negatív.");
                }
                alapar = value;
            }
        }

        public Szoba(int szobaszam, int alapar)
        {
            Szobaszam = szobaszam;
            Alapar = alapar;
        }

        
         public virtual int ArKiszamitas(int ejszakakSzama)
        {
            return ejszakakSzama* Alapar;
        }

        public override string ToString()
        {
            return $"Szoba {Szobaszam} | Alapár: {Alapar}";
        }

    }
}
