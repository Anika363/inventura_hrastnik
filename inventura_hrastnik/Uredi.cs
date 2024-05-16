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

namespace inventura_hrastnik
{
    public partial class Uredi : Form
    {
        public Uredi()
        {
            InitializeComponent();
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        private void Uredi_Load(object sender, EventArgs e)
        {

        }

        private void nazaj_btn_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) // Check if an item is selected
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                // Split the selected item to extract ID and display in label1
                string[] parts = selectedItem.Split('|');
                if (parts.Length == 7)
                {
                    textBox1.Text = parts[0];
                    label8.Text = parts[1];
                    textBox2.Text = parts[2];
                    textBox3.Text = parts[3];
                    textBox5.Text = parts[4];
                    textBox6.Text = parts[5];
                    textBox7.Text = parts[6];

                }
               else if (parts.Length == 4)
                {
                    label8.Text = parts[1];
                    textBox1.Text = parts[0];
                    textBox2.Text = parts[2];
                    textBox3.Text = parts[3];
                }
                else if (parts.Length == 5)
                {
                    label8.Text = parts[1];
                    textBox1.Text = parts[0];
                    textBox2.Text = parts[2];
                    textBox10.Text = parts[3];
                    textBox11.Text = parts[4];
                }
                else if (parts.Length == 6)
                {
                    textBox1.Text=parts[0];
                    label8.Text=parts[1];
                    textBox2.Text =parts[2];
                    textBox3.Text=parts[3];
                    textBox8.Text =parts[4];
                    textBox9.Text=parts[5];

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                textBox8.ReadOnly = true;
                textBox9.ReadOnly = true;
                textBox10.ReadOnly = true;
                textBox11.ReadOnly = true;
                listBox1.Items.Clear();

                ItemsDataBase idb = new ItemsDataBase();
                List<string> items = idb.ReadItemsFromDatabaseComputer();
                foreach (string item in items)
                {
                    listBox1.Items.Add(item);
                }
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                textBox8.ReadOnly = false;
                textBox9.ReadOnly = false;
                textBox5.ReadOnly = true;
                textBox6.ReadOnly = true;
                textBox7.ReadOnly = true;
                textBox10.ReadOnly= true;
                textBox11.ReadOnly= true;
                listBox1.Items.Clear();

                ItemsDataBase idb = new ItemsDataBase();

                List<string> items = idb.ReadItemsFromDatabaseMonitor();

                foreach (string item in items)
                {
                    listBox1.Items.Add(item);
                }
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                textBox9.ReadOnly = false;
                textBox5.ReadOnly= true;
                textBox6.ReadOnly= true;
                textBox7.ReadOnly= true;
                textBox8.ReadOnly= true;
                textBox10.ReadOnly= true;
                textBox11.ReadOnly= true;
                listBox1.Items.Clear();

                ItemsDataBase idb = new ItemsDataBase();
                List<string> items = idb.ReadItemsFromDatabaseHardware();
                foreach (string item in items)
                {
                    listBox1.Items.Add(item);
                }
            }
            else if(comboBox1.SelectedIndex == 3)
            {
                textBox10.ReadOnly = false;
                textBox11.ReadOnly = false;
                textBox5.ReadOnly = true;
                textBox6.ReadOnly = true;
                textBox7.ReadOnly = true;
                textBox8.ReadOnly = true;
                textBox9.ReadOnly= true;
                listBox1.Items.Clear();

                ItemsDataBase idb = new ItemsDataBase();
                List<string> items = idb.ReadItemsFromDatabaseSoftware();
                foreach (string item in items)
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void uredi_btn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                int id = int.Parse(label8.Text);
                string ime = textBox1.Text;
                int cena = int.Parse(textBox2.Text);
                float teza = float.Parse(textBox3.Text);
                int stjedr = int.Parse(textBox5.Text);
                int  ram = int.Parse(textBox6.Text);
                int hdd = int.Parse(textBox7.Text);
                ItemsDataBase idb = new ItemsDataBase();
                idb.UpdateCmputer(id, ime, cena, teza, stjedr, ram, hdd);
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                int id = int.Parse(label8.Text);
                string ime = textBox1.Text;
                int cena = int.Parse(textBox2.Text);
                float teza = float.Parse(textBox3.Text);
                string res = textBox8.Text;
                string tip = textBox9.Text;
                ItemsDataBase idb = new ItemsDataBase();
                idb.UpdateMonitor(id, ime, cena, teza, res, tip);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                int id = int.Parse(label8.Text);
                string ime = textBox1.Text;
                int cena = int.Parse(textBox2.Text);
                float teza = float.Parse(textBox3.Text);
                ItemsDataBase idb = new ItemsDataBase();
                idb.UpdateHardware(id, ime, cena, teza);
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                int id = int.Parse(label8.Text);
                string ime = textBox1.Text;
                int cena = int.Parse(textBox2.Text);
                string kljuc = textBox10.Text;
                int mb = int.Parse(textBox11.Text);
                ItemsDataBase idb = new ItemsDataBase();
                idb.UpdateSoftware(id, ime, cena, kljuc, mb);
            }
        }
    }
}
