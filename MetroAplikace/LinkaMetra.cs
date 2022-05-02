using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroAplikace
{
    internal class LinkaMetra
    {
        private List<string> _nazvyStanic;

        public LinkaMetra(List<string> _vkladaneStanice)
        {
            _nazvyStanic = _vkladaneStanice; //do listu na 11. řádku načteme list, předaný v parametru 
        }
        public void VypisStanice()
        {
            foreach(string stanice in _nazvyStanic) //projede všechny stanice v Listu _nazvyStanic
            {
                Console.WriteLine(stanice); //vypisuje současnou stanici v cyklu
            }
        }
        public void PrvniPosledniStanice()
        {
            string prvniStanice = _nazvyStanic[0];
            string posledniStanice = _nazvyStanic[_nazvyStanic.Count - 1];
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------");
            Console.WriteLine($"První stanice: {prvniStanice}  -  Poslední stanice: {posledniStanice}");
            Console.WriteLine("----------------");
            Console.ResetColor();
            //dolar = alt gr + ů

        }
        public int ZjistiCas(string odjezdStanice, string prijezdStanice)
        {
            int cas = 0;
            if(_nazvyStanic.Contains(prijezdStanice) && _nazvyStanic.Contains(odjezdStanice))
            {
                int indexOdjezd = _nazvyStanic.IndexOf(odjezdStanice);
                int indexPrijezd = _nazvyStanic.IndexOf(prijezdStanice);
                int rozdil = indexOdjezd - indexPrijezd;
                cas = rozdil * 2;
            }
            else
            {
                Console.WriteLine("Chyba - stanice nenalezeny");
            }

            return Math.Abs(cas); //absolutní hodnota (z -5 udělá číslo 5. Z čísla 5 udělá zase 5)
        }

    }
}
