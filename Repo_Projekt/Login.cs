using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; // polaczenie z baza danych MSAccess   

namespace KD
{
    public partial class Login : Form
    {
        private OleDbConnection polaczenie = new OleDbConnection(); // deklaracja zmiennej jako globalnej 

        public Login()
        {
            InitializeComponent();
            polaczenie.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Wiedza\KD_projekt\KD_new.accdb; Persist Security Info = False;";  // polaczenie z baza danych
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            timer1.Start();                                         // timer
            lb_data.Text = DateTime.Now.ToLongDateString();         // aktualna data w etykiecie
            lb_godz.Text = DateTime.Now.ToLongTimeString();         // aktualna godzina w etykiecie
            btn_Login.Enabled = false;

            try
            {
                polaczenie.Open(); // otworzenia polaczenia z baza danych

                spr_Polaczenia.Text = "Połączenie zakończyło się sukcesem!!"; // etykieta z tekstem o udanym polączeniu

                polaczenie.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd " + ex);
            }

        }

        private void Login_Click(object sender, EventArgs e)   // przycik Login
        {
            
            polaczenie.Open(); // otworzenia polaczenia z baza danych
            OleDbCommand komenda = new OleDbCommand();
            komenda.Connection = polaczenie;
            komenda.CommandText = "select Login, Haslo from Loginy  Where Login = '" + txt_Nazwa_Użytkownika.Text + "' and Haslo='" + txt_Hasło.Text + "'";  // za pomocą kwerenty przeszukuje baze danych w tabeli Loginy takie co sa zgodne z wpisami w BD

            OleDbDataReader czytaj = komenda.ExecuteReader();

            int licz = 0;
            while  (czytaj.Read())
            {
                licz = licz + 1;
            }
                 if (licz == 1)
            {
                MessageBox.Show("Nazwa użytkownika i hasło są prawidłowe");
                polaczenie.Close();
                polaczenie.Dispose();   // uwolni wszystkie zasoby uzywane przez komponenty
                this.Hide();            // ukryje okno Logowania
                KD_Menu m1 = new KD_Menu(); // tworzymy obiekt m1 dla klasy KD_Menu
                m1.ShowDialog(); // otwiera okno dialogowe KD_Menu


            }
             else  if (licz > 1)
            {
                MessageBox.Show("Użytkownik o takim loginie jest już zalogowany");
            }
                else
            {
                MessageBox.Show("Login i hasło niepoprawne!");
            }
            

            polaczenie.Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult zapytanie = MessageBox.Show("Czy chcesz wyłączyć program ?",
               "Wyjście", MessageBoxButtons.YesNo);
            if (zapytanie == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (zapytanie == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_godz.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void txt_Nazwa_Użytkownika_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_Nazwa_Użytkownika.Text))
            {
                btn_Login.Enabled = false;
            }
            else
            {
                btn_Login.Enabled = true;
            }
        }

    
    }
}


