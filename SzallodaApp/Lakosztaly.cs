using System;
using System.Collections.Generic;
using System.Text;

namespace SzallodaApp
{
    public class Lakosztaly : Szoba
    {
        public int ExtraSzolgaltatasAr { get; set; }
        
        public Lakosztaly(int extraszolgaltatasar, int szobaszam, int alapar) : base(szobaszam, alapar)
        {
            ExtraSzolgaltatasAr = extraszolgaltatasar;
        }

        public override int ArKiszamitas(int ejszakakSzama)
        {
            //return Alapar * ejszakakSzama + ExtraSzolgaltatasAr;
            return base.ArKiszamitas(ejszakakSzama)+ ExtraSzolgaltatasAr;
        }

        public override string ToString()
        {
            return $"{base.ToString()} | $Extra szolgáltatás: {ExtraSzolgaltatasAr} Ft";
        }

    }
}
