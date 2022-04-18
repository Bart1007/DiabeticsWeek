
namespace DiabeticsWeek
{
    partial class EkranGlowny
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        GraGlowna gra;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EkranGlowny));
            this.button_start = new System.Windows.Forms.Button();
            this.button_info = new System.Windows.Forms.Button();
            this.button_wyjscie = new System.Windows.Forms.Button();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.pictureBox_tytul = new System.Windows.Forms.PictureBox();
            this.panel_info = new System.Windows.Forms.Panel();
            this.textBox_info_gra = new System.Windows.Forms.TextBox();
            this.label_o_grze = new System.Windows.Forms.Label();
            this.button_powrot_ekran_glowny = new System.Windows.Forms.Button();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tytul)).BeginInit();
            this.panel_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_start.Location = new System.Drawing.Point(107, 203);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(150, 40);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.Button_start_Click);
            // 
            // button_info
            // 
            this.button_info.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_info.Location = new System.Drawing.Point(107, 249);
            this.button_info.Name = "button_info";
            this.button_info.Size = new System.Drawing.Size(150, 40);
            this.button_info.TabIndex = 1;
            this.button_info.Text = "Informacje o grze";
            this.button_info.UseVisualStyleBackColor = true;
            this.button_info.Click += new System.EventHandler(this.Button_info_Click);
            // 
            // button_wyjscie
            // 
            this.button_wyjscie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_wyjscie.Location = new System.Drawing.Point(107, 295);
            this.button_wyjscie.Name = "button_wyjscie";
            this.button_wyjscie.Size = new System.Drawing.Size(150, 40);
            this.button_wyjscie.TabIndex = 2;
            this.button_wyjscie.Text = "Wyjście";
            this.button_wyjscie.UseVisualStyleBackColor = true;
            this.button_wyjscie.Click += new System.EventHandler(this.Button_wyjscie_Click);
            // 
            // panel_menu
            // 
            this.panel_menu.BackgroundImage = global::DiabeticsWeek.Properties.Resources.glowne_tlo;
            this.panel_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_menu.Controls.Add(this.pictureBox_tytul);
            this.panel_menu.Controls.Add(this.button_wyjscie);
            this.panel_menu.Controls.Add(this.button_info);
            this.panel_menu.Controls.Add(this.button_start);
            this.panel_menu.Location = new System.Drawing.Point(10, 10);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(1);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(364, 541);
            this.panel_menu.TabIndex = 0;
            // 
            // pictureBox_tytul
            // 
            this.pictureBox_tytul.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_tytul.BackgroundImage = global::DiabeticsWeek.Properties.Resources.Diabetic_s_Week;
            this.pictureBox_tytul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_tytul.Location = new System.Drawing.Point(40, 36);
            this.pictureBox_tytul.Name = "pictureBox_tytul";
            this.pictureBox_tytul.Size = new System.Drawing.Size(296, 101);
            this.pictureBox_tytul.TabIndex = 3;
            this.pictureBox_tytul.TabStop = false;
            // 
            // panel_info
            // 
            this.panel_info.Controls.Add(this.textBox_info_gra);
            this.panel_info.Controls.Add(this.label_o_grze);
            this.panel_info.Controls.Add(this.button_powrot_ekran_glowny);
            this.panel_info.Location = new System.Drawing.Point(10, 10);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(364, 541);
            this.panel_info.TabIndex = 3;
            // 
            // textBox_info_gra
            // 
            this.textBox_info_gra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_info_gra.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_info_gra.Location = new System.Drawing.Point(0, 36);
            this.textBox_info_gra.Multiline = true;
            this.textBox_info_gra.Name = "textBox_info_gra";
            this.textBox_info_gra.ReadOnly = true;
            this.textBox_info_gra.Size = new System.Drawing.Size(358, 456);
            this.textBox_info_gra.TabIndex = 2;
            this.textBox_info_gra.Text = resources.GetString("textBox_info_gra.Text");
            // 
            // label_o_grze
            // 
            this.label_o_grze.AutoSize = true;
            this.label_o_grze.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_o_grze.Location = new System.Drawing.Point(63, 9);
            this.label_o_grze.Name = "label_o_grze";
            this.label_o_grze.Size = new System.Drawing.Size(248, 24);
            this.label_o_grze.TabIndex = 1;
            this.label_o_grze.Text = "Informacje na temat gry";
            // 
            // button_powrot_ekran_glowny
            // 
            this.button_powrot_ekran_glowny.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_powrot_ekran_glowny.Location = new System.Drawing.Point(211, 498);
            this.button_powrot_ekran_glowny.Name = "button_powrot_ekran_glowny";
            this.button_powrot_ekran_glowny.Size = new System.Drawing.Size(150, 40);
            this.button_powrot_ekran_glowny.TabIndex = 0;
            this.button_powrot_ekran_glowny.Text = "Wróć";
            this.button_powrot_ekran_glowny.UseVisualStyleBackColor = true;
            this.button_powrot_ekran_glowny.Click += new System.EventHandler(this.Button_powrot_ekran_glowny_Click);
            // 
            // EkranGlowny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.panel_info);
            this.Controls.Add(this.panel_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EkranGlowny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diabetic\'s Week";
            this.panel_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tytul)).EndInit();
            this.panel_info.ResumeLayout(false);
            this.panel_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_info;
        private System.Windows.Forms.Button button_wyjscie;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_info;
        private System.Windows.Forms.Button button_powrot_ekran_glowny;
        private System.Windows.Forms.TextBox textBox_info_gra;
        private System.Windows.Forms.Label label_o_grze;
        private System.Windows.Forms.PictureBox pictureBox_tytul;
    }
}

