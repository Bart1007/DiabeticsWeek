
namespace DiabeticsWeek
{
    partial class Quiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz));
            this.pictureBox_quiz = new System.Windows.Forms.PictureBox();
            this.button_zacznij_quiz = new System.Windows.Forms.Button();
            this.textBox_wstep_quiz = new System.Windows.Forms.TextBox();
            this.radioButton_odp1 = new System.Windows.Forms.RadioButton();
            this.radioButton_odp2 = new System.Windows.Forms.RadioButton();
            this.radioButton_odp4 = new System.Windows.Forms.RadioButton();
            this.radioButton_odp3 = new System.Windows.Forms.RadioButton();
            this.label_pytanie = new System.Windows.Forms.Label();
            this.button_kolejne_pytanie = new System.Windows.Forms.Button();
            this.groupBox_pytania = new System.Windows.Forms.GroupBox();
            this.groupBox_odpowiedzi = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_quiz)).BeginInit();
            this.groupBox_pytania.SuspendLayout();
            this.groupBox_odpowiedzi.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_quiz
            // 
            this.pictureBox_quiz.Image = global::DiabeticsWeek.Properties.Resources.quiz_napis;
            this.pictureBox_quiz.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_quiz.Name = "pictureBox_quiz";
            this.pictureBox_quiz.Size = new System.Drawing.Size(552, 105);
            this.pictureBox_quiz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_quiz.TabIndex = 0;
            this.pictureBox_quiz.TabStop = false;
            // 
            // button_zacznij_quiz
            // 
            this.button_zacznij_quiz.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_zacznij_quiz.Location = new System.Drawing.Point(212, 294);
            this.button_zacznij_quiz.Name = "button_zacznij_quiz";
            this.button_zacznij_quiz.Size = new System.Drawing.Size(161, 56);
            this.button_zacznij_quiz.TabIndex = 1;
            this.button_zacznij_quiz.Text = "Zaczynamy!";
            this.button_zacznij_quiz.UseVisualStyleBackColor = true;
            this.button_zacznij_quiz.Click += new System.EventHandler(this.Button_zacznij_quiz_Click);
            // 
            // textBox_wstep_quiz
            // 
            this.textBox_wstep_quiz.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_wstep_quiz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_wstep_quiz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_wstep_quiz.Location = new System.Drawing.Point(12, 149);
            this.textBox_wstep_quiz.Multiline = true;
            this.textBox_wstep_quiz.Name = "textBox_wstep_quiz";
            this.textBox_wstep_quiz.ReadOnly = true;
            this.textBox_wstep_quiz.Size = new System.Drawing.Size(552, 139);
            this.textBox_wstep_quiz.TabIndex = 2;
            this.textBox_wstep_quiz.Text = resources.GetString("textBox_wstep_quiz.Text");
            // 
            // radioButton_odp1
            // 
            this.radioButton_odp1.AutoSize = true;
            this.radioButton_odp1.Location = new System.Drawing.Point(6, 27);
            this.radioButton_odp1.Name = "radioButton_odp1";
            this.radioButton_odp1.Size = new System.Drawing.Size(119, 25);
            this.radioButton_odp1.TabIndex = 2;
            this.radioButton_odp1.TabStop = true;
            this.radioButton_odp1.Text = "radioButton1";
            this.radioButton_odp1.UseVisualStyleBackColor = true;
            // 
            // radioButton_odp2
            // 
            this.radioButton_odp2.AutoSize = true;
            this.radioButton_odp2.Location = new System.Drawing.Point(6, 58);
            this.radioButton_odp2.Name = "radioButton_odp2";
            this.radioButton_odp2.Size = new System.Drawing.Size(119, 25);
            this.radioButton_odp2.TabIndex = 3;
            this.radioButton_odp2.TabStop = true;
            this.radioButton_odp2.Text = "radioButton2";
            this.radioButton_odp2.UseVisualStyleBackColor = true;
            // 
            // radioButton_odp4
            // 
            this.radioButton_odp4.AutoSize = true;
            this.radioButton_odp4.Location = new System.Drawing.Point(6, 119);
            this.radioButton_odp4.Name = "radioButton_odp4";
            this.radioButton_odp4.Size = new System.Drawing.Size(119, 25);
            this.radioButton_odp4.TabIndex = 5;
            this.radioButton_odp4.TabStop = true;
            this.radioButton_odp4.Text = "radioButton4";
            this.radioButton_odp4.UseVisualStyleBackColor = true;
            // 
            // radioButton_odp3
            // 
            this.radioButton_odp3.AutoSize = true;
            this.radioButton_odp3.Location = new System.Drawing.Point(6, 89);
            this.radioButton_odp3.Name = "radioButton_odp3";
            this.radioButton_odp3.Size = new System.Drawing.Size(119, 25);
            this.radioButton_odp3.TabIndex = 4;
            this.radioButton_odp3.TabStop = true;
            this.radioButton_odp3.Text = "radioButton3";
            this.radioButton_odp3.UseVisualStyleBackColor = true;
            // 
            // label_pytanie
            // 
            this.label_pytanie.AutoSize = true;
            this.label_pytanie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_pytanie.Location = new System.Drawing.Point(6, 24);
            this.label_pytanie.MaximumSize = new System.Drawing.Size(540, 0);
            this.label_pytanie.Name = "label_pytanie";
            this.label_pytanie.Size = new System.Drawing.Size(124, 21);
            this.label_pytanie.TabIndex = 1;
            this.label_pytanie.Text = "Tekst z pytaniem";
            // 
            // button_kolejne_pytanie
            // 
            this.button_kolejne_pytanie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_kolejne_pytanie.Location = new System.Drawing.Point(452, 241);
            this.button_kolejne_pytanie.Name = "button_kolejne_pytanie";
            this.button_kolejne_pytanie.Size = new System.Drawing.Size(94, 31);
            this.button_kolejne_pytanie.TabIndex = 6;
            this.button_kolejne_pytanie.Text = "Następne";
            this.button_kolejne_pytanie.UseVisualStyleBackColor = true;
            this.button_kolejne_pytanie.Click += new System.EventHandler(this.Button_kolejne_pytanie_Click);
            // 
            // groupBox_pytania
            // 
            this.groupBox_pytania.Controls.Add(this.groupBox_odpowiedzi);
            this.groupBox_pytania.Controls.Add(this.label_pytanie);
            this.groupBox_pytania.Controls.Add(this.button_kolejne_pytanie);
            this.groupBox_pytania.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_pytania.Location = new System.Drawing.Point(12, 123);
            this.groupBox_pytania.Name = "groupBox_pytania";
            this.groupBox_pytania.Size = new System.Drawing.Size(552, 281);
            this.groupBox_pytania.TabIndex = 7;
            this.groupBox_pytania.TabStop = false;
            this.groupBox_pytania.Text = "Pytanie nr 1";
            this.groupBox_pytania.Visible = false;
            // 
            // groupBox_odpowiedzi
            // 
            this.groupBox_odpowiedzi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox_odpowiedzi.Controls.Add(this.radioButton_odp2);
            this.groupBox_odpowiedzi.Controls.Add(this.radioButton_odp1);
            this.groupBox_odpowiedzi.Controls.Add(this.radioButton_odp3);
            this.groupBox_odpowiedzi.Controls.Add(this.radioButton_odp4);
            this.groupBox_odpowiedzi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_odpowiedzi.Location = new System.Drawing.Point(6, 79);
            this.groupBox_odpowiedzi.Name = "groupBox_odpowiedzi";
            this.groupBox_odpowiedzi.Size = new System.Drawing.Size(540, 156);
            this.groupBox_odpowiedzi.TabIndex = 7;
            this.groupBox_odpowiedzi.TabStop = false;
            this.groupBox_odpowiedzi.Text = "Wybierz odpowiedź:";
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 407);
            this.Controls.Add(this.pictureBox_quiz);
            this.Controls.Add(this.groupBox_pytania);
            this.Controls.Add(this.button_zacznij_quiz);
            this.Controls.Add(this.textBox_wstep_quiz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_quiz)).EndInit();
            this.groupBox_pytania.ResumeLayout(false);
            this.groupBox_pytania.PerformLayout();
            this.groupBox_odpowiedzi.ResumeLayout(false);
            this.groupBox_odpowiedzi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_quiz;
        private System.Windows.Forms.Button button_zacznij_quiz;
        private System.Windows.Forms.TextBox textBox_wstep_quiz;
        private System.Windows.Forms.RadioButton radioButton_odp4;
        private System.Windows.Forms.RadioButton radioButton_odp3;
        private System.Windows.Forms.RadioButton radioButton_odp2;
        private System.Windows.Forms.RadioButton radioButton_odp1;
        private System.Windows.Forms.Label label_pytanie;
        private System.Windows.Forms.Button button_kolejne_pytanie;
        private System.Windows.Forms.GroupBox groupBox_pytania;
        private System.Windows.Forms.GroupBox groupBox_odpowiedzi;
    }
}