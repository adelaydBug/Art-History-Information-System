using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dsa.STACK.RVA
{
    public partial class PrehistoricArt : Form
    {
        public PrehistoricArt()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }


        private void PrehistoricArt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main mainForm = new Main();
            mainForm.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect. Warfare is not the symbolism of the Venus of Willendorf.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct! Lascaux is a famous site of prehistoric cave paintings.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect. The Parthenon is from Ancient Greece, not Prehistoric Art.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct! The Venus of Willendorf symbolizes fertility.");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
