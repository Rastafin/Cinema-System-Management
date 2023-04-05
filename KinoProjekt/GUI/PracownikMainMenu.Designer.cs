namespace GUI
{
    partial class PracownikMainMenu
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
            this.label_email = new System.Windows.Forms.Label();
            this.label_employee_name = new System.Windows.Forms.Label();
            this.button_change_password = new System.Windows.Forms.Button();
            this.button_change_data = new System.Windows.Forms.Button();
            this.label_stopien_uprawnienia = new System.Windows.Forms.Label();
            this.button_dodaj_seans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_email.Location = new System.Drawing.Point(12, 56);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(0, 17);
            this.label_email.TabIndex = 10;
            // 
            // label_employee_name
            // 
            this.label_employee_name.AutoSize = true;
            this.label_employee_name.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_employee_name.Location = new System.Drawing.Point(12, 9);
            this.label_employee_name.Name = "label_employee_name";
            this.label_employee_name.Size = new System.Drawing.Size(0, 37);
            this.label_employee_name.TabIndex = 9;
            // 
            // button_change_password
            // 
            this.button_change_password.Location = new System.Drawing.Point(584, 396);
            this.button_change_password.Name = "button_change_password";
            this.button_change_password.Size = new System.Drawing.Size(204, 42);
            this.button_change_password.TabIndex = 8;
            this.button_change_password.Text = "Zmień hasło";
            this.button_change_password.UseVisualStyleBackColor = true;
            // 
            // button_change_data
            // 
            this.button_change_data.Location = new System.Drawing.Point(584, 345);
            this.button_change_data.Name = "button_change_data";
            this.button_change_data.Size = new System.Drawing.Size(204, 45);
            this.button_change_data.TabIndex = 7;
            this.button_change_data.Text = "Zmień dane osobowe";
            this.button_change_data.UseVisualStyleBackColor = true;
            // 
            // label_stopien_uprawnienia
            // 
            this.label_stopien_uprawnienia.AutoSize = true;
            this.label_stopien_uprawnienia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_stopien_uprawnienia.Location = new System.Drawing.Point(12, 81);
            this.label_stopien_uprawnienia.Name = "label_stopien_uprawnienia";
            this.label_stopien_uprawnienia.Size = new System.Drawing.Size(0, 17);
            this.label_stopien_uprawnienia.TabIndex = 11;
            // 
            // button_dodaj_seans
            // 
            this.button_dodaj_seans.Location = new System.Drawing.Point(584, 277);
            this.button_dodaj_seans.Name = "button_dodaj_seans";
            this.button_dodaj_seans.Size = new System.Drawing.Size(204, 45);
            this.button_dodaj_seans.TabIndex = 12;
            this.button_dodaj_seans.Text = "Dodaj seans";
            this.button_dodaj_seans.UseVisualStyleBackColor = true;
            this.button_dodaj_seans.Click += new System.EventHandler(this.button_dodaj_seans_Click);
            // 
            // PracownikMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_dodaj_seans);
            this.Controls.Add(this.label_stopien_uprawnienia);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_employee_name);
            this.Controls.Add(this.button_change_password);
            this.Controls.Add(this.button_change_data);
            this.Name = "PracownikMainMenu";
            this.Text = "EmployeeMainMenu";
            this.Load += new System.EventHandler(this.EmployeeMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_email;
        private Label label_employee_name;
        private Button button_change_password;
        private Button button_change_data;
        private Label label_stopien_uprawnienia;
        private Button button_dodaj_seans;
    }
}