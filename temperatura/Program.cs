using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerTemperatureWatcher serverTemperatureWatcher = new ServerTemperatureWatcher();
            Admin admin = new Admin();
           // Boss boss = new Boss();

            serverTemperatureWatcher.testTemperatury();

            Console.ReadKey();
        }
    }
}
