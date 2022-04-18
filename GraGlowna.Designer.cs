
namespace DiabeticsWeek
{
    partial class GraGlowna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        WyborJedzenia wybierz_jedzenie;
        WyborAktywnosci wybierz_aktywnosc;
        Quiz uruchom_quiz;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox_data_czas = new System.Windows.Forms.GroupBox();
            this.label_samopoczucie = new System.Windows.Forms.Label();
            this.label_czas = new System.Windows.Forms.Label();
            this.label_data = new System.Windows.Forms.Label();
            this.button_zakoncz_gre = new System.Windows.Forms.Button();
            this.button_aktywnosc = new System.Windows.Forms.Button();
            this.button_jedzenie = new System.Windows.Forms.Button();
            this.button_poziom_cukru = new System.Windows.Forms.Button();
            this.timer_aktualizacja = new System.Windows.Forms.Timer(this.components);
            this.button_wznow = new System.Windows.Forms.Button();
            this.button_zatrzymaj = new System.Windows.Forms.Button();
            this.groupBox_ciekawostka = new System.Windows.Forms.GroupBox();
            this.textBox_ciekawostka = new System.Windows.Forms.TextBox();
            this.button_do_quizu = new System.Windows.Forms.Button();
            this.groupBox_data_czas.SuspendLayout();
            this.groupBox_ciekawostka.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_data_czas
            // 
            this.groupBox_data_czas.BackColor = System.Drawing.Color.Lime;
            this.groupBox_data_czas.Controls.Add(this.label_samopoczucie);
            this.groupBox_data_czas.Controls.Add(this.label_czas);
            this.groupBox_data_czas.Controls.Add(this.label_data);
            this.groupBox_data_czas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_data_czas.Location = new System.Drawing.Point(12, 12);
            this.groupBox_data_czas.Name = "groupBox_data_czas";
            this.groupBox_data_czas.Size = new System.Drawing.Size(306, 72);
            this.groupBox_data_czas.TabIndex = 0;
            this.groupBox_data_czas.TabStop = false;
            this.groupBox_data_czas.Text = "Informacje";
            // 
            // label_samopoczucie
            // 
            this.label_samopoczucie.AutoSize = true;
            this.label_samopoczucie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_samopoczucie.Location = new System.Drawing.Point(7, 44);
            this.label_samopoczucie.Name = "label_samopoczucie";
            this.label_samopoczucie.Size = new System.Drawing.Size(117, 21);
            this.label_samopoczucie.TabIndex = 2;
            this.label_samopoczucie.Text = "Samopoczucie: ";
            // 
            // label_czas
            // 
            this.label_czas.AutoSize = true;
            this.label_czas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_czas.Location = new System.Drawing.Point(251, 23);
            this.label_czas.Name = "label_czas";
            this.label_czas.Size = new System.Drawing.Size(49, 21);
            this.label_czas.TabIndex = 1;
            this.label_czas.Text = "08:00";
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_data.Location = new System.Drawing.Point(7, 23);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(117, 21);
            this.label_data.TabIndex = 0;
            this.label_data.Text = "Dzień tygodnia:";
            // 
            // button_zakoncz_gre
            // 
            this.button_zakoncz_gre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_zakoncz_gre.Location = new System.Drawing.Point(379, 355);
            this.button_zakoncz_gre.Name = "button_zakoncz_gre";
            this.button_zakoncz_gre.Size = new System.Drawing.Size(110, 40);
            this.button_zakoncz_gre.TabIndex = 3;
            this.button_zakoncz_gre.Text = "Koniec gry";
            this.button_zakoncz_gre.UseVisualStyleBackColor = true;
            this.button_zakoncz_gre.Click += new System.EventHandler(this.Button_zakoncz_gre_Click);
            // 
            // button_aktywnosc
            // 
            this.button_aktywnosc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_aktywnosc.Location = new System.Drawing.Point(12, 355);
            this.button_aktywnosc.Name = "button_aktywnosc";
            this.button_aktywnosc.Size = new System.Drawing.Size(110, 40);
            this.button_aktywnosc.TabIndex = 1;
            this.button_aktywnosc.Text = "Aktywność";
            this.button_aktywnosc.UseVisualStyleBackColor = true;
            this.button_aktywnosc.Click += new System.EventHandler(this.Button_aktywnosc_Click);
            // 
            // button_jedzenie
            // 
            this.button_jedzenie.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_jedzenie.Location = new System.Drawing.Point(128, 355);
            this.button_jedzenie.Name = "button_jedzenie";
            this.button_jedzenie.Size = new System.Drawing.Size(110, 40);
            this.button_jedzenie.TabIndex = 2;
            this.button_jedzenie.Text = "Jedzenie";
            this.button_jedzenie.UseVisualStyleBackColor = true;
            this.button_jedzenie.Click += new System.EventHandler(this.Button_jedzenie_Click);
            // 
            // button_poziom_cukru
            // 
            this.button_poziom_cukru.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_poziom_cukru.Location = new System.Drawing.Point(245, 355);
            this.button_poziom_cukru.Name = "button_poziom_cukru";
            this.button_poziom_cukru.Size = new System.Drawing.Size(110, 40);
            this.button_poziom_cukru.TabIndex = 3;
            this.button_poziom_cukru.Text = "Poziom cukru";
            this.button_poziom_cukru.UseVisualStyleBackColor = true;
            this.button_poziom_cukru.Click += new System.EventHandler(this.Button_poziom_cukru_Click);
            // 
            // timer_aktualizacja
            // 
            this.timer_aktualizacja.Enabled = true;
            this.timer_aktualizacja.Interval = 1000;
            this.timer_aktualizacja.Tick += new System.EventHandler(this.Timer_aktualizacja_Tick);
            // 
            // button_wznow
            // 
            this.button_wznow.Enabled = false;
            this.button_wznow.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_wznow.Location = new System.Drawing.Point(380, 47);
            this.button_wznow.Name = "button_wznow";
            this.button_wznow.Size = new System.Drawing.Size(109, 29);
            this.button_wznow.TabIndex = 4;
            this.button_wznow.Text = "Wznów grę";
            this.button_wznow.UseVisualStyleBackColor = true;
            this.button_wznow.Click += new System.EventHandler(this.Button_wznow_Click);
            // 
            // button_zatrzymaj
            // 
            this.button_zatrzymaj.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_zatrzymaj.Location = new System.Drawing.Point(381, 12);
            this.button_zatrzymaj.Name = "button_zatrzymaj";
            this.button_zatrzymaj.Size = new System.Drawing.Size(108, 29);
            this.button_zatrzymaj.TabIndex = 5;
            this.button_zatrzymaj.Text = "Zatrzymaj grę";
            this.button_zatrzymaj.UseVisualStyleBackColor = true;
            this.button_zatrzymaj.Click += new System.EventHandler(this.Button_zatrzymaj_Click);
            // 
            // groupBox_ciekawostka
            // 
            this.groupBox_ciekawostka.Controls.Add(this.textBox_ciekawostka);
            this.groupBox_ciekawostka.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_ciekawostka.Location = new System.Drawing.Point(12, 91);
            this.groupBox_ciekawostka.Name = "groupBox_ciekawostka";
            this.groupBox_ciekawostka.Size = new System.Drawing.Size(313, 203);
            this.groupBox_ciekawostka.TabIndex = 6;
            this.groupBox_ciekawostka.TabStop = false;
            this.groupBox_ciekawostka.Text = "Czy wiesz, że...";
            // 
            // textBox_ciekawostka
            // 
            this.textBox_ciekawostka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_ciekawostka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_ciekawostka.Location = new System.Drawing.Point(7, 28);
            this.textBox_ciekawostka.Multiline = true;
            this.textBox_ciekawostka.Name = "textBox_ciekawostka";
            this.textBox_ciekawostka.ReadOnly = true;
            this.textBox_ciekawostka.Size = new System.Drawing.Size(293, 169);
            this.textBox_ciekawostka.TabIndex = 0;
            // 
            // button_do_quizu
            // 
            this.button_do_quizu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_do_quizu.Location = new System.Drawing.Point(381, 290);
            this.button_do_quizu.Name = "button_do_quizu";
            this.button_do_quizu.Size = new System.Drawing.Size(108, 59);
            this.button_do_quizu.TabIndex = 7;
            this.button_do_quizu.Text = "Przejdź do quizu";
            this.button_do_quizu.UseVisualStyleBackColor = true;
            this.button_do_quizu.Click += new System.EventHandler(this.button_do_quizu_Click);
            // 
            // GraGlowna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::DiabeticsWeek.Properties.Resources.gra;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(501, 407);
            this.Controls.Add(this.button_do_quizu);
            this.Controls.Add(this.groupBox_ciekawostka);
            this.Controls.Add(this.button_zatrzymaj);
            this.Controls.Add(this.button_wznow);
            this.Controls.Add(this.button_zakoncz_gre);
            this.Controls.Add(this.button_poziom_cukru);
            this.Controls.Add(this.button_jedzenie);
            this.Controls.Add(this.button_aktywnosc);
            this.Controls.Add(this.groupBox_data_czas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GraGlowna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Diabetic\'s Week";
            this.groupBox_data_czas.ResumeLayout(false);
            this.groupBox_data_czas.PerformLayout();
            this.groupBox_ciekawostka.ResumeLayout(false);
            this.groupBox_ciekawostka.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_data_czas;
        private System.Windows.Forms.Label label_samopoczucie;
        private System.Windows.Forms.Label label_czas;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.Button button_zakoncz_gre;
        private System.Windows.Forms.Button button_aktywnosc;
        private System.Windows.Forms.Button button_jedzenie;
        private System.Windows.Forms.Button button_poziom_cukru;
        private System.Windows.Forms.Timer timer_aktualizacja;
        private System.Windows.Forms.Button button_wznow;
        private System.Windows.Forms.Button button_zatrzymaj;
        private System.Windows.Forms.GroupBox groupBox_ciekawostka;
        private System.Windows.Forms.TextBox textBox_ciekawostka;
        private System.Windows.Forms.Button button_do_quizu;
    }
}