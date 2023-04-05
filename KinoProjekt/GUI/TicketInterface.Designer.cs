namespace GUI
{
    partial class TicketInterface
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
            this.nazwaFilmuLabel = new System.Windows.Forms.Label();
            this.czasFilmuLabel = new System.Windows.Forms.Label();
            this.kupBiletButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.miejscaComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.AnulujButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nazwaFilmuLabel
            // 
            this.nazwaFilmuLabel.AutoSize = true;
            this.nazwaFilmuLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nazwaFilmuLabel.Location = new System.Drawing.Point(12, 9);
            this.nazwaFilmuLabel.Name = "nazwaFilmuLabel";
            this.nazwaFilmuLabel.Size = new System.Drawing.Size(164, 32);
            this.nazwaFilmuLabel.TabIndex = 0;
            this.nazwaFilmuLabel.Text = "Nazwa seansu";
            this.nazwaFilmuLabel.Click += new System.EventHandler(this.nazwaFilmuLabel_Click);
            // 
            // czasFilmuLabel
            // 
            this.czasFilmuLabel.AutoSize = true;
            this.czasFilmuLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.czasFilmuLabel.Location = new System.Drawing.Point(12, 52);
            this.czasFilmuLabel.Name = "czasFilmuLabel";
            this.czasFilmuLabel.Size = new System.Drawing.Size(42, 21);
            this.czasFilmuLabel.TabIndex = 1;
            this.czasFilmuLabel.Text = "Czas";
            // 
            // kupBiletButton
            // 
            this.kupBiletButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kupBiletButton.Location = new System.Drawing.Point(80, 262);
            this.kupBiletButton.Name = "kupBiletButton";
            this.kupBiletButton.Size = new System.Drawing.Size(150, 23);
            this.kupBiletButton.TabIndex = 6;
            this.kupBiletButton.Text = "Kup bilet";
            this.kupBiletButton.UseVisualStyleBackColor = true;
            this.kupBiletButton.Click += new System.EventHandler(this.kupBiletButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUI.Properties.Resources.Miejsca;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(309, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 306);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // miejscaComboBox
            // 
            this.miejscaComboBox.FormattingEnabled = true;
            this.miejscaComboBox.Location = new System.Drawing.Point(181, 171);
            this.miejscaComboBox.Name = "miejscaComboBox";
            this.miejscaComboBox.Size = new System.Drawing.Size(121, 23);
            this.miejscaComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wybierz dostęne miejsce z listy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cena: 23 zł";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Imię";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nazwisko";
            // 
            // imieTextBox
            // 
            this.imieTextBox.Location = new System.Drawing.Point(181, 112);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(121, 23);
            this.imieTextBox.TabIndex = 11;
            this.imieTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.Location = new System.Drawing.Point(181, 143);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(121, 23);
            this.nazwiskoTextBox.TabIndex = 12;
            // 
            // AnulujButton
            // 
            this.AnulujButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AnulujButton.Location = new System.Drawing.Point(80, 291);
            this.AnulujButton.Name = "AnulujButton";
            this.AnulujButton.Size = new System.Drawing.Size(150, 23);
            this.AnulujButton.TabIndex = 13;
            this.AnulujButton.Text = "Anuluj";
            this.AnulujButton.UseVisualStyleBackColor = true;
            this.AnulujButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TicketInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 338);
            this.Controls.Add(this.AnulujButton);
            this.Controls.Add(this.nazwiskoTextBox);
            this.Controls.Add(this.imieTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kupBiletButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.miejscaComboBox);
            this.Controls.Add(this.czasFilmuLabel);
            this.Controls.Add(this.nazwaFilmuLabel);
            this.Name = "TicketInterface";
            this.Text = "Zakup biletu";
            this.Load += new System.EventHandler(this.TicketInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nazwaFilmuLabel;
        private Label czasFilmuLabel;
        private Button kupBiletButton;
        private PictureBox pictureBox1;
        private ComboBox miejscaComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox imieTextBox;
        private TextBox nazwiskoTextBox;
        private Button AnulujButton;
    }
}