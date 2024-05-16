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
    public partial class Pogled : Form
    {
        public Pogled()
        {
            InitializeComponent();
        }

        private void Pogled_Load(object sender, EventArgs e)
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
                ItemsDataBase dtb = new ItemsDataBase();
                List<string> list = dtb.ReadItemsFromDatabaseMonitor();
                foreach (string item in list)
                {
                    listBox1.Items.Add(item);
                }
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Clear();
                ItemsDataBase dtb = new ItemsDataBase();
                List<string> list = dtb.ReadItemsFromDatabaseComputer();
                foreach (string item in list)
                {
                    listBox1.Items.Add(item);
                }
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                listBox1.Items.Clear();
                ItemsDataBase dtb = new ItemsDataBase();
                List<string> list = dtb.ReadItemsFromDatabaseSoftware();
                foreach (string item in list)
                {
                    listBox1.Items.Add(item);
                }
            }
            else if(comboBox1.SelectedIndex == 3)
            {
                listBox1.Items.Clear();
                ItemsDataBase dtb = new ItemsDataBase();
                List<string> list = dtb.ReadItemsFromDatabaseHardware();
                foreach (string item in list)
                {

                    listBox1.Items.Add(item);
                }
            }
        }
    }
}
