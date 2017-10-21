using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperatura
{
    public class Boss
    {
        private ServerTemperatureWatcher serverTemperatureWatcher;

        public Boss(ServerTemperatureWatcher serverTemperatureWatcher)
        {
            this.serverTemperatureWatcher = serverTemperatureWatcher;
            serverTemperatureWatcher.lista_osob += Print;
        }

        public void Print(string msg)
        {
            Console.WriteLine("Szef: " + msg);
        }
    }
}
