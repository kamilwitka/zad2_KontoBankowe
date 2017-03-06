using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            KontoBankowe konto = new KontoBankowe("Kamil", "Witka", 123456, 0, 1);
            
            konto.zmienFunduszeKonta(1000);
            konto.usunKonto();

            Console.ReadLine();
        }
    }
}
