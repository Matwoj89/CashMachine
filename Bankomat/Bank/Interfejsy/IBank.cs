using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bank.Klasy;

namespace Bank.Interfejsy
{
    public interface IBank
    {
        Klient Autoryzacja(int pin, int nrKarty);
        decimal StanKonta(Klient klient);
        void Wyplata(Klient klient, decimal kwota);
        void Wplata(Klient klient, decimal kwota);
        void Wyloguj(Klient klient);
    }
}
