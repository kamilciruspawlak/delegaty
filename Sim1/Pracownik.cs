using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sim1
{
    class Pracownik
    {
        private Symulacja symulacja;

        public Pracownik(Symulacja symulacja)
        {
            this.symulacja = symulacja;
           // symulacja.lista_osob += Print;
        }

        public void Print(string msg)
        {
            Console.WriteLine("Pracownik: " + msg);
        }
    }
}
