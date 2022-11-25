// See https://aka.ms/new-console-template for more information


using Geometria;
//--RETTANGOLO UTENTE--
Rettangolo InputUtente = new Rettangolo();
//--MIEI RETTANGOLI--
Rettangolo PrimoRettangolo = new Rettangolo();
Rettangolo SecondoRettangolo = new Rettangolo();
Rettangolo TerzoRettangolo = new Rettangolo();
Rettangolo QuartoRettangolo = new Rettangolo();
Rettangolo QuintoRettangolo = new Rettangolo();
Rettangolo SestoRettangolo = new Rettangolo();

//--ATTRIBUTI DI MIEI RETTANGOLI
//1
PrimoRettangolo.altezzaRettangolo = 20;
PrimoRettangolo.baseRettangolo = 30;
//2
SecondoRettangolo.altezzaRettangolo = 16;
SecondoRettangolo.baseRettangolo = 40;
//3
TerzoRettangolo.altezzaRettangolo = 23;
TerzoRettangolo.baseRettangolo = 80;
//4
QuartoRettangolo.altezzaRettangolo = 30;
QuartoRettangolo.baseRettangolo = 40;
//5
QuintoRettangolo.altezzaRettangolo = 50;
QuintoRettangolo.baseRettangolo = 30;
//6
SestoRettangolo.altezzaRettangolo = 40;
SestoRettangolo.baseRettangolo = 18;


//--INPUT RETTANGOLO UTENTE--
Console.WriteLine("Inserisci L'altezza dell Rettangolo");
InputUtente.altezzaRettangolo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inserisci La Base del Rettangolo");
InputUtente.baseRettangolo = Convert.ToInt32(Console.ReadLine());
//--OUTPUT RETTANGOLO UTENTE--
InputUtente.calcolaArea();
InputUtente.calcolaPerimetro();
Console.WriteLine("--I DATI DEL RETTANGOLO CHE HAI INSERITO--");
InputUtente.StampaTuttiIDati();
//--OUTPUT DI MIEI RETTANGOLI
Console.WriteLine("--I MIEI RETTANGOLI--");
Console.WriteLine("--RETTANGOLO1--");
PrimoRettangolo.StampaTuttiIDati();
Console.WriteLine("--RETTANGOLO2--");
SecondoRettangolo.StampaTuttiIDati();
Console.WriteLine("--RETTANGOLO3--");
TerzoRettangolo.StampaTuttiIDati();
Console.WriteLine("--RETTANGOLO4--");
QuartoRettangolo.StampaTuttiIDati();
Console.WriteLine("--RETTANGOLO5--");
QuintoRettangolo.StampaTuttiIDati();
Console.WriteLine("--RETTANGOLO6--");
SestoRettangolo.StampaTuttiIDati();
