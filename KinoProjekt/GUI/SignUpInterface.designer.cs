namespace LoginInterface
{
    partial class SignUpInterface
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
            this.textBoxPlec = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.textBoxKodP = new System.Windows.Forms.TextBox();
            this.textBoxNrMieszkania = new System.Windows.Forms.TextBox();
            this.textBoxDataUr = new System.Windows.Forms.TextBox();
            this.textBoxNrDomu = new System.Windows.Forms.TextBox();
            this.textBoxUlica = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxMiasto = new System.Windows.Forms.TextBox();
            this.comboBoxWoj = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPowrot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPlec
            // 
            this.textBoxPlec.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPlec.Location = new System.Drawing.Point(62, 291);
            this.textBoxPlec.Name = "textBoxPlec";
            this.textBoxPlec.Size = new System.Drawing.Size(235, 20);
            this.textBoxPlec.TabIndex = 0;
            this.textBoxPlec.Text = "Plec (Mezczyzna, Kobieta, Nie chce podawac";
            this.textBoxPlec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPlec.TextChanged += new System.EventHandler(this.textBoxUserName_TextChanged);
            this.textBoxPlec.Enter += new System.EventHandler(this.textBoxUserName_Enter);
            this.textBoxPlec.Leave += new System.EventHandler(this.textBoxUserName_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPassword.Location = new System.Drawing.Point(350, 364);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(235, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "Haslo";
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxEmail.Location = new System.Drawing.Point(62, 364);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(235, 20);
            this.textBoxEmail.TabIndex = 2;
            this.textBoxEmail.Text = "Email";
            this.textBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // textBox4
            // 
            this.textBox4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox4.Location = new System.Drawing.Point(62, 327);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(235, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Numer tel";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.Enter += new System.EventHandler(this.textBox4_Enter);
            this.textBox4.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Location = new System.Drawing.Point(253, 436);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(136, 54);
            this.buttonSignUp.TabIndex = 5;
            this.buttonSignUp.Text = "Zarejestruj";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // textBoxKodP
            // 
            this.textBoxKodP.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxKodP.Location = new System.Drawing.Point(350, 327);
            this.textBoxKodP.Name = "textBoxKodP";
            this.textBoxKodP.Size = new System.Drawing.Size(235, 20);
            this.textBoxKodP.TabIndex = 6;
            this.textBoxKodP.Text = "Kod Pocztowy XX-XXX";
            this.textBoxKodP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxKodP.Enter += new System.EventHandler(this.textBoxKodP_Enter);
            this.textBoxKodP.Leave += new System.EventHandler(this.textBoxKodP_Leave);
            // 
            // textBoxNrMieszkania
            // 
            this.textBoxNrMieszkania.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxNrMieszkania.Location = new System.Drawing.Point(350, 291);
            this.textBoxNrMieszkania.Name = "textBoxNrMieszkania";
            this.textBoxNrMieszkania.Size = new System.Drawing.Size(235, 20);
            this.textBoxNrMieszkania.TabIndex = 7;
            this.textBoxNrMieszkania.Text = "Nr Mieszkania";
            this.textBoxNrMieszkania.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNrMieszkania.Enter += new System.EventHandler(this.textBoxNrMieszkania_Enter);
            this.textBoxNrMieszkania.Leave += new System.EventHandler(this.textBoxNrMieszkania_Leave);
            // 
            // textBoxDataUr
            // 
            this.textBoxDataUr.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxDataUr.Location = new System.Drawing.Point(62, 259);
            this.textBoxDataUr.Name = "textBoxDataUr";
            this.textBoxDataUr.Size = new System.Drawing.Size(235, 20);
            this.textBoxDataUr.TabIndex = 8;
            this.textBoxDataUr.Text = "Data urodzenia d d - m m - r r r r";
            this.textBoxDataUr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDataUr.Enter += new System.EventHandler(this.textBoxDataUr_Enter);
            this.textBoxDataUr.Leave += new System.EventHandler(this.textBoxDataUr_Leave);
            // 
            // textBoxNrDomu
            // 
            this.textBoxNrDomu.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxNrDomu.Location = new System.Drawing.Point(350, 259);
            this.textBoxNrDomu.Name = "textBoxNrDomu";
            this.textBoxNrDomu.Size = new System.Drawing.Size(235, 20);
            this.textBoxNrDomu.TabIndex = 9;
            this.textBoxNrDomu.Text = "Nr domu";
            this.textBoxNrDomu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNrDomu.Enter += new System.EventHandler(this.textBoxNrDomu_Enter);
            this.textBoxNrDomu.Leave += new System.EventHandler(this.textBoxNrDomu_Leave);
            // 
            // textBoxUlica
            // 
            this.textBoxUlica.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxUlica.Location = new System.Drawing.Point(350, 223);
            this.textBoxUlica.Name = "textBoxUlica";
            this.textBoxUlica.Size = new System.Drawing.Size(235, 20);
            this.textBoxUlica.TabIndex = 11;
            this.textBoxUlica.Text = "Ulica";
            this.textBoxUlica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxUlica.Enter += new System.EventHandler(this.textBoxUlica_Enter);
            this.textBoxUlica.Leave += new System.EventHandler(this.textBoxUlica_Leave);
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxNazwisko.Location = new System.Drawing.Point(62, 223);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(235, 20);
            this.textBoxNazwisko.TabIndex = 12;
            this.textBoxNazwisko.Text = "Nazwisko";
            this.textBoxNazwisko.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNazwisko.Enter += new System.EventHandler(this.textBoxNazwisko_Enter);
            this.textBoxNazwisko.Leave += new System.EventHandler(this.textBoxNazwisko_Leave);
            // 
            // textBoxImie
            // 
            this.textBoxImie.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxImie.Location = new System.Drawing.Point(62, 191);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(235, 20);
            this.textBoxImie.TabIndex = 13;
            this.textBoxImie.Text = "Imie";
            this.textBoxImie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxImie.TextChanged += new System.EventHandler(this.textBoxImie_TextChanged);
            this.textBoxImie.Enter += new System.EventHandler(this.textBoxImie_Enter);
            this.textBoxImie.Leave += new System.EventHandler(this.textBoxImie_Leave);
            // 
            // textBoxMiasto
            // 
            this.textBoxMiasto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxMiasto.Location = new System.Drawing.Point(350, 191);
            this.textBoxMiasto.Name = "textBoxMiasto";
            this.textBoxMiasto.Size = new System.Drawing.Size(235, 20);
            this.textBoxMiasto.TabIndex = 14;
            this.textBoxMiasto.Text = "Miasto";
            this.textBoxMiasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMiasto.Enter += new System.EventHandler(this.textBoxMiasto_Enter);
            this.textBoxMiasto.Leave += new System.EventHandler(this.textBoxMiasto_Leave);
            // 
            // comboBoxWoj
            // 
            this.comboBoxWoj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWoj.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBoxWoj.FormattingEnabled = true;
            this.comboBoxWoj.Location = new System.Drawing.Point(275, 150);
            this.comboBoxWoj.Name = "comboBoxWoj";
            this.comboBoxWoj.Size = new System.Drawing.Size(98, 21);
            this.comboBoxWoj.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(286, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Wojewodztwo";
            // 
            // buttonPowrot
            // 
            this.buttonPowrot.Location = new System.Drawing.Point(62, 29);
            this.buttonPowrot.Name = "buttonPowrot";
            this.buttonPowrot.Size = new System.Drawing.Size(83, 29);
            this.buttonPowrot.TabIndex = 17;
            this.buttonPowrot.Text = "Powrot";
            this.buttonPowrot.UseVisualStyleBackColor = true;
            this.buttonPowrot.Click += new System.EventHandler(this.buttonPowrot_Click);
            // 
            // SignUpInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 549);
            this.Controls.Add(this.buttonPowrot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxWoj);
            this.Controls.Add(this.textBoxMiasto);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.textBoxUlica);
            this.Controls.Add(this.textBoxNrDomu);
            this.Controls.Add(this.textBoxDataUr);
            this.Controls.Add(this.textBoxNrMieszkania);
            this.Controls.Add(this.textBoxKodP);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxPlec);
            this.Name = "SignUpInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SignUpInterface";
            this.Load += new System.EventHandler(this.SignUpInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPlec;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.TextBox textBoxKodP;
        private System.Windows.Forms.TextBox textBoxNrMieszkania;
        private System.Windows.Forms.TextBox textBoxDataUr;
        private System.Windows.Forms.TextBox textBoxNrDomu;
        private System.Windows.Forms.TextBox textBoxUlica;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxMiasto;
        private System.Windows.Forms.ComboBox comboBoxWoj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPowrot;
    }
}