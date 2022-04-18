using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DiabeticsWeek
{
    public partial class Quiz : Form
    {
        Random rnd = new Random();
        int ilosc_pytan = 1;
        int punkty_quiz = 0;
        int nr_pytania = 0;
        bool koniec_gry = false;

        public class Pytanie
        {
            public string pytanie;
            public string odpA;
            public string odpB;
            public string odpC;
            public string odpD;
            public string poprawna_odp;

            public Pytanie(string pytanie, string odpA, string odpB,
                string odpC, string odpD, string poprawna_odp)
            {
                this.pytanie = pytanie;
                this.odpA = odpA;
                this.odpB = odpB;
                this.odpC = odpC;
                this.odpD = odpD;
                this.poprawna_odp = poprawna_odp;
            }
        }


        List<Pytanie> lista_pytan = new List<Pytanie>
        {
            new Pytanie("Cukrzyca może być przyczyną/czynnikiem wielu innych chorób. Najrzadziej z cukrzycą kojarzą się:",
           "choroby oczu", "choroby nerek", "choroby układu krążenia", "choroby układu oddechowego", "choroby układu oddechowego"),

            new Pytanie("Ile jest najczęściej spotykanych postaci cukrzycy?",
           "1", "2", "3", "4", "3"),

            new Pytanie("Najczęściej spotykanym typem cukrzycy jest:",
           "cukrzyca typu I", "cukrzyca typu II", "cukrzyca ciężarnych", "cukrzyca wtórna", "cukrzyca typu II"),

            new Pytanie("Jak inaczej nazywają się wysepki trzustkowe?",
           "wyspy Meissnera", "wyspy Langerhansa", "wyspy Jacobsona", "wyspy Lisfranca", "wyspy Langerhansa"),

            new Pytanie("Cukrzycę typu I wywołuje:",
           "znaczna otyłość", "patogen", "zła dieta", "żadne z powyższych", "żadne z powyższych"),

            new Pytanie("Który hormon odpowiada za obniżenie poziomu cukru we krwi?",
           "glukagon", "glukagen", "insulina", "wazopresyna", "insulina"),

            new Pytanie("Jaki zapach może być kojarzony z cukrzycą?",
           "świeżego chleba", "jabłka", "gotowanej kapusty", "ryby", "jabłka"),

            new Pytanie("Czego powinna unikać osoba chora na cukrzycę planując posiłki?",
            "pieczywa razowego", "chudego mięsa", "gruboziarnistych kasz", "puree ziemniaczanego", "puree ziemniaczanego"),

            new Pytanie("Prawidłowy poziom glukozy we krwi zdrowego człowieka powinien wynosić [mg/dl]:",
            "40-70", "90-120", "60-100", "50-90", "60-100"),

            new Pytanie("Po jakim czasie po jedzeniu powinno mierzyć się cukier, aby uzyskać wiarygodny wynik?",
            "po 2 godzinach", "po 30 minutach", "po 1 godzinie", "po 3 godzinach", "po 2 godzinach"),

            new Pytanie("W których komórkach wysp trzustki produkowana jest insulina?",
            "komórki alfa", "komórki delta", "komórki beta", "komórki epsilon", "komórki beta"),

            new Pytanie("Stanem podwyższonego poziomu glukozy we krwi nazywamy:",
            "glikemią", "hiperglikemią", "hipoglikemią", "makroglikemią", "hiperglikemią"),

            new Pytanie("Jaki procent osób na świecie choruje na cukrzycę?",
            "2%", "5%", "7%", "12%", "5%"),

            new Pytanie("Jak nazywa się specjalizacja lekarska, która zajmuje się leczeniem cukrzycy?",
            "Nefrologia", "Diabetologia", "Hipertensologia", "Patomorfologia", "Diabetologia"),

            new Pytanie("W cukrzycy typu I, trzustka:",
            "produkuje insulinę, lecz nie wykonuje ona swojej roli w organizmie",
            "nie produkuje insuliny", "wytwarza więcej glukozy niż organizm potrzebuje",
            "żadne z powyższych", "nie produkuje insuliny"),

            new Pytanie("W cukrzycy typu II, trzustka:",
            "produkuje insulinę, lecz nie wykonuje ona swojej roli w organizmie",
            "nie produkuje insuliny", "wytwarza więcej glukozy niż organizm potrzebuje",
            "żadne z powyższych", "produkuje insulinę, lecz nie wykonuje ona swojej roli w organizmie")
        };

        public Quiz()
        {
            InitializeComponent();
        }

        private void Button_zacznij_quiz_Click(object sender, EventArgs e)
        {
            if (koniec_gry == false)
            {
                groupBox_pytania.Visible = true;
                button_zacznij_quiz.Visible = false;
                Wybranie_odpowiedzi();
            }
            else
            {
                this.Close();
            }

        }

        private void Button_kolejne_pytanie_Click(object sender, EventArgs e)
        {
            foreach (RadioButton rb in groupBox_odpowiedzi.Controls)
            {
                if (rb != null && rb.Checked)
                {
                    if (rb.Text == lista_pytan[nr_pytania].poprawna_odp)
                    {
                        punkty_quiz += 10;
                    }
                    lista_pytan.RemoveAt(nr_pytania);
                    Wybranie_odpowiedzi();
                }
            }
        }

        public void Wybranie_odpowiedzi()
        {
            if (ilosc_pytan < 6)
            {
                if (ilosc_pytan == 5)
                {
                    button_kolejne_pytanie.Text = "Zakończ";
                }
                groupBox_pytania.Text = "Pytanie nr " + Convert.ToString(ilosc_pytan);
                nr_pytania = rnd.Next(lista_pytan.Count);
                label_pytanie.Text = lista_pytan[nr_pytania].pytanie;
                radioButton_odp1.Text = lista_pytan[nr_pytania].odpA;
                radioButton_odp2.Text = lista_pytan[nr_pytania].odpB;
                radioButton_odp3.Text = lista_pytan[nr_pytania].odpC;
                radioButton_odp4.Text = lista_pytan[nr_pytania].odpD;
                ilosc_pytan += 1;
            }
            else
            {
                koniec_gry = true;
                button_zacznij_quiz.Text = "Zakończ grę.";
                int wynik_koncowy = punkty_quiz + GraGlowna.punkty;
                groupBox_pytania.Visible = false;
                button_zacznij_quiz.Visible = true;
                textBox_wstep_quiz.TextAlign = HorizontalAlignment.Center;
                textBox_wstep_quiz.Text = "Brawo, ukończyłeś quiz! :D" + Environment.NewLine
                    + "Uzyskałeś " + punkty_quiz.ToString() + "/50 punktów." + Environment.NewLine
                    + Environment.NewLine + " W ciagu całej rozgrywki uzyskano " + wynik_koncowy.ToString() + "/100 punktów.";
            }

        }
    }
}
