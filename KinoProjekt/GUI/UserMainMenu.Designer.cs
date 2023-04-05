namespace GUI
{
    partial class UserMainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonPowrot = new System.Windows.Forms.Button();
            this.label_user_name = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tutaj znajduje się menu głowne dla klienta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Z tego miejsca bedzie mozna przejsc do poszczegolnych opcji";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kupic bilety zmienic haslo zmienic dane itp.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Zmień dane osobowe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(584, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Zmień hasło";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonPowrot
            // 
            this.buttonPowrot.Location = new System.Drawing.Point(584, 294);
            this.buttonPowrot.Name = "buttonPowrot";
            this.buttonPowrot.Size = new System.Drawing.Size(204, 45);
            this.buttonPowrot.TabIndex = 5;
            this.buttonPowrot.Text = "Przeglądaj Seanse";
            this.buttonPowrot.UseVisualStyleBackColor = true;
            this.buttonPowrot.Click += new System.EventHandler(this.buttonPowrot_Click);
            // 
            // label_user_name
            // 
            this.label_user_name.AutoSize = true;
            this.label_user_name.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_user_name.Location = new System.Drawing.Point(12, 9);
            this.label_user_name.Name = "label_user_name";
            this.label_user_name.Size = new System.Drawing.Size(0, 32);
            this.label_user_name.TabIndex = 6;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(12, 50);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(0, 15);
            this.label_email.TabIndex = 7;
            // 
            // UserMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_user_name);
            this.Controls.Add(this.buttonPowrot);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserMainMenu";
            this.Load += new System.EventHandler(this.UserMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button buttonPowrot;
        private Label label_user_name;
        private Label label_email;
    }
}