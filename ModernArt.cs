using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dsa.STACK.RVA
{
    public partial class ModernArt : Form
    {
        public ModernArt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main mainForm = new Main();
            mainForm.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect. Gothic belongs to the Medieval period, not Modern art.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct! Cubism is a key movement of the Modern era.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect. Leonardo da Vinci was a Renaissance artist, not Modern.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct! Pablo Picasso is considered a pioneer of Modern art.");
        }
    }
}
