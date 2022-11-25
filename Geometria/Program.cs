// See https://aka.ms/new-console-template for more information


using Geometria;
Rettangolo InputUtente = new Rettangolo();
Rettangolo PrimoRettangolo = new Rettangolo();
Rettangolo SecondoRettangolo = new Rettangolo();
Rettangolo TerzoRettangolo = new Rettangolo();
Rettangolo QuartodoRettangolo = new Rettangolo();
Rettangolo QuintoRettangolo = new Rettangolo();
Rettangolo SestoRettangolo = new Rettangolo();




Console.WriteLine("Inserisci L'altezza dell Rettangolo");
InputUtente.altezzaRettangolo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inserisci il Perimetro dell Rettangolo");
InputUtente.baseRettangolo = Convert.ToInt32(Console.ReadLine());

InputUtente.calcolaArea();
InputUtente.calcolaPerimetro();

