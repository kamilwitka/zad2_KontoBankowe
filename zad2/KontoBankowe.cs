using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class KontoBankowe
    {
        string imie;
        string nazwisko;
        int numerKonta;
        int fundusze;
        int id;

        public KontoBankowe(string imie, string nazwisko, int numerKonta, int fundusze, int id)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.numerKonta = numerKonta;
            this.fundusze = fundusze;
            this.id = id;
        }

        public void wplacPieniadze(int fundusze)
        {
            Console.WriteLine("Na konto wpłacono " + fundusze + " zł");
        }
        public void zmienFunduszeKonta(int fundusze)
        {
            wplacPieniadze(fundusze);
            Console.WriteLine("Podaj wartość odsetek: ");
            double odsetki = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zmieniono fundusze konta dzięki odsetkom. Po operacji fundusze to: " + fundusze * odsetki + " zł");
        }
        public bool usunKonto()
        {
            Console.WriteLine("Czy usunąć konto? y/n ");
            string czyUsunac = Console.ReadLine();

            if (czyUsunac == "y")
            {
                Console.WriteLine("Konto zostało usunięte");
            }
            return false;

        }

    }
}
