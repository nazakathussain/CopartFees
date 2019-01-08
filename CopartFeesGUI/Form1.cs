using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopartFeesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.BuyingFees(Convert.ToInt32(textBox1.Text));
            Program.transportcost(comboBox1.Text);
            double calc = Program.BuyingFees(Convert.ToInt32(textBox1.Text)) + 
                Program.transportcost(comboBox1.SelectedItem.ToString()) + 
                10 + 
                (Convert.ToInt32(textBox1.Text));
            textBox2.Text = calc.ToString();
        }
    }
    }

