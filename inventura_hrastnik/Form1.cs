using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventura_hrastnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pregled_btn_Click(object sender, EventArgs e)
        {
            Pogled pr = new Pogled();
            pr.Show();
            this.Hide();
        }

        private void Dodaj_btn_Click(object sender, EventArgs e)
        {
            Vnesi vs = new Vnesi();
            vs.Show();
            this.Hide();
        }

        private void Izris_btn_Click(object sender, EventArgs e)
        {
            Izbriši br = new Izbriši();
            br.Show();
            this.Hide();
        }

        private void Uredi_btn_Click(object sender, EventArgs e)
        {
            Uredi ur = new Uredi();
            ur.Show();
            this.Hide();
        }
    }
}
