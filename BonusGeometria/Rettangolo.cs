using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusGeometria
{
    public class Rettangolo
    {
        public int baseRettangolo;
        public int altezzaRettangolo;



        public void calcolaArea()
        {
            int area = baseRettangolo * altezzaRettangolo;
            Console.WriteLine($"l'Area dell rettangolo e di: {area}");
        }
        public void calcolaPerimetro()
        {
            int perimetro = (baseRettangolo + altezzaRettangolo) * 2;
            Console.WriteLine($"il Perimetro dell Rettangolo è di: {perimetro}");

        }

        public void StampaTuttiIDati()
        {
            int area = baseRettangolo * altezzaRettangolo;
            int perimetro = (baseRettangolo + altezzaRettangolo) * 2;
            Console.WriteLine($"Base: {baseRettangolo}");
            Console.WriteLine($"Altezza: {altezzaRettangolo}");
            Console.WriteLine($"Perimetro: {perimetro}");
            Console.WriteLine($"Area: {area}");
        }
        public void StampaDisegno()
        {
            Console.Write("\"");
            for (int i = 0; i<baseRettangolo-2;i++)
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
