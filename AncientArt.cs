using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dsa.STACK.RVA
{
    public partial class AncientArt : Form
    {
        public AncientArt()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main mainForm = new Main();
            mainForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct! The Pyramids of Giza were built by Ancient Egypt.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect. Ancient Rome did not build the Pyramids.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct! The Parthenon was a temple dedicated to Athena.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect. The Parthenon is not a Roman amphitheater.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
