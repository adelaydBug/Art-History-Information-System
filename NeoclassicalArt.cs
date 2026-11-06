using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dsa.STACK.RVA
{
    public partial class NeoclassicalArt : Form
    {
        public NeoclassicalArt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main mainform = new Main();
            mainform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct! Neoclassical art was inspired by Ancient Greece and Rome.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect. Medieval Europe influenced Gothic, not Neoclassical art.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect. Abstract expressionism belongs to modern art, not Neoclassicism.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct! Neoclassical painting emphasized order, rationality, and classical ideals.");
        }
    }
}
