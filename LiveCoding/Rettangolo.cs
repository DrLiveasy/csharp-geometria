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
            public int baseRettangolo;
            public int altezzaRettangolo;

            // Posso definire un altro COSTRUTTORE customizzato usando ancora l'OVERLOAD
            public Rettangolo(int altezzaRettangolo, int baseRettangolo)
            {
                this.baseRettangolo = baseRettangolo;
                this.altezzaRettangolo = altezzaRettangolo;
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
