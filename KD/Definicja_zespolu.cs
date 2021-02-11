using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KD
{
    public partial class Definicja_zespolu : Form
    {
        public Definicja_zespolu()
        {
            InitializeComponent();
          
        }

       

        private void but_dodaj_pracowanika_Click(object sender, EventArgs e)
        {
            if (lista_prac1.SelectedIndex == -1)       // gdy nie zaznaczymy żadnego elementu
            {
                MessageBox.Show("Prosze wybrać element z listy");
            }
            else
            {
                if (lista_prac2.Items.Contains(lista_prac1.SelectedItem.ToString()))
                {
                    MessageBox.Show("Wybrany elemnt już isnieje! Proszę wybrać inny.");
                }
                else
                    lista_prac2.Items.Add(lista_prac1.SelectedItem);   // dodaje zaznaczony element z listy2 do listy1
            }
        }




        private void but_usun_praco_Click(object sender, EventArgs e)
        {
            if (lista_prac2.SelectedIndex == -1)       // gdy nie zaznaczymy żadnego elementu
            {
                MessageBox.Show("Prosze wybrać element z listy");
            }
            else
            {
                lista_prac2.Items.RemoveAt(lista_prac2.Items.IndexOf(lista_prac2.SelectedItems[0]));   // usuwa z listy2 zaznaczone elementy
            }
        }

        private void but_zapisz_zesp_Click(object sender, EventArgs e)
        {
          //  Awaria zes = new Awaria(lb_zespol.Items);
          //  zes.Show();
           // this.Hide();
        }

        private void but_wyczysc_Click(object sender, EventArgs e)
        {
            lista_prac2.Items.Clear();
        }
    }
}
