using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Items;
using System.Globalization;

namespace inventura_hrastnik
{
    public partial class Vnesi : Form
    {
        public Vnesi()
        {
            InitializeComponent();
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
        }

        private void Vnesi_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
                groupBox3.Enabled = false;
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = true;
            }
        }
        string ime;
        int cena;
        float rateza;
        float moteza;
        int stjedr;
        int kolkpolm;
        int hdd;
        int mb;
        string licenca;
        string res;

        string tip;

        private void nazaj_btn_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void vstavi_btn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                ime = textBox1.Text.ToString();
                cena = int.Parse(textBox3.Text);
                mb = int.Parse(textBox12.Text);
                licenca = textBox11.Text.ToString();
                // it = new Software(ime,cena,licenca, mb, verzija);
                ItemsDataBase d = new ItemsDataBase();
                d.SaveintoSoftware(ime, cena, licenca, mb);
                MessageBox.Show("vpisano");
                Console.WriteLine("sorftware"+ ime+cena+licenca);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                ime = textBox1.Text.ToString();
                cena = int.Parse(textBox3.Text);
                rateza = float.Parse(textBox4.Text);
                stjedr = int.Parse(textBox5.Text);
                kolkpolm = int.Parse(textBox6.Text);
                hdd = int.Parse(textBox7.Text);
                //it = new Computer(ime, cena, rateza, stjedr, kolkpolm, hdd);
                ItemsDataBase d = new ItemsDataBase();
                d.SaveintoComputer(ime, cena, rateza, stjedr, kolkpolm, hdd);
                MessageBox.Show("vpisano");
                Console.WriteLine("računalnik"+ ime+ cena+rateza+stjedr+kolkpolm+hdd);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                ime = textBox1.Text.ToString();
                cena = int.Parse(textBox3.Text);
                moteza = float.Parse(textBox8.Text);
                res = textBox9.Text.ToString();
                tip = textBox10.Text.ToString();
                // it = new Monitor(ime, cena, moteza, res, tip);
                ItemsDataBase d = new ItemsDataBase();
                d.SaveintoMonitor(ime, cena, moteza, res, tip);
                MessageBox.Show("vpisano");
                Console.WriteLine("monitor:" + ime + cena + moteza + res + tip);

            }
        }
    }
}
