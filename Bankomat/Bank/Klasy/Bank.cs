using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bank.Interfejsy;
using Bank.Wyjatki;

namespace Bank.Klasy
{
    public class Bank: IBank
    {
        private string _nazwaBanku;
        public string NazwaBanku
        {
            get
            {
                return this._nazwaBanku;
            }
            set
            {
                this._nazwaBanku = value;
            }
        }

        private string _nazwaOddzialu;
        public string NazwaOddzialu
        {
            get
            {
                return this._nazwaOddzialu;
            }
            set
            {
                this._nazwaOddzialu = value;
            }
        }

        private IList<Klient> _rachunkiBankowe;
        public IList<Klient> RachunkiBankowe
        {
            get
            {
                return this._rachunkiBankowe;
            }
            private set
            {
                this._rachunkiBankowe = value;
            }
        }

        public Bank(string nazwa, string oddzial)
        {
            this._nazwaBanku = nazwa;
            this._nazwaOddzialu = oddzial;
            this._rachunkiBankowe = new List<Klient>();

            this.inicjujRachunkiBankowe();
        }

        public Klient Autoryzacja(int pin, int nrKarty)
        {
            foreach (Klient k in this._rachunkiBankowe)
            {
                
                if (k.Pin == pin && k.NumerRachunku == nrKarty)
                {
                    return k;
                }
            }

            throw new BrakAutoryzacjiException("Nieprawidłowa autoryzacja!");
        }

        public decimal StanKonta(Klient klient)
        {
            if(klient == null)
                throw new BrakAutoryzacjiException("Nieprawidłowa autoryzacja!");

            return klient.StanKonta;
        }

        public void Wyplata(Klient klient, decimal kwota)
        {
            if (klient == null)
                throw new BrakAutoryzacjiException("Nieprawidłowa autoryzacja!");

            if (klient.StanKonta - kwota < 0)
                throw new BrakSrodkowNaKoncieException("Niewystarczająca liczba środków na koncie!");

            klient.StanKonta = klient.StanKonta - kwota;
        }

        public void Wplata(Klient klient, decimal kwota)
        {
            if (klient == null)
                throw new BrakAutoryzacjiException("Nieprawidłowa autoryzacja!");

            klient.StanKonta = klient.StanKonta + kwota;
        }

        public void Wyloguj(Klient klient)
        {
            klient = null;
        }

        private void inicjujRachunkiBankowe()
        {
            Klient klient = new Klient("Kowalski", "Jan");
            klient.Pin = 1357;
            klient.NumerRachunku = 12345;
            this._rachunkiBankowe.Add(klient);
        }
    }
}
