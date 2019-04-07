using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank.Klasy
{
    public class Klient
    {
        private string _nazwisko;
        public string Nazwisko
        {
            get
            {
                return this._nazwisko;
            }
            set
            {
                this._nazwisko = value;
            }
        }

        private string _imie;
        public string Imie
        {
            get
            {
                return this._imie;
            }
            set
            {
                this._imie = value;
            }
        }

        private int _numerRachunku;
        public int NumerRachunku
        {
            get
            {
                return this._numerRachunku;
            }
            set
            {
                this._numerRachunku = value;
            }
        }

        private int _pin;
        public int Pin
        {
            get
            {
                return this._pin;
            }
            set
            {
                this._pin = value;
            }
        }

        private decimal _stanKonta;
        public decimal StanKonta
        {
            get
            {
                return this._stanKonta;
            }
            set
            {
                this._stanKonta = value;
            }
        }

        public Klient(string _naz, string _im)
        {
            this._nazwisko = _naz;
            this._imie = _im;
            this._stanKonta = 0m;
        }
    }
}
