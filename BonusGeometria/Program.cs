// See https://aka.ms/new-console-template for more information


using BonusGeometria;
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


Console.WriteLine("\n\n\nECCO IL DISEGNO DEL RETTANGOLO CHE HAI INSERITO\n\n\n");
InputUtente.StampaDisegno();
//--OUTPUT DI MIEI RETTANGOLI

/*
Console.WriteLine("\n\n\n I DISEGNI DEI MIEI RETTANGOLO\n\n\n");

Console.WriteLine("--RETTANGOLO1--\n");
PrimoRettangolo.StampaDisegno();
Console.WriteLine("--RETTANGOLO2--\n");
SecondoRettangolo.StampaDisegno();
Console.WriteLine("--RETTANGOLO3--\n");
TerzoRettangolo.StampaDisegno();
Console.WriteLine("--RETTANGOLO4--\n");
QuartoRettangolo.StampaDisegno();
Console.WriteLine("--RETTANGOLO5--\n");
QuintoRettangolo.StampaDisegno();
Console.WriteLine("--RETTANGOLO6--\n");
SestoRettangolo.StampaDisegno();
*/

