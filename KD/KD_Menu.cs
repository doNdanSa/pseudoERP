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
    public partial class KD_Menu : Form
    {
        public KD_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Awaria a1 = new Awaria();
            a1.ShowDialog();
        }

       
    }
} 
