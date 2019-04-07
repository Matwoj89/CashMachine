using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bank.Interfejsy;

namespace Bankomat.Klasy
{
    public class Bankomat: IBank
    {
        private Bank.Klasy.Bank BankKlienta;

        public Bankomat()
        {
            this.BankKlienta = new Bank.Klasy.Bank("PKO BP","Oddzial I/Warszawa");
        }

        public Bank.Klasy.Klient Autoryzacja(int pin, int nrKarty)
        {
            return this.BankKlienta.Autoryzacja(pin, nrKarty);
        }

        public decimal StanKonta(Bank.Klasy.Klient klient)
        {
            return this.BankKlienta.StanKonta(klient);
        }

        public void Wyplata(Bank.Klasy.Klient klient, decimal kwota)
        {
            this.BankKlienta.Wyplata(klient, kwota);
        }

        public void Wplata(Bank.Klasy.Klient klient, decimal kwota)
        {
            this.BankKlienta.Wplata(klient, kwota);
        }

        public void Wyloguj(Bank.Klasy.Klient klient)
        {
            this.BankKlienta.Wyloguj(klient);
        }
    }
}
