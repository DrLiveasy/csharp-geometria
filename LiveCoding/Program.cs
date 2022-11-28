// See https://aka.ms/new-console-template for more information


using LiveCoding;
using LiveCoding.BonusGeometria;

Console.WriteLine("Hello, World!");

Console.WriteLine("Inserisci L'altezza dell Rettangolo");
int altezzaRettangolo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inserisci La Base del Rettangolo");
int baseRettangolo = Convert.ToInt32(Console.ReadLine());

Rettangolo InputUtente = new Rettangolo(altezzaRettangolo, baseRettangolo);

InputUtente.StampaTuttiIDati();

