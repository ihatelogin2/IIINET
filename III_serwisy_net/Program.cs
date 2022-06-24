using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III_serwisy_net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var klient = new DHL.DHL24WebapiPortClient();
            String wynik = klient.getVersion();
            Console.WriteLine(wynik);
            Console.ReadLine();
        }
    }
}
