
namespace DiabeticsWeek
{
    partial class WyborAktywnosci
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.listBox_lista_aktywnosci = new System.Windows.Forms.ListBox();
            this.button_wybierz_aktywnosc = new System.Windows.Forms.Button();
            this.button_wroc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_lista_aktywnosci
            // 
            this.listBox_lista_aktywnosci.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox_lista_aktywnosci.FormattingEnabled = true;
            this.listBox_lista_aktywnosci.ItemHeight = 25;
            this.listBox_lista_aktywnosci.Location = new System.Drawing.Point(7, 12);
            this.listBox_lista_aktywnosci.Name = "listBox_lista_aktywnosci";
            this.listBox_lista_aktywnosci.Size = new System.Drawing.Size(482, 329);
            this.listBox_lista_aktywnosci.TabIndex = 0;
            // 
            // button_wybierz_aktywnosc
            // 
            this.button_wybierz_aktywnosc.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_wybierz_aktywnosc.Location = new System.Drawing.Point(289, 361);
            this.button_wybierz_aktywnosc.Name = "button_wybierz_aktywnosc";
            this.button_wybierz_aktywnosc.Size = new System.Drawing.Size(97, 34);
            this.button_wybierz_aktywnosc.TabIndex = 1;
            this.button_wybierz_aktywnosc.Text = "Wybierz";
            this.button_wybierz_aktywnosc.UseVisualStyleBackColor = true;
            this.button_wybierz_aktywnosc.Click += new System.EventHandler(this.Button_wybierz_aktywnosc_Click);
            // 
            // button_wroc
            // 
            this.button_wroc.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_wroc.Location = new System.Drawing.Point(392, 361);
            this.button_wroc.Name = "button_wroc";
            this.button_wroc.Size = new System.Drawing.Size(97, 34);
            this.button_wroc.TabIndex = 2;
            this.button_wroc.Text = "Wróć";
            this.button_wroc.UseVisualStyleBackColor = true;
            this.button_wroc.Click += new System.EventHandler(this.Button_wroc_Click);
            // 
            // WyborAktywnosci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(501, 407);
            this.Controls.Add(this.button_wroc);
            this.Controls.Add(this.button_wybierz_aktywnosc);
            this.Controls.Add(this.listBox_lista_aktywnosci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WyborAktywnosci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Aktywność";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_lista_aktywnosci;
        private System.Windows.Forms.Button button_wybierz_aktywnosc;
        private System.Windows.Forms.Button button_wroc;
    }
}