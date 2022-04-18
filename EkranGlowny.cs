using System;
using System.Windows.Forms;

namespace DiabeticsWeek
{
    public partial class EkranGlowny : Form
    {
        public EkranGlowny()
        {
            InitializeComponent();
            panel_info.Visible = false;
            panel_menu.Visible = true;
        }

        private void Button_wyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_info_Click(object sender, EventArgs e)
        {
            panel_menu.Visible = false;
            panel_info.Visible = true;
            panel_info.BringToFront();
        }

        private void Button_powrot_ekran_glowny_Click(object sender, EventArgs e)
        {
            panel_info.Visible = false;
            panel_menu.Visible = true;
            panel_menu.BringToFront();
        }

        private void Button_start_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.gra = new GraGlowna();
            this.gra.ShowDialog();
            this.Close();
        }
    }
}
