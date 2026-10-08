using System;
using System.Collections.Generic;
using System.Text;

namespace SzallodaApp
{
    public class Szoba
    {
        public int Szobaszam { get; }
        protected int alapar { get; set; }
        public int Alapar
        {
            get { return alapar; }
            set
            {
                if (value > 0) alapar = value;
            }
        }

        public Szoba(int szobaszam, int alapar)
        {
            Szobaszam = szobaszam;
            Alapar = alapar;
        }

        
         public virtual int ArKiszamitas(int ejszakakSzama)
        {
            return Alapar * ejszakakSzama;
        }

        public override string ToString()
        {
            return $"Szoba {Szobaszam} | Alapár: {Alapar} Ft/éj";
        }

    }
}
