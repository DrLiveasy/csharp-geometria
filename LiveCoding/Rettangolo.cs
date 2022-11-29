using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCoding
{
    namespace BonusGeometria
    {
        public class Rettangolo
        {
            private int baseRettangolo;
            private int altezzaRettangolo;
            public string Colore;

            // Posso definire un altro COSTRUTTORE customizzato usando ancora l'OVERLOAD
            public Rettangolo(int altezzaRettangolo, int baseRettangolo, string colore)
            {
                this.baseRettangolo = baseRettangolo;
                this.altezzaRettangolo = altezzaRettangolo;
                this.Colore = colore;
            }



            public int calcolaArea()
            {
                int area = baseRettangolo * altezzaRettangolo;
                return area;
            }
            public int calcolaPerimetro()
            {
                int perimetro = (baseRettangolo + altezzaRettangolo) * 2;
                return perimetro;
            }

            public void StampaTuttiIDati()
            {
                int area = baseRettangolo * altezzaRettangolo;
                int perimetro = (baseRettangolo + altezzaRettangolo) * 2;
                Console.WriteLine($"Base: {baseRettangolo}");
                Console.WriteLine($"Altezza: {altezzaRettangolo}");
                Console.WriteLine($"Perimetro: {calcolaPerimetro()}");
                Console.WriteLine($"Area: {calcolaArea()}");
                Console.WriteLine($"colore rettangolo: {Colore}");
            }







            public void StampaDisegno()
            {
                Console.Write("\"");
                for (int i = 0; i < baseRettangolo - 2; i++)
                {
                    Console.Write("\"");
                }
                Console.WriteLine("\"");

                for (int i = 0; i < altezzaRettangolo; i++)
                {
                    Console.Write("|");
                    for (int b = 0; b < baseRettangolo - 2; b++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("|");
                }
                Console.Write("\"");
                for (int i = 0; i < baseRettangolo - 2; i++)
                {
                    Console.Write("\"");
                }
                Console.WriteLine("\"");
            }
           



        }

    }

}
