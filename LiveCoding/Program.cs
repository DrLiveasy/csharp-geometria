// See https://aka.ms/new-console-template for more information




using LiveCoding.BonusGeometria;

Console.WriteLine("Hello, World!");

Console.WriteLine("Inserisci L'altezza dell Rettangolo");
int altezzaRettangolo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inserisci La Base del Rettangolo");
int baseRettangolo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inserisci il colore del Rettangolo");
string colore = (Console.ReadLine());



Rettangolo InputUtente = new Rettangolo(altezzaRettangolo, baseRettangolo, colore);

InputUtente.StampaTuttiIDati();
/*
Console.WriteLine("Inserisci un nuovo colore del Rettangolo");
string colore1 = (Console.ReadLine());

InputUtente.Colore = colore1;
InputUtente.StampaTuttiIDati();
*/

Console.WriteLine("Inserisci un nuovo colore del Rettangolo");
string colore1 = (Console.ReadLine());

InputUtente.SetColore(colore1);

Console.WriteLine("Inserisci una nuova base del Rettangolo");
int Base = Convert.ToInt32(Console.ReadLine());

InputUtente.SetBase(Base); 

Console.WriteLine("Inserisci una nuova altezza del Rettangolo");
int altezza = Convert.ToInt32(Console.ReadLine());

InputUtente.SetAltezza(altezza);


InputUtente.StampaTuttiIDati();



