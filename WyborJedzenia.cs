using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DiabeticsWeek
{
    public partial class WyborJedzenia : Form
    {
        public WyborJedzenia(int godzina)
        {
            InitializeComponent();
            int czas = godzina;
            Wyswietlanie_zawartosci(czas);
        }
        public class Jedzenie
        {
            public string nazwa;
            public int ig;

            public Jedzenie(string nazwa, int ig)
            {
                this.nazwa = nazwa;
                this.ig = ig;
            }
        }

        public List<Jedzenie> sniadanie = new List<Jedzenie>
        {
            new Jedzenie("Jajka sadzone, herbata", 10),
            new Jedzenie("Bułka graham z sałatą i pomidorem, herbata", 23),
            new Jedzenie("Owsianka z gruszką i śliwkami", 35),
            new Jedzenie("Koktail z maślanki i pomarańczy", 28),
            new Jedzenie("Bułka z szynką i sałatą, kawa", 34)
        };

        public List<Jedzenie> sniadanie2 = new List<Jedzenie>
        {
            new Jedzenie("Jabłko", 36),
            new Jedzenie("Koktail bananowo-truskawkowy", 22),
            new Jedzenie("Gruszka i mandarynka", 34),
            new Jedzenie("Budyń cytrynowy z kaszy jaglanej", 41),
            new Jedzenie("Ciastka owsiane z siemieniem lnianym", 25)
        };

        public List<Jedzenie> obiad = new List<Jedzenie>
        {
            new Jedzenie("Pierś z kurczaka z ryżem", 43),
            new Jedzenie("Polędwica z dorsza w sosie pomidorowym", 45),
            new Jedzenie("Schabowy z ziemniakami i surówką", 63),
            new Jedzenie("Pieczony sandacz z warzywami", 55),
            new Jedzenie("Pieczony indyk w ziołach z ryżem i sałatką", 52)
        };

        public List<Jedzenie> podwieczorek = new List<Jedzenie>
        {
            new Jedzenie("Kisiel niesłodozny z owocami", 56),
            new Jedzenie("Sałatka z otrębami i kisiel", 32),
            new Jedzenie("Truskawkowy koktajl", 41),
            new Jedzenie("Jogurt z otrębami i orzechami", 32),
            new Jedzenie("Sałatka owocowo-warzywna", 25)
        };

        public List<Jedzenie> kolacja = new List<Jedzenie>
        {
            new Jedzenie("Dwie kromki razowe z makrelą wędzoną", 36),
            new Jedzenie("Kanapki - chleb żytni z twarożkiem i sałatą", 31),
            new Jedzenie("Kanapki z jajkiem i węgliną", 21),
            new Jedzenie("Omlet z sałatką", 35),
            new Jedzenie("Kanapki z surówką i jogurtem", 37)
        };

        public List<Jedzenie> przekaski = new List<Jedzenie>
        {
            new Jedzenie("Orzechy włoskie", 15),
            new Jedzenie("Dwie marchewki", 32),
            new Jedzenie("Banan", 52),
            new Jedzenie("Kilka kostek ciemnej czekolady", 22),
            new Jedzenie("Kawałek ciasta czekoladowego", 60)
        };

        public void Wyswietlanie_zawartosci(int czas)
        {
            var lista = sniadanie;
            int i = 1;

            if (czas < 12)
            {
                lista = sniadanie;
            }
            else if (czas >= 12 && czas < 15)
            {
                lista = sniadanie2;
            }
            else if (czas >= 15 && czas < 18)
            {
                lista = obiad;
            }
            else if (czas >= 18 && czas < 21)
            {
                lista = podwieczorek;
            }
            else if (czas >= 21)
            {
                lista = kolacja;
            }

            foreach (Jedzenie jedz in lista)
            {
                string zawartosc = i.ToString() + ". " + jedz.nazwa + "    IG = " + jedz.ig;
                listBox_lista_jedzenia.Items.Add(zawartosc);
                i += 1;
            }

            foreach (Jedzenie jedz in przekaski)
            {
                string zawartosc = i.ToString() + ". " + jedz.nazwa + "    IG = " + jedz.ig;
                listBox_lista_jedzenia.Items.Add(zawartosc);
                i += 1;
            }
        }

        public void Button_wybierz_jedzenie_Click(object sender, EventArgs e)
        {
            if (listBox_lista_jedzenia.SelectedIndex == -1)
            {
                MessageBox.Show("Najpiew wbierz jedzenie!");
            }
            else
            {
                string a = listBox_lista_jedzenia.SelectedItem.ToString();
                GraGlowna.poziom_cukru += Convert.ToInt32(a.Substring(a.Length - 2));
                GraGlowna.minuty += 30;
                this.Close();
            }

        }

        private void Button_wroc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label_IGinfo_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(label_IGinfo, "Kliknij, aby dowiedzieć się więcej.");
        }

        private void Label_IGinfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Indeks glikemiczny (IG) określa wpływ spożytych produktów na stężenie glukozy we krwi w ciągu 2-3 godzin po ich spożyciu. "
                + "Produkty możemy podzielić na produkty o niskim IG (do 55), średnim (56-70) oraz wysokim indeksie glikemicznym (powyżej 70)"
                + Environment.NewLine + Environment.NewLine + "W grze przyjęto pewne uproszczenie, które nie odzwierciedla w 100% wpływu jedzenia "
                + "o podanym IG na stęzenie glukozy we krwi!");
        }
    }
}

