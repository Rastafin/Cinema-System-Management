namespace GUI
{
    partial class ChangePassword
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
            this.textBoxStareHaslo = new System.Windows.Forms.TextBox();
            this.textBoxNoweHaslo = new System.Windows.Forms.TextBox();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.buttonPowrot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxStareHaslo
            // 
            this.textBoxStareHaslo.Location = new System.Drawing.Point(67, 92);
            this.textBoxStareHaslo.Name = "textBoxStareHaslo";
            this.textBoxStareHaslo.PlaceholderText = "Stare hasło";
            this.textBoxStareHaslo.Size = new System.Drawing.Size(152, 23);
            this.textBoxStareHaslo.TabIndex = 0;
            this.textBoxStareHaslo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNoweHaslo
            // 
            this.textBoxNoweHaslo.Location = new System.Drawing.Point(67, 150);
            this.textBoxNoweHaslo.Name = "textBoxNoweHaslo";
            this.textBoxNoweHaslo.PlaceholderText = "Nowe hasło";
            this.textBoxNoweHaslo.Size = new System.Drawing.Size(152, 23);
            this.textBoxNoweHaslo.TabIndex = 1;
            this.textBoxNoweHaslo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(67, 216);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(152, 23);
            this.buttonZapisz.TabIndex = 2;
            this.buttonZapisz.Text = "Zapisz zmiany";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // buttonPowrot
            // 
            this.buttonPowrot.Location = new System.Drawing.Point(67, 245);
            this.buttonPowrot.Name = "buttonPowrot";
            this.buttonPowrot.Size = new System.Drawing.Size(152, 23);
            this.buttonPowrot.TabIndex = 3;
            this.buttonPowrot.Text = "Powrót";
            this.buttonPowrot.UseVisualStyleBackColor = true;
            this.buttonPowrot.Click += new System.EventHandler(this.buttonPowrot_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 379);
            this.Controls.Add(this.buttonPowrot);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.textBoxNoweHaslo);
            this.Controls.Add(this.textBoxStareHaslo);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxStareHaslo;
        private TextBox textBoxNoweHaslo;
        private Button buttonZapisz;
        private Button buttonPowrot;
    }
}