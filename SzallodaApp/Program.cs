using SzallodaApp;

Szoba normalszoba = new Szoba(szobaszam : 101, alapar : 20000);
Szoba normalszoba2 = new Szoba(szobaszam : 101, alapar : -5000);
Lakosztaly lakosztaly = new Lakosztaly(extraszolgaltatasar : 15000, szobaszam : 501, alapar : 40000 );

Console.WriteLine(normalszoba);
Console.WriteLine(normalszoba2);
Console.WriteLine(lakosztaly);

Console.WriteLine($"\n 101-es szoba ára 3 éjszaka {normalszoba.ArKiszamitas(3)} Ft");
Console.WriteLine($"\n 101-es szoba ára 3 éjszaka {lakosztaly.ArKiszamitas(3)} Ft");
