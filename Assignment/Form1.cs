using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tip Calculator Version 2.0\nAll rights reserved to Michael Sadek", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            double total, tip;
            int people;

            tip = Int32.Parse(numericUpDown1.Value.ToString());

            total = Double.Parse(textBox1.Text);

            people = Int32.Parse(numericUpDown2.Value.ToString());

            tip = tip * total / 100;

            total += tip;

            //currencies. US dollar is checked by default

            if (eurosToolStripMenuItem.Checked)
            {
                //1 euro=1.30 US dollar
                total = 1.30 * total;
                tip = 1.30 * tip;
            }
            else if (poundSterlingToolStripMenuItem.Checked)
            {
                //1 sterling =1.54 US dollar
                total = 1.54 * total;
                tip = 1.54 * tip;
            }
            else if (canadianDollarToolStripMenuItem.Checked)
            {
                //1 Canadian dollar= .99 US dollar
                total = 0.99 * total;
                tip = 0.99 * tip;
            }


            if (radioButton1.Checked)
            {
                //show calculated tip
                textBox2.Text = "$" + (tip / people).ToString("#.##");
                textBox3.Text = "$" + tip.ToString("#.##");
                //show calculated total
                textBox4.Text = "$" + (total / people).ToString("#.##");
                textBox5.Text = "$" + total.ToString("#.##");
            }
            else if (radioButton2.Checked)
            {
                textBox2.Text = "$" + Math.Round(tip / people);
                textBox3.Text = "$" + Math.Round(tip);

                textBox4.Text = "$" + (total / people).ToString("#.##");
                textBox5.Text = "$" + total.ToString("#.##");
            }
            else if (radioButton3.Checked)
            {
                textBox2.Text = "$" + (tip / people).ToString("#.##");
                textBox3.Text = "$" + tip.ToString("#.##");

                textBox4.Text = "$" + Math.Round(total / people);
                textBox5.Text = "$" + Math.Round(total);
            }


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eurosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canadianDollarToolStripMenuItem.Checked = false;
            uSDollarToolStripMenuItem.Checked = false;
            poundSterlingToolStripMenuItem.Checked = false;
        }

        private void uSDollarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canadianDollarToolStripMenuItem.Checked = false;
            poundSterlingToolStripMenuItem.Checked = false;
            eurosToolStripMenuItem.Checked = false;
        }

        private void poundSterlingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eurosToolStripMenuItem.Checked = false;
            canadianDollarToolStripMenuItem.Checked = false;
            uSDollarToolStripMenuItem.Checked = false;
        }

        private void canadianDollarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            poundSterlingToolStripMenuItem.Checked = false;
            eurosToolStripMenuItem.Checked = false;
            uSDollarToolStripMenuItem.Checked = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}