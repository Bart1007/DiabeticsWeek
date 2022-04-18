
namespace DiabeticsWeek
{
    partial class WyborJedzenia
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
            this.components = new System.ComponentModel.Container();
            this.listBox_lista_jedzenia = new System.Windows.Forms.ListBox();
            this.button_wybierz_jedzenie = new System.Windows.Forms.Button();
            this.button_wroc = new System.Windows.Forms.Button();
            this.label_IGinfo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // listBox_lista_jedzenia
            // 
            this.listBox_lista_jedzenia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox_lista_jedzenia.FormattingEnabled = true;
            this.listBox_lista_jedzenia.ItemHeight = 21;
            this.listBox_lista_jedzenia.Location = new System.Drawing.Point(7, 12);
            this.listBox_lista_jedzenia.Name = "listBox_lista_jedzenia";
            this.listBox_lista_jedzenia.Size = new System.Drawing.Size(482, 340);
            this.listBox_lista_jedzenia.TabIndex = 0;
            // 
            // button_wybierz_jedzenie
            // 
            this.button_wybierz_jedzenie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_wybierz_jedzenie.Location = new System.Drawing.Point(289, 361);
            this.button_wybierz_jedzenie.Name = "button_wybierz_jedzenie";
            this.button_wybierz_jedzenie.Size = new System.Drawing.Size(97, 34);
            this.button_wybierz_jedzenie.TabIndex = 1;
            this.button_wybierz_jedzenie.Text = "Wybierz";
            this.button_wybierz_jedzenie.UseVisualStyleBackColor = true;
            this.button_wybierz_jedzenie.Click += new System.EventHandler(this.Button_wybierz_jedzenie_Click);
            // 
            // button_wroc
            // 
            this.button_wroc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_wroc.Location = new System.Drawing.Point(392, 361);
            this.button_wroc.Name = "button_wroc";
            this.button_wroc.Size = new System.Drawing.Size(97, 34);
            this.button_wroc.TabIndex = 2;
            this.button_wroc.Text = "Wróć";
            this.button_wroc.UseVisualStyleBackColor = true;
            this.button_wroc.Click += new System.EventHandler(this.Button_wroc_Click);
            // 
            // label_IGinfo
            // 
            this.label_IGinfo.AutoSize = true;
            this.label_IGinfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_IGinfo.Location = new System.Drawing.Point(12, 368);
            this.label_IGinfo.Name = "label_IGinfo";
            this.label_IGinfo.Size = new System.Drawing.Size(101, 21);
            this.label_IGinfo.TabIndex = 3;
            this.label_IGinfo.Text = "Co to jest IG?";
            this.label_IGinfo.Click += new System.EventHandler(this.Label_IGinfo_Click);
            this.label_IGinfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_IGinfo_MouseMove);
            // 
            // WyborJedzenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(501, 407);
            this.Controls.Add(this.label_IGinfo);
            this.Controls.Add(this.button_wroc);
            this.Controls.Add(this.button_wybierz_jedzenie);
            this.Controls.Add(this.listBox_lista_jedzenia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WyborJedzenia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jedzenie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_lista_jedzenia;
        private System.Windows.Forms.Button button_wybierz_jedzenie;
        private System.Windows.Forms.Button button_wroc;
        private System.Windows.Forms.Label label_IGinfo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}