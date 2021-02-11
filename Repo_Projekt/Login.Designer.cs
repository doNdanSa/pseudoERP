namespace KD
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.spr_Polaczenia = new System.Windows.Forms.Label();
            this.Status_połaczenia = new System.Windows.Forms.GroupBox();
            this.Użytkownik = new System.Windows.Forms.Label();
            this.Hasło = new System.Windows.Forms.Label();
            this.txt_Nazwa_Użytkownika = new System.Windows.Forms.TextBox();
            this.txt_Hasło = new System.Windows.Forms.TextBox();
            this.Logowanie = new System.Windows.Forms.GroupBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Login_logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_data = new System.Windows.Forms.Label();
            this.lb_godz = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Status_połaczenia.SuspendLayout();
            this.Logowanie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // spr_Polaczenia
            // 
            this.spr_Polaczenia.AutoSize = true;
            this.spr_Polaczenia.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.spr_Polaczenia.Location = new System.Drawing.Point(20, 18);
            this.spr_Polaczenia.Name = "spr_Polaczenia";
            this.spr_Polaczenia.Size = new System.Drawing.Size(0, 13);
            this.spr_Polaczenia.TabIndex = 0;
            // 
            // Status_połaczenia
            // 
            this.Status_połaczenia.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Status_połaczenia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Status_połaczenia.Controls.Add(this.spr_Polaczenia);
            this.Status_połaczenia.Location = new System.Drawing.Point(44, 337);
            this.Status_połaczenia.Name = "Status_połaczenia";
            this.Status_połaczenia.Size = new System.Drawing.Size(272, 67);
            this.Status_połaczenia.TabIndex = 1;
            this.Status_połaczenia.TabStop = false;
            this.Status_połaczenia.Text = "Status Połączenia z BD";
            // 
            // Użytkownik
            // 
            this.Użytkownik.AutoSize = true;
            this.Użytkownik.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Użytkownik.Location = new System.Drawing.Point(19, 77);
            this.Użytkownik.Name = "Użytkownik";
            this.Użytkownik.Size = new System.Drawing.Size(168, 23);
            this.Użytkownik.TabIndex = 2;
            this.Użytkownik.Text = "Nazwa Użytkownika";
            // 
            // Hasło
            // 
            this.Hasło.AutoSize = true;
            this.Hasło.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Hasło.Location = new System.Drawing.Point(19, 113);
            this.Hasło.Name = "Hasło";
            this.Hasło.Size = new System.Drawing.Size(54, 23);
            this.Hasło.TabIndex = 3;
            this.Hasło.Text = "Hasło";
            // 
            // txt_Nazwa_Użytkownika
            // 
            this.txt_Nazwa_Użytkownika.Location = new System.Drawing.Point(210, 77);
            this.txt_Nazwa_Użytkownika.Name = "txt_Nazwa_Użytkownika";
            this.txt_Nazwa_Użytkownika.Size = new System.Drawing.Size(192, 30);
            this.txt_Nazwa_Użytkownika.TabIndex = 4;
            this.txt_Nazwa_Użytkownika.TextChanged += new System.EventHandler(this.txt_Nazwa_Użytkownika_TextChanged);
            // 
            // txt_Hasło
            // 
            this.txt_Hasło.Location = new System.Drawing.Point(210, 113);
            this.txt_Hasło.Name = "txt_Hasło";
            this.txt_Hasło.PasswordChar = '*';
            this.txt_Hasło.Size = new System.Drawing.Size(192, 30);
            this.txt_Hasło.TabIndex = 5;
            // 
            // Logowanie
            // 
            this.Logowanie.AutoSize = true;
            this.Logowanie.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Logowanie.Controls.Add(this.btn_Login);
            this.Logowanie.Controls.Add(this.txt_Hasło);
            this.Logowanie.Controls.Add(this.txt_Nazwa_Użytkownika);
            this.Logowanie.Controls.Add(this.Hasło);
            this.Logowanie.Controls.Add(this.Użytkownik);
            this.Logowanie.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logowanie.Location = new System.Drawing.Point(44, 33);
            this.Logowanie.Name = "Logowanie";
            this.Logowanie.Size = new System.Drawing.Size(424, 258);
            this.Logowanie.TabIndex = 6;
            this.Logowanie.TabStop = false;
            this.Logowanie.Text = "Logowanie";
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Login.Image = global::KD.Properties.Resources.Actions_dialog_ok_apply_icon1;
            this.btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Login.Location = new System.Drawing.Point(210, 167);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(127, 44);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "Zaloguj";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KD.Properties.Resources.Copyright_icon;
            this.pictureBox1.Location = new System.Drawing.Point(626, 378);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Login_logo
            // 
            this.Login_logo.Image = global::KD.Properties.Resources.pages_black_icon;
            this.Login_logo.Location = new System.Drawing.Point(617, 91);
            this.Login_logo.Name = "Login_logo";
            this.Login_logo.Size = new System.Drawing.Size(133, 140);
            this.Login_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Login_logo.TabIndex = 7;
            this.Login_logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(677, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kostrząb Krzysztof";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(678, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Daniel Kolasa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(678, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Jakub Świątek";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(670, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "All Rights Reserved";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(634, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "2018";
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Location = new System.Drawing.Point(604, 52);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(33, 13);
            this.lb_data.TabIndex = 14;
            this.lb_data.Text = "Data:";
            // 
            // lb_godz
            // 
            this.lb_godz.AutoSize = true;
            this.lb_godz.Location = new System.Drawing.Point(715, 52);
            this.lb_godz.Name = "lb_godz";
            this.lb_godz.Size = new System.Drawing.Size(35, 13);
            this.lb_godz.TabIndex = 15;
            this.lb_godz.Text = "Godz:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_godz);
            this.Controls.Add(this.lb_data);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login_logo);
            this.Controls.Add(this.Status_połaczenia);
            this.Controls.Add(this.Logowanie);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Książka Dyspozytora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.Status_połaczenia.ResumeLayout(false);
            this.Status_połaczenia.PerformLayout();
            this.Logowanie.ResumeLayout(false);
            this.Logowanie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label spr_Polaczenia;
        private System.Windows.Forms.GroupBox Status_połaczenia;
        private System.Windows.Forms.Label Użytkownik;
        private System.Windows.Forms.Label Hasło;
        private System.Windows.Forms.TextBox txt_Nazwa_Użytkownika;
        private System.Windows.Forms.TextBox txt_Hasło;
        private System.Windows.Forms.GroupBox Logowanie;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.PictureBox Login_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Label lb_godz;
        private System.Windows.Forms.Timer timer1;
    }
}

