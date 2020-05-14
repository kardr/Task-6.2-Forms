using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_6._2_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] mass = new int[10];
            int count = 0;
            Random r = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = r.Next(1, 40);
                textBox1.Text += mass[i] + "   ";
            }

            for (int i = 0; i < mass.Length - 1; i++)
            {
                if (mass[i] < mass[i + 1]) count += 1;
            }
            textBox2.Text += count;
        }
    }
}
