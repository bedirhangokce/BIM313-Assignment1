using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2 {
    public partial class MainForm : Form {
        
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

            if (comboBox1.Text == "Circle") {
                Radius.Show(); RadiusTextBox.Show();
                Edge1TextBox.Hide(); Edge2TextBox.Hide();
                Edge1.Hide(); Edge2.Hide();
            }
            if (comboBox1.Text == "Rectangle") {
                Edge1.Show(); Edge2.Show(); 
                Edge1TextBox.Show(); Edge2TextBox.Show();
                Radius.Hide(); RadiusTextBox.Hide();
            }

            if (comboBox1.Text =="Select") {
                Radius.Hide(); RadiusTextBox.Hide();
                Edge1TextBox.Hide(); Edge2TextBox.Hide();
                Edge1.Hide(); Edge2.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                if (comboBox1.Text == "Circle") {
                    this.Hide();
                    CircleForm cf = new CircleForm((int.Parse(RadiusTextBox.Text) * 2) + 10);
                    cf.Closed += (s, args) => this.Close();
                    cf.Show();
                }
                if (comboBox1.Text == "Rectangle") {
                    this.Hide();
                    RectangleForm rf = new RectangleForm(int.Parse(Edge1TextBox.Text), int.Parse(Edge2TextBox.Text));
                    rf.Closed += (s, args) => this.Close();
                    rf.Show();
                }
            }
            catch (FormatException exception) {
                MessageBox.Show(exception.Message);
                this.Show();
            }
        }
    }
}