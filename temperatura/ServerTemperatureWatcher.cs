using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperatura
{
    public class ServerTemperatureWatcher
    {
        public delegate void OnEventServerTemperaturIsEven(string msg);
        public event OnEventServerTemperaturIsEven lista_osob;

        public void testTemperatury()
        {
            Random rnd = new Random();
            int temperatura = rnd.Next(100);

            Console.WriteLine("Temperatura wynosi: " + temperatura);
        }
    }
}
