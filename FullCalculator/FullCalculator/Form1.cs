using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace FullCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<int> numbers = new List<int>();
        public List<string> symbols = new List<string>();
        public int counter = 0;
        public string num_str = "";

        private void button_0_Click(object sender, EventArgs e)
        { Count_numbers(0); }
        private void button_1_Click(object sender, EventArgs e)
        { Count_numbers(1); }
        private void button_2_Click(object sender, EventArgs e)
        { Count_numbers(2); }
        private void button_3_Click(object sender, EventArgs e)
        { Count_numbers(3); }
        private void button_4_Click(object sender, EventArgs e)
        { Count_numbers(4); }
        private void button_5_Click(object sender, EventArgs e)
        { Count_numbers(5); }
        private void button_6_Click(object sender, EventArgs e)
        { Count_numbers(6); }
        private void button_7_Click(object sender, EventArgs e)
        { Count_numbers(7); }
        private void button_8_Click(object sender, EventArgs e)
        { Count_numbers(8); }
        private void button_9_Click(object sender, EventArgs e)
        { Count_numbers(9); }

        public void Count_numbers(int num)
        {
            textBox1.Text += num.ToString();
            num_str += num.ToString();
            counter++;
        }

        private void button_plus_Click(object sender, EventArgs e)
        { Count_actions("+"); }
        private void button_minus_Click(object sender, EventArgs e)
        { Count_actions("-"); }
        private void button_multiply_Click(object sender, EventArgs e)
        { Count_actions("*"); }
        private void button_decompose_Click(object sender, EventArgs e)
        { Count_actions("/"); }

        public void Count_actions(string action)
        {
            if(num_str != null)
            {
                textBox1.Text += action;
                symbols.Add(action);
                numbers.Add(Convert.ToInt32(num_str));
                num_str = null;
                counter++;
            }
            else { MessageBox.Show("Не было задано число"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(numbers.Count > symbols.Count) 
            {
                numbers.RemoveAt(numbers.Count -1);
            }
            else
            {
                symbols.RemoveAt(symbols.Count - 1);
            }
        }
    }
}
