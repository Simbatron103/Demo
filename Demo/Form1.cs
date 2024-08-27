using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        List<string> thingList = new List<string>();    
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();  
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String newThing = textBox1.Text;
            thingList.Add(newThing);
            textBox1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            thingList.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Count: " + thingList.Count);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First: " + thingList[0]);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Last: " + thingList[thingList.Count - 1]);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int randomIndex = random.Next(thingList.Count);
            string randomThing = thingList[randomIndex];
            MessageBox.Show(randomThing);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int count = thingList.Count;
            textBox2.Text = "";
            for (int i = 0; i < count; i++)
            {
                textBox2.Text = textBox2.Text + " " + thingList[i].ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int count = thingList.Count;
            textBox2.Text = "";
            for (int i = 0; i < count; i++)
            {
                textBox2.Text = textBox2.Text + " " + thingList[i].ToString().ToUpper();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (thingList.Contains(textBox3.Text))
            {
                MessageBox.Show("Your list contains " + textBox3.Text);
            }
            else
            {
                MessageBox.Show("Your list contains doesn't " + textBox3.Text);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (thingList.Contains(textBox4.Text))
            {
                thingList.Remove(textBox4.Text);
                MessageBox.Show(textBox4.Text + " has been removed");
            }
            else
            {
                MessageBox.Show("Failed to find " + textBox4.Text);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            thingList.Sort();
            int count = thingList.Count;
            textBox2.Text = "";
            for (int i = 0; i < count; i++)
            {
                textBox2.Text = textBox2.Text + " " +thingList[i].ToString();
                
            }
        }
    }
}
