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
    public partial class Izbriši : Form
    {
        public Izbriši()
        {
            InitializeComponent();
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        private void Izbriši_Load(object sender, EventArgs e)
        {

        }

        private void nazaj_btn_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Clear();

                ItemsDataBase idb = new ItemsDataBase();

                List<string> items = idb.ReadItemsFromDatabaseMonitor();

                foreach (string item in items)
                {
                    listBox1.Items.Add(item);
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Clear();

                ItemsDataBase idb = new ItemsDataBase();
                List<string> items = idb.ReadItemsFromDatabaseComputer();
                foreach (string item in items)
                {
                    listBox1.Items.Add(item);
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                listBox1.Items.Clear();

                ItemsDataBase idb = new ItemsDataBase();
                List<string> items = idb.ReadItemsFromDatabaseSoftware();
                foreach (string item in items)
                {
                    listBox1.Items.Add(item);
                }
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                listBox1.Items.Clear();

                ItemsDataBase idb = new ItemsDataBase();
                List<string> items = idb.ReadItemsFromDatabaseHardware();
                foreach (string item in items)
                {
                    listBox1.Items.Add(item);
                }
            }
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
                    label1.Text = parts[1];
                }
                else if (parts.Length == 4)
                {
                    label1.Text = parts[1];
                }
                else if (parts.Length == 5)
                {
                    label1.Text = parts[1];

                }
                else if (parts.Length == 6)
                {
                    label1.Text = parts[1];
                }
            }
        }

        private void izbris_btn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                ItemsDataBase idb = new ItemsDataBase();
                idb.DeliteMonitor(int.Parse(label1.Text));
                Console.WriteLine(label1.Text);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                ItemsDataBase idb = new ItemsDataBase();
                idb.DeliteComputer(int.Parse(label1.Text));
                Console.WriteLine(label1.Text);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                ItemsDataBase idb = new ItemsDataBase();
                idb.DeliteSoftware(int.Parse(label1.Text));
                Console.WriteLine(label1.Text);
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                ItemsDataBase idb = new ItemsDataBase();
                idb.DeliteHardware(int.Parse(label1.Text));
                Console.WriteLine(label1.Text);
            }
        }
    }
}
