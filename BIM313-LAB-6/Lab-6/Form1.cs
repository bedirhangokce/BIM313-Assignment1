using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class Form1 : Form {
        private const string exception = "You have to select item";
        public Form1()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e) {
            listBox1.Items.Add(input.Text);
            input.Text = null;
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            try {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            catch (Exception) 
            {
                MessageBox.Show(exception);
            }
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            try {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            catch (Exception)
            {
                MessageBox.Show(exception);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
        }
    }
    
}
