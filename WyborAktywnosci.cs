using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DiabeticsWeek
{
    public partial class WyborAktywnosci : Form
    {
        public WyborAktywnosci()
        {
            InitializeComponent();
            Wyswietlanie_zawartosci();
        }

        public class Aktywnosc
        {
            public string nazwa;
            public int intensywnosc;
            public int czas_trwania;

            public Aktywnosc(string nazwa, int intensywnosc, int czas_trwania)
            {
                this.nazwa = nazwa;
                this.intensywnosc = intensywnosc;
                this.czas_trwania = czas_trwania;
            }
        }

        readonly List<Aktywnosc> aktywnosc = new List<Aktywnosc>
        {
            new Aktywnosc ("Lek obniżajacy poziom glukozy we krwi",50,15),
            new Aktywnosc("Zjedzenie czegoś słodkiego",-50,1),
            new Aktywnosc("Basen 1h", 50, 60),
            new Aktywnosc("Bieganie 1h", 40, 60),
            new Aktywnosc("Drzemka 30min", 20, 30),
            new Aktywnosc("Gra na instrumencie 45min", 30, 45),
            new Aktywnosc("Granie na komputerze 1h", 10, 60),
            new Aktywnosc("Jazda na rowerze 1,5h", 40, 90),
            new Aktywnosc("Jazda na rowerze 1h", 20, 60),
            new Aktywnosc("Nauka 1h", 30, 60),
            new Aktywnosc("Odpoczynek 1h",0,60),
            new Aktywnosc("Obejrzenie filmu 2h",10,120),
            new Aktywnosc("Spacer 30min", 30, 30),
            new Aktywnosc("Spacer 1h", 30, 60),
            new Aktywnosc("Spanie 8h", -20, 480)
        };

        public void Wyswietlanie_zawartosci()
        {
            foreach (Aktywnosc akt in aktywnosc)
            {
                listBox_lista_aktywnosci.Items.Add(akt.nazwa);
            }
        }

        private void Button_wybierz_aktywnosc_Click(object sender, EventArgs e)
        {
            if (listBox_lista_aktywnosci.SelectedIndex == -1)
            {
                MessageBox.Show("Najpiew wbierz aktywność!");
            }
            else
            {
                string wybrana_aktywnosc = listBox_lista_aktywnosci.SelectedItem.ToString();
                for (int i = 0; i < aktywnosc.Count; i++)
                {
                    if (wybrana_aktywnosc == aktywnosc[i].nazwa)
                    {
                        if (GraGlowna.godzina < 22 && wybrana_aktywnosc == "Spanie 8h")
                        {

                            MessageBox.Show("Jest za wcześnie żeby pójść spać.",
                            "Spanie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            GraGlowna.minuty += aktywnosc[i].czas_trwania;
                            GraGlowna.poziom_cukru -= aktywnosc[i].intensywnosc;
                            this.Close();
                        }

                    }
                }
            }
        }

        private void Button_wroc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
