using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DiabeticsWeek
{
    public partial class GraGlowna : Form
    {
        public GraGlowna()
        {
            InitializeComponent();
            Min_na_godz();
            Losuj_ciekawostke();
            label_data.Text = "Dzień tygodnia: " + dni_tygodnia[dzien];
            label_samopoczucie.Text = "Samopoczucie: " + samopoczucie;
        }
        Random rnd = new Random();
        public static int punkty = 0;
        int dzien = 0;
        string samopoczucie = "dobre";
        int ilosc_pomiarow_cukru = 3;
        public static int poziom_cukru = 90;
        public static int minuty = 480;    // 8 godzin
        public static int godzina = 0;
        readonly List<string> dni_tygodnia = new List<String>
        {
            "poniedziałek", "wtorek", "środa", "czwartek", "piątek"
        };

        List<String> ciekawostki = new List<String>
        {
        "Cukrzyca jest jedną z głównych przyczyn ślepoty, niewydolności nerek oraz amputacji kończyn (najczęściej dolnych).",
        "Cukrzycy typu drugiego można w znaczynm stopniu zapobiec stosując zdrową dietę oraz codzienną aktywność fizyczną - minimum 30 minut.",
        "Cukrzyca typu 1 jest chorobą autoimmunologiczną. Niszczone są komórki wysp trzustkowych odpowiedzialnych za produkcję insuliny.",
        "Około 347 mln ludzi na świecie ma cukrzycę (5% populacji). "
            + "Jest to spowodowane szybkim przyrostem przypadków nadwagi i otyłości oraz brakiem aktywności fizycznej.",
        "Istnieje trzeci typ cukrzycy - cukrzyca ciążowa. Występuje ona u kobiet ciężarnych oraz ustępuje po zakończeniu ciaży. "
            + "Stanowi ona zagrożenie zarówno dla matki jak i płodu. Głównie pojawia się w 3 trymestrze.",
        "Spośród wszystkich zachorowań na cukrzycę, ponad 90% z nich stanowi cukrzyca typu 2. Ostatnimi laty przypadki typu drugiego zwiększyły się "
            + "znacząco wśród dzieci, co wcześniej było dosć rzadkie.",
        "Trzustka jest narządem gruczołowym. Składa się, między innymi, z tak zwanych wysepek trzustkowych (Langerhansa), które odpowiedzialne są "+
            "za produkcję takich hormonów jak glukagon, insulina, amylina, somatostatyna.",
        "Komórki beta odpowiedzialne są za wydzielanie insuliny, natomiast komórki alfa wydzielają glukagon, który podwyższa stężenie glukozy we krwi.",
        "Charakterystyczny zapach z ust przypominający woń kwaśnych jabłek jest objawiem kwasicy ketonowej, która powstaje wskutek nagłego i dużego niedoboru insuliny.",
        "Częstymi, poza podwyższonym stężęniem glukozy we krwi, objawami choroby są: poliuria (wielomocz), "
            + "polidypsja (zwiększone pragnienie) oraz polifagia (wilczy głód)."
        };

        public void Min_na_godz()
        {
            int min = minuty;
            godzina = minuty / 60;
            min -= godzina * 60;

            if (minuty > 1439 && dzien != 4)
            {
                Losuj_ciekawostke();
                dzien += 1;
                godzina = 0;
                minuty -= 1439;
                ilosc_pomiarow_cukru = 3;
                punkty += 10;
            }
            else if (minuty > 1439 && dzien == 4)
            {
                punkty += 10;
                timer_aktualizacja.Enabled = false;
                MessageBox.Show("Główna rozgrywka została zakończona. Zdobyto " + punkty + " pkt."
                    + " Za chwilę zostanie otworzony quiz końcowy ;)", "Koniec gry",
                    MessageBoxButtons.OK);
                this.uruchom_quiz = new Quiz();
                this.uruchom_quiz.ShowDialog();
                this.Close();
            }
            label_czas.Text = String.Format("{0:00}:{1:00}", godzina, min);
        }

        public void Sprawdz_cukier()
        {
            if (poziom_cukru < 55 || poziom_cukru >= 300) // [0,55) i [300, inf)
            {
                samopoczucie = "bardzo złe";
                if (poziom_cukru < 45 || poziom_cukru >= 320)
                {
                    punkty -= 5;
                    timer_aktualizacja.Enabled = false;
                    MessageBox.Show("Niestety poziom glukozy we krwi znacznie przekroczył zakres norm. Musiałeś udać się do szpitala "
                    + "w celu wyrównania poziomu cukru. Zajęło to 4 godziny.", "Szpital",
                    MessageBoxButtons.OK);
                    poziom_cukru = 90;
                    minuty += 240;
                    timer_aktualizacja.Enabled = true;
                }
            }
            else if ((poziom_cukru >= 55 && poziom_cukru < 70) || (poziom_cukru > 140 && poziom_cukru < 300))    // [55,70), (140, 300)
            {
                samopoczucie = "złe";
            }
            else if ((poziom_cukru >= 70 && poziom_cukru <= 140)) // pomiędzy [70, 140]
            {
                samopoczucie = "dobre";
            }
        }
        public void Losuj_ciekawostke()
        {
            int numer_ciekawostki = rnd.Next(ciekawostki.Count);
            textBox_ciekawostka.Text = ciekawostki[numer_ciekawostki];
            ciekawostki.RemoveAt(numer_ciekawostki);
        }

        private void Button_zakoncz_gre_Click(object sender, EventArgs e)
        {
            timer_aktualizacja.Enabled = false;
            DialogResult zamkniecie_gry = MessageBox.Show("Czy na pewno chcesz wyjść z gry?", "Wyjście", MessageBoxButtons.YesNo);
            if (zamkniecie_gry == DialogResult.Yes)
            {
                this.Close();
            }
            else if (zamkniecie_gry == DialogResult.No)
            {
                timer_aktualizacja.Enabled = true;
            }
        }

        private void Button_poziom_cukru_Click(object sender, EventArgs e)
        {
            if (ilosc_pomiarow_cukru > 0)
            {
                ilosc_pomiarow_cukru -= 1;
                MessageBox.Show("Poziom cukru wynosi: " + poziom_cukru, "Informacja o poziomie cukru",
                    MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Wykorzystano dzienny limit pomiarów poziomu glukozy we krwi.",
                    "Informacja o poziomie cukru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button_jedzenie_Click(object sender, EventArgs e)
        {
            this.wybierz_jedzenie = new WyborJedzenia(godzina);
            this.wybierz_jedzenie.ShowDialog();
        }

        private void Button_aktywnosc_Click(object sender, EventArgs e)
        {
            this.wybierz_aktywnosc = new WyborAktywnosci();
            this.wybierz_aktywnosc.ShowDialog();
        }

        private void Timer_aktualizacja_Tick(object sender, EventArgs e)
        {
            Sprawdz_cukier();
            minuty += 1;
            label_samopoczucie.Text = "Samopoczucie: " + samopoczucie;
            label_data.Text = "Dzień tygodnia: " + dni_tygodnia[dzien];
            Min_na_godz();
        }

        private void Button_zatrzymaj_Click(object sender, EventArgs e)
        {
            button_wznow.Enabled = true;
            timer_aktualizacja.Enabled = false;
            button_aktywnosc.Enabled = false;
            button_jedzenie.Enabled = false;
            button_poziom_cukru.Enabled = false;
        }

        private void Button_wznow_Click(object sender, EventArgs e)
        {
            timer_aktualizacja.Enabled = true;
            button_aktywnosc.Enabled = true;
            button_jedzenie.Enabled = true;
            button_poziom_cukru.Enabled = true;
            button_wznow.Enabled = false;
        }

        private void button_do_quizu_Click(object sender, EventArgs e)
        {
            timer_aktualizacja.Enabled = false;
            DialogResult do_quizu = MessageBox.Show("Czy na pewno chcesz zakończyć grę i przejść do wykonania quizu? Pamiętaj, za niedokończony dzień nie otrzymasz "
                + "punktów.", "Quiz", MessageBoxButtons.YesNo);
            if (do_quizu == DialogResult.Yes)
            {
                this.uruchom_quiz = new Quiz();
                this.uruchom_quiz.ShowDialog();
                this.Close();
            }
            else if (do_quizu == DialogResult.No)
            {
                timer_aktualizacja.Enabled = true;
            }
        }
    }
}
