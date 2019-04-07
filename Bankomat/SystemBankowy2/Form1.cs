using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bank.Wyjatki;

namespace SystemBankowy2
{
    public partial class Form1 : Form
    {
        private Bankomat.Klasy.Bankomat bankomat;
        private Bank.Klasy.Klient klientCache;

        public Form1()
        {
            InitializeComponent();
            this.bankomat = new Bankomat.Klasy.Bankomat();

            this.BStanKonta.Visible = false;
            this.BWyplata.Visible = false;
            this.BWplata.Visible = false;
        }

        private void BZaloguj_Click(object sender, EventArgs e)
        {
            try
            {
                this.klientCache = this.bankomat.Autoryzacja((int)this.TPin.Value, (int)this.TNumerKarty.Value);

                this.LZalogowany.Text = String.Format("Klient: {0} {1}", this.klientCache.Nazwisko, this.klientCache.Imie);

                this.BStanKonta.Visible = true;
                this.BWyplata.Visible = true;
                this.BWplata.Visible = true;

                this.TPin.Value = 0m;
                this.TNumerKarty.Value = 0m;
                this.TPin.Enabled = false;
                this.TNumerKarty.Enabled = false;

                this.BZaloguj.Click -= new EventHandler(this.BZaloguj_Click);
                this.BZaloguj.Text = "Wyloguj";
                this.BZaloguj.Click += new EventHandler(this.BWyloguj_Click);
            }
            catch (BrakAutoryzacjiException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }
        }

        private void BWyloguj_Click(object sender, EventArgs e)
        {
            try
            {
                this.bankomat.Wyloguj(this.klientCache);

                this.BStanKonta.Visible = false;
                this.BWyplata.Visible = false;
                this.BWplata.Visible = false;

                this.TPin.Enabled = true;
                this.TNumerKarty.Enabled = true;

                this.BZaloguj.Click -= new EventHandler(this.BWyloguj_Click);
                this.BZaloguj.Text = "Zaloguj";
                this.BZaloguj.Click += new EventHandler(this.BZaloguj_Click);

                this.LZalogowany.Text = "";
            }
            catch (BrakAutoryzacjiException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }
        }

        private void BStanKonta_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(this.bankomat.StanKonta(this.klientCache).ToString());
            }
            catch (BrakAutoryzacjiException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }
        }

        private void BWyplata_Click(object sender, EventArgs e)
        {
            try
            {
                //Wartość 100 jest podana na sztywno. Należałoby zrobić formatkę
                //umożliwiającą podanie kwoty, którą chcielibyśmy wypłacić z naszego konta
                this.bankomat.Wyplata(this.klientCache, 100);
            }
            catch (BrakAutoryzacjiException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }
        }

        private void BWplata_Click(object sender, EventArgs e)
        {
            try
            {
                //Wartość 1000 jest podana na sztywno. Należałoby zrobić jakąś formatkę
                //za pomocą której podawalibyśmy kwotę do wpłaty
                this.bankomat.Wplata(this.klientCache, 1000);
            }
            catch (BrakAutoryzacjiException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }
        }

        private void TNumerKarty_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TPin_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
