using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kviz
{
    public class Pitanje
    {
        public string Tekst { get; set; }

        public List<string> Odgovori { get; set; }

        public int TacanOdgIndex { get; set; }

        public Pitanje(string tekstPitanja, List<string> odgovori, int tacanOdgIndex)
        {
            Tekst = tekstPitanja;
            Odgovori = odgovori;
            TacanOdgIndex = tacanOdgIndex;

        }

        public void PrikaziPitanje()
        {
            Console.WriteLine(Tekst);


            foreach (var opcija in Odgovori)
            {
                Console.WriteLine(opcija);
            }
        }
    }
 }
