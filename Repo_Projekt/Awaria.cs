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
    public partial class Awaria : Form
    {
        private OleDbConnection polaczenie = new OleDbConnection(); // deklaracja zmiennej jako globalnej 
   

        public Awaria()  // ListBox.ObjectCollection Items
        {
            InitializeComponent();
            polaczenie.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Wiedza\KD_projekt\KD_new.accdb; Persist Security Info = False;";  // polaczenie z baza danych
           //  lb_zespol.Items.AddRange(items);

        }

        string wyl_odb;
        string ilosc_wyla_odb;
        string data_wyl;
        string data_wl;
        string sprawca;
        string imie_sprawcy;
        string nazwisko_sprawcy;
        string adres_sprawcy;
        string PESEL_sprawcy;
        string uwagi_spr;
        string nazwa_firn_spr;
        string NIP;

        private void btn_Zapisz_Click(object sender, EventArgs e)
        {
            

            if (txtImie.Text == "" || txtNazwisko.Text == "" || combo_grupa_awarii.Text == "" || comboAwaria.Text == "" || combo_miejsc_awarii.Text == "" || teres_zgl.Text == "")
                {
                   
                    MessageBox.Show("Pola żółte są wymagane! Proszę uzupełnić pola.");
                }
                else
                {
                    
                try
                {

                    polaczenie.Open(); // otworzenia polaczenia z baza danych
                    OleDbCommand komenda = new OleDbCommand();
                    komenda.Connection = polaczenie;
                    komenda.CommandText = "insert into Zgloszenie (Imie,Nazwisko,Forma_zgloszenia,Telefon,Typ_zgloszenia,Miejscowosc,Ulica,Nr_domu,Nr_lokalu,Nr_dzialki,Tresc_zgloszenia,DG_zgloszenia,DG_prealizacji) " +
                        "values('" + txtImie.Text + "','" + txtNazwisko.Text + "','" + comboFZ.Text + "','" + txtTel.Text + "', '" + comboTZ.Text + "',  '" + combo_miejsc.Text + "', '" + tb_ulica.Text + "','" + txt_nr_domu.Text + "', " +
                        "'" + txt_nr_lokalu.Text + "', '" + txt_nr_dzialki.Text + "','" + teres_zgl.Text + "', '" + dateTimePicker1.Text + "', '" + dateTimePicker2.Text + "')";

                    komenda.CommandText = "insert into Informacja_o_awarii (Grupa_awarii,Awaria,Cisnienie,Mat_gazociagu,Srednica,Awaria_miejscowosc,Awaria_Ulica," +
                        " Awaria_nr_domu,Awaria_nr_lokalu,Awaria_nr_dzialki,Szczg_inf_lokalizacji,Stacja)" +
                        " values ('" + combo_grupa_awarii.Text + "', '" + comboAwaria.Text + "','" + combo_cisnienie.Text + "', '" + combo_Mat.Text + "', '" + combo_srednica.Text + "', " +
                        "'" + combo_miejsc_awarii.Text + "', '" + text_ulica_awarii.Text + "', '" + text_nr_domu_awarii.Text + "', '" + text_nr_lokalu_awraii.Text + "', '" + text_nr_dzialki_awarii.Text + "', '" + text_szczeg_inf.Text + "', '" + lista_stacje2.SelectedItems.ToString() + "')";

                    /*    komenda.CommandText = "insert into Info_wykonane_prace (Wyl_odb,Ilosc_wyl_odbiorcow,Data_wylaczenia,Data_wlaczenia) values('" + wyl_odb + "','" + txt_wylaczenia.Text + "','" + dateTimePicker5.Text+ "','" + dateTimePicker6.Text + "')";

                        komenda.CommandText = "insert into Sprawca(Typ_sprawcy,Imie,Nazwisko,Nazwa_firmy,Adres,NIP,PESEL,Uwagi) values('" + sprawca + "','" + text_Imie.Text + "','" + text_nazwisko.Text + "','" + text_nazwa_firmy.Text + "'" +
                            ",'" + text_aders_sprawcy.Text + "','" + text_NIP.Text + "','" + text_PESEL.Text + "','" + text_uwagi.Text + "')";

                    */
                    komenda.ExecuteNonQuery();  // insert, delet, update dane w BD
                    MessageBox.Show("Zapisano dane");
                    polaczenie.Close();
                }

            catch (Exception ex)
                       {
                MessageBox.Show("Błąd " + ex);
                     }
             }
        
            
                
        }

        private void Awaria_Load(object sender, EventArgs e)     // 
        {
            timer1.Start();                                         // timer
            lb_data1.Text = DateTime.Now.ToLongDateString();         // aktualna data w etykiecie
            lb_godz1.Text = DateTime.Now.ToLongTimeString();         // aktualna godzina w etykiecie


            try
            {

                polaczenie.Open(); // otworzenia polaczenia z baza danych
                OleDbCommand komenda = new OleDbCommand(); // obiekt
                komenda.Connection = polaczenie;
                string kwerenda = "select Miejscowosc from Miejscowosc";// zmienna

                komenda.CommandText = kwerenda;

                OleDbDataReader czytaj = komenda.ExecuteReader(); // czyta dane z bazy danych

                while (czytaj.Read())  // czytaj baze danych do momenty true
                {
                    combo_miejsc.Items.Add(czytaj["Miejscowosc"].ToString());
                }

                polaczenie.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd " + ex);
            }

            try
            {

                polaczenie.Open(); // otworzenia polaczenia z baza danych
                OleDbCommand komenda2 = new OleDbCommand(); // obiekt
                komenda2.Connection = polaczenie;
                string kwerenda2 = "select Miejscowosc from Miejscowosc";// zmienna

                komenda2.CommandText = kwerenda2;

                OleDbDataReader czytaj = komenda2.ExecuteReader(); // czyta dane z bazy danych

                while (czytaj.Read())  // czytaj baze danych do momenty true
                {
                    combo_miejsc_awarii.Items.Add(czytaj["Miejscowosc"].ToString());
                }

                polaczenie.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd " + ex);
            }
        }
        
        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
            
            if (radio_Wy_tak.Checked == true)
            {
                wyl_odb = "Tak";
                txt_wylaczenia.Enabled = true;
                dateTimePicker5.Enabled = true;
                dateTimePicker6.Enabled = true;
                ilosc_wyla_odb = txt_wylaczenia.Text;
                data_wyl = dateTimePicker5.Text;
                data_wl = dateTimePicker6.Text;

            }

            if (radio_Wy_tak.Checked == false)
            {
                txt_wylaczenia.Enabled = false;
                dateTimePicker5.Enabled = false;
                dateTimePicker6.Enabled = false;
                ilosc_wyla_odb = null;
                data_wyl = null;
                data_wl = null;
            }

        }

        private void radio_Wy_Nie_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_Wy_Nie.Checked == true)
            {
                wyl_odb = "Nie";
                txt_wylaczenia.Enabled = false;
                dateTimePicker5.Enabled = false;
                dateTimePicker6.Enabled = false;
                ilosc_wyla_odb = null;
                data_wyl = null;
                data_wl = null;
            }
        }

        private void but_dodaj_Click(object sender, EventArgs e)
        {
            if (lista_stacje1.SelectedIndex == -1)       // gdy nie zaznaczymy żadnego elementu
            {
                MessageBox.Show("Prosze wybrać element z listy");
            }
            else
            {
                    if (lista_stacje2.Items.Contains(lista_stacje1.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Wybrany elemnt już isnieje! Proszę wybrać inny.");
                    }
                    else
                        lista_stacje2.Items.Add(lista_stacje1.SelectedItem);   // dodaje zaznaczony element z listy2 do listy1
                    }

        }



        private void but_usun_Click(object sender, EventArgs e)
        {
            if (lista_stacje2.SelectedIndex == -1)       // gdy nie zaznaczymy żadnego elementu
            {
                MessageBox.Show("Prosze wybrać element z listy");
            }
            else
            {
                        
                lista_stacje2.Items.RemoveAt(lista_stacje2.Items.IndexOf(lista_stacje2.SelectedItems[0]));         // usuwa z listy2 zaznaczone elementy

            }
         

         }



            private void bt_def_zesp_Click(object sender, EventArgs e)
            {

                Definicja_zespolu a1 = new Definicja_zespolu();
                a1.ShowDialog();
            }

        private void radio_os_fizyczna_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_os_fizyczna.Checked == true)
            {
                sprawca = "Osoba fizyczna";
                text_Imie.Enabled = true;
                text_nazwisko.Enabled = true;
                text_aders_sprawcy.Enabled = true;
                text_PESEL.Enabled = true;
                text_uwagi.Enabled = true;
                imie_sprawcy = text_Imie.Text;
                nazwisko_sprawcy = text_nazwisko.Text;
                adres_sprawcy = text_aders_sprawcy.Text;
                PESEL_sprawcy = text_PESEL.Text;
                uwagi_spr = text_uwagi.Text;

            }
            if (radio_os_fizyczna.Checked == false)
            {
                text_Imie.Enabled = false;
                text_nazwisko.Enabled = false;
                text_aders_sprawcy.Enabled = false;
                text_PESEL.Enabled = false;
                text_uwagi.Enabled = false;
                imie_sprawcy = null;
                nazwisko_sprawcy = null;
                adres_sprawcy = null;
                PESEL_sprawcy = null;
                uwagi_spr = null;
            }
        }

        private void radio_os_prawna_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_os_prawna.Checked == true)
            {
                sprawca = "Osoba prawna";
                text_aders_sprawcy.Enabled = true;
                text_nazwa_firmy.Enabled = true;
                text_NIP.Enabled = true;
                text_uwagi.Enabled = true;
                adres_sprawcy = text_aders_sprawcy.Text;
                uwagi_spr = text_uwagi.Text;
                nazwa_firn_spr = text_nazwa_firmy.Text;
                NIP = text_NIP.Text;
            }
            if (radio_os_prawna.Checked == false)
            {
                text_aders_sprawcy.Enabled = false;
                text_nazwa_firmy.Enabled = false;
                text_NIP.Enabled = false;
                text_uwagi.Enabled = false;
                adres_sprawcy = null;
                uwagi_spr = null;
                nazwa_firn_spr = null;
                NIP = null;
            }
        }

        private void radio_inne_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_inne.Checked)
            {
                sprawca = "Inne";
                text_uwagi.Enabled = true;
                uwagi_spr = text_uwagi.Text;
            }
            if (radio_inne.Checked == false)
            {
                text_uwagi.Enabled = false;
                uwagi_spr = null;
            }
        }

        private void but_dodaj_poinf_Click(object sender, EventArgs e)
        {
            if (listbox_osoby.SelectedIndex == -1)       // gdy nie zaznaczymy żadnego elementu
            {
                MessageBox.Show("Prosze wybrać element z listy");
            }
            else
            {
                if (listbox_poinformowani.Items.Contains(listbox_osoby.SelectedItem.ToString()))
                {
                    MessageBox.Show("Wybrany elemnt już isnieje! Proszę wybrać inny.");
                }
                else
                    listbox_poinformowani.Items.Add(listbox_osoby.SelectedItem);   // dodaje zaznaczony element z listy2 do listy1
            }
        }

        private void but_usun_poinf_Click(object sender, EventArgs e)
        {
            if (listbox_poinformowani.SelectedIndex == -1)       // gdy nie zaznaczymy żadnego elementu
            {
                MessageBox.Show("Prosze wybrać element z listy");
            }
            else
            {

                listbox_poinformowani.Items.RemoveAt(listbox_poinformowani.Items.IndexOf(listbox_poinformowani.SelectedItems[0]));         // usuwa z listy2 zaznaczone elementy

            }
        }

        private void txtImie_Leave(object sender, EventArgs e)
        {
            if (txtImie.Text=="")
            {
                txtImie.BackColor = Color.Yellow;
            }
            else
            {
                txtImie.BackColor = Color.White;
            }
        }

        private void txtImie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtNazwisko_Leave(object sender, EventArgs e)
        {
            if (txtNazwisko.Text == "")
            {
                txtNazwisko.BackColor = Color.Yellow;
            }
            else
            {
                txtNazwisko.BackColor = Color.White;
            }
        }

        private void txtNazwisko_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void teres_zgl_Leave(object sender, EventArgs e)
        {
            if (teres_zgl.Text == "")
            {
                teres_zgl.BackColor = Color.Yellow;
            }
            else
            {
                teres_zgl.BackColor = Color.White;
            }
        }

        

        private void combo_grupa_awarii_Leave(object sender, EventArgs e)
        {
            if (combo_grupa_awarii.Text == "")
            {
                combo_grupa_awarii.BackColor = Color.Yellow;
            }
            else
            {
                combo_grupa_awarii.BackColor = Color.White;
            }
        }

        private void combo_grupa_awarii_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void comboAwaria_Leave(object sender, EventArgs e)
        {
            if (comboAwaria.Text == "")
            {
                comboAwaria.BackColor = Color.Yellow;
            }
            else
            {
                comboAwaria.BackColor = Color.White;
            }

        }

        private void comboAwaria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void combo_miejsc_awarii_Leave(object sender, EventArgs e)
        {
            if (combo_miejsc_awarii.Text == "")
            {
                combo_miejsc_awarii.BackColor = Color.Yellow;
            }
            else
            {
                combo_miejsc_awarii.BackColor = Color.White;
            }
        }

        private void combo_miejsc_awarii_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void Awaria_FormClosing(object sender, FormClosingEventArgs e) // zamknięcie aplikacji w debugerze
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

        private void but_wyczysc_poinf_Click(object sender, EventArgs e)
        {
            listbox_poinformowani.Items.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_godz1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
    
}
