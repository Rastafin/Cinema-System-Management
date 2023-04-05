namespace LoginInterface
{
    partial class LoginInterface
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxHaslo = new System.Windows.Forms.TextBox();
            this.buttonZaloguj = new System.Windows.Forms.Button();
            this.buttonZarejestruj = new System.Windows.Forms.Button();
            this.buttonPrzypomnijHaslo = new System.Windows.Forms.Button();
            this.button_add_session = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxEmail.Location = new System.Drawing.Point(169, 167);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(251, 23);
            this.textBoxEmail.TabIndex = 0;
            this.textBoxEmail.Text = "Email";
            this.textBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxEmail_MouseClick);
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // textBoxHaslo
            // 
            this.textBoxHaslo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxHaslo.Location = new System.Drawing.Point(169, 215);
            this.textBoxHaslo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxHaslo.Name = "textBoxHaslo";
            this.textBoxHaslo.Size = new System.Drawing.Size(251, 23);
            this.textBoxHaslo.TabIndex = 1;
            this.textBoxHaslo.Text = "Haslo";
            this.textBoxHaslo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHaslo.Enter += new System.EventHandler(this.textBoxHaslo_Enter);
            this.textBoxHaslo.Leave += new System.EventHandler(this.textBoxHaslo_Leave);
            // 
            // buttonZaloguj
            // 
            this.buttonZaloguj.Location = new System.Drawing.Point(212, 279);
            this.buttonZaloguj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonZaloguj.Name = "buttonZaloguj";
            this.buttonZaloguj.Size = new System.Drawing.Size(154, 27);
            this.buttonZaloguj.TabIndex = 2;
            this.buttonZaloguj.Text = "Zaloguj";
            this.buttonZaloguj.UseVisualStyleBackColor = true;
            this.buttonZaloguj.Click += new System.EventHandler(this.buttonZaloguj_Click);
            // 
            // buttonZarejestruj
            // 
            this.buttonZarejestruj.Location = new System.Drawing.Point(212, 313);
            this.buttonZarejestruj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonZarejestruj.Name = "buttonZarejestruj";
            this.buttonZarejestruj.Size = new System.Drawing.Size(154, 27);
            this.buttonZarejestruj.TabIndex = 3;
            this.buttonZarejestruj.Text = "Zarejestruj";
            this.buttonZarejestruj.UseVisualStyleBackColor = true;
            this.buttonZarejestruj.Click += new System.EventHandler(this.buttonZarejestruj_Click);
            // 
            // buttonPrzypomnijHaslo
            // 
            this.buttonPrzypomnijHaslo.Location = new System.Drawing.Point(212, 346);
            this.buttonPrzypomnijHaslo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPrzypomnijHaslo.Name = "buttonPrzypomnijHaslo";
            this.buttonPrzypomnijHaslo.Size = new System.Drawing.Size(154, 27);
            this.buttonPrzypomnijHaslo.TabIndex = 4;
            this.buttonPrzypomnijHaslo.Text = "Przypomnij haslo";
            this.buttonPrzypomnijHaslo.UseVisualStyleBackColor = true;
            this.buttonPrzypomnijHaslo.Click += new System.EventHandler(this.buttonPrzypomnijHaslo_Click);
            // 
            // button_add_session
            // 
            this.button_add_session.Location = new System.Drawing.Point(461, 505);
            this.button_add_session.Name = "button_add_session";
            this.button_add_session.Size = new System.Drawing.Size(115, 42);
            this.button_add_session.TabIndex = 5;
            this.button_add_session.Text = "Zaloguj pracownik";
            this.button_add_session.UseVisualStyleBackColor = true;
            this.button_add_session.Click += new System.EventHandler(this.button_add_session_Click);
            // 
            // LoginInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 553);
            this.Controls.Add(this.button_add_session);
            this.Controls.Add(this.buttonPrzypomnijHaslo);
            this.Controls.Add(this.buttonZarejestruj);
            this.Controls.Add(this.buttonZaloguj);
            this.Controls.Add(this.textBoxHaslo);
            this.Controls.Add(this.textBoxEmail);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LoginInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxHaslo;
        private System.Windows.Forms.Button buttonZaloguj;
        private System.Windows.Forms.Button buttonZarejestruj;
        private System.Windows.Forms.Button buttonPrzypomnijHaslo;
        private Button button_add_session;
    }
}

