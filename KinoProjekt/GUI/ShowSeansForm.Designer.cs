namespace GUI
{
    partial class ShowSeansForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDlugosc = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelOpis = new System.Windows.Forms.Label();
            this.labelTytul = new System.Windows.Forms.Label();
            this.buttonNastepny = new System.Windows.Forms.Button();
            this.buttonPoprzedni = new System.Windows.Forms.Button();
            this.ButtonOpcje = new System.Windows.Forms.Button();
            this.ButtonWyloguj = new System.Windows.Forms.Button();
            this.kupBiletButton = new System.Windows.Forms.Button();
            this.textBoxNazwa = new System.Windows.Forms.TextBox();
            this.buttonFiltr = new System.Windows.Forms.Button();
            this.labelOcena = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(509, 220);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 23);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(10, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 162);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "1";
            // 
            // labelDlugosc
            // 
            this.labelDlugosc.AutoSize = true;
            this.labelDlugosc.Location = new System.Drawing.Point(214, 165);
            this.labelDlugosc.Name = "labelDlugosc";
            this.labelDlugosc.Size = new System.Drawing.Size(50, 15);
            this.labelDlugosc.TabIndex = 29;
            this.labelDlugosc.Text = "Długość";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(214, 189);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(31, 15);
            this.labelData.TabIndex = 28;
            this.labelData.Text = "Data";
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.Location = new System.Drawing.Point(214, 67);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(31, 15);
            this.labelOpis.TabIndex = 27;
            this.labelOpis.Text = "Opis";
            // 
            // labelTytul
            // 
            this.labelTytul.AutoSize = true;
            this.labelTytul.Location = new System.Drawing.Point(214, 42);
            this.labelTytul.Name = "labelTytul";
            this.labelTytul.Size = new System.Drawing.Size(32, 15);
            this.labelTytul.TabIndex = 26;
            this.labelTytul.Text = "Tytuł";
            // 
            // buttonNastepny
            // 
            this.buttonNastepny.Location = new System.Drawing.Point(402, 263);
            this.buttonNastepny.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNastepny.Name = "buttonNastepny";
            this.buttonNastepny.Size = new System.Drawing.Size(82, 22);
            this.buttonNastepny.TabIndex = 25;
            this.buttonNastepny.Text = "->";
            this.buttonNastepny.UseVisualStyleBackColor = true;
            this.buttonNastepny.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonPoprzedni
            // 
            this.buttonPoprzedni.Location = new System.Drawing.Point(265, 263);
            this.buttonPoprzedni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPoprzedni.Name = "buttonPoprzedni";
            this.buttonPoprzedni.Size = new System.Drawing.Size(82, 22);
            this.buttonPoprzedni.TabIndex = 24;
            this.buttonPoprzedni.Text = "<-";
            this.buttonPoprzedni.UseVisualStyleBackColor = true;
            this.buttonPoprzedni.Click += new System.EventHandler(this.button3_Click);
            // 
            // ButtonOpcje
            // 
            this.ButtonOpcje.Location = new System.Drawing.Point(608, 11);
            this.ButtonOpcje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonOpcje.Name = "ButtonOpcje";
            this.ButtonOpcje.Size = new System.Drawing.Size(80, 22);
            this.ButtonOpcje.TabIndex = 23;
            this.ButtonOpcje.Text = "Opcje";
            this.ButtonOpcje.UseVisualStyleBackColor = true;
            this.ButtonOpcje.Click += new System.EventHandler(this.button2_Click);
            // 
            // ButtonWyloguj
            // 
            this.ButtonWyloguj.Location = new System.Drawing.Point(10, 9);
            this.ButtonWyloguj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonWyloguj.Name = "ButtonWyloguj";
            this.ButtonWyloguj.Size = new System.Drawing.Size(82, 22);
            this.ButtonWyloguj.TabIndex = 22;
            this.ButtonWyloguj.Text = "Wyloguj";
            this.ButtonWyloguj.UseVisualStyleBackColor = true;
            this.ButtonWyloguj.Click += new System.EventHandler(this.button1_Click);
            // 
            // kupBiletButton
            // 
            this.kupBiletButton.Location = new System.Drawing.Point(265, 220);
            this.kupBiletButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kupBiletButton.Name = "kupBiletButton";
            this.kupBiletButton.Size = new System.Drawing.Size(219, 22);
            this.kupBiletButton.TabIndex = 34;
            this.kupBiletButton.Text = "Kup Bilet";
            this.kupBiletButton.UseVisualStyleBackColor = true;
            this.kupBiletButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBoxNazwa
            // 
            this.textBoxNazwa.Location = new System.Drawing.Point(509, 262);
            this.textBoxNazwa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNazwa.Name = "textBoxNazwa";
            this.textBoxNazwa.PlaceholderText = "Wpisz Nazwę Filmu";
            this.textBoxNazwa.Size = new System.Drawing.Size(179, 23);
            this.textBoxNazwa.TabIndex = 35;
            this.textBoxNazwa.Text = "wpisz nazwę filmu:)\r\n";
            this.textBoxNazwa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNazwa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonFiltr
            // 
            this.buttonFiltr.Location = new System.Drawing.Point(560, 297);
            this.buttonFiltr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFiltr.Name = "buttonFiltr";
            this.buttonFiltr.Size = new System.Drawing.Size(82, 22);
            this.buttonFiltr.TabIndex = 36;
            this.buttonFiltr.Text = "filtruj";
            this.buttonFiltr.UseVisualStyleBackColor = true;
            this.buttonFiltr.Click += new System.EventHandler(this.buttonFiltr_Click);
            // 
            // labelOcena
            // 
            this.labelOcena.AutoSize = true;
            this.labelOcena.Location = new System.Drawing.Point(72, 220);
            this.labelOcena.Name = "labelOcena";
            this.labelOcena.Size = new System.Drawing.Size(41, 15);
            this.labelOcena.TabIndex = 37;
            this.labelOcena.Text = "Ocena";
            // 
            // ShowSeansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.labelOcena);
            this.Controls.Add(this.buttonFiltr);
            this.Controls.Add(this.textBoxNazwa);
            this.Controls.Add(this.kupBiletButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelDlugosc);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelOpis);
            this.Controls.Add(this.labelTytul);
            this.Controls.Add(this.buttonNastepny);
            this.Controls.Add(this.buttonPoprzedni);
            this.Controls.Add(this.ButtonOpcje);
            this.Controls.Add(this.ButtonWyloguj);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ShowSeansForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowSeansForm";
            this.Load += new System.EventHandler(this.ShowSeansForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
        private Label label5;
        private Label labelDlugosc;
        private Label labelData;
        private Label labelOpis;
        private Label labelTytul;
        private Button buttonNastepny;
        private Button buttonPoprzedni;
        private Button ButtonOpcje;
        private Button ButtonWyloguj;
        private Button kupBiletButton;
        private TextBox textBoxNazwa;
        private Button buttonFiltr;
        private Label labelOcena;
    }
}