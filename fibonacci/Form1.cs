using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //int[] fib = { };
        private void button1_Click(object sender, EventArgs e)
        {

            int i1 = Convert.ToInt32(textBox1.Text);
            int i2 = Convert.ToInt32(textBox2.Text);
            int num_it = Convert.ToInt32(textBox3.Text);

            int i3 = 0;      

            for (int i = 0; i <= num_it ; i++)
            {
                i3 = i1 + i2;
                i1 = i2;
                i2 = i3;
                listBox1.Items.Add(i3.ToString());
                
            }

            listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
            label1.Text = i3.ToString();
            i3 = 0;

        }
    }
}
