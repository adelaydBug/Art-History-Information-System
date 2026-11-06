using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dsa.STACK.RVA
{
    public partial class MedievalArt : Form
    {
        public MedievalArt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main mainForm = new Main();
            mainForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct! Gothic architecture is a hallmark of the Medieval era.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect. Baroque architecture belongs to a later period.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect. They were not primarily used for military strategies.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct! Illuminated manuscripts preserved religious texts with ornate decoration.");
        }
    }
}
