using System;
using System.Collections.Generic;
using System.Text;

namespace SzallodaApp
{
    internal class Lakosztaly : Szoba
    {
        public int ExtraSzolgaltatasAr { get; set; }
        

        public Lakosztaly(int extraszolgaltatasar) : base(Szobaszam, alapar)
        {
            ExtraSzolgaltatasAr = extraszolgaltatasar;
        }

        public override int ArKiszamitas(int ejszakakSzama)
        {
            return base.ArKiszamitas( alapar + ExtraSzolgaltatasAr);
        }

        public override string ToString()
        {
            return base.ToString($"Extra szolgáltatás: {ExtraSzolgaltatasAr} Ft");
        }

    }
}
