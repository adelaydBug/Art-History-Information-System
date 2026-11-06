using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dsa.STACK.RVA
{
    public partial class ContemporaryArt : Form
    {
        public ContemporaryArt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main mainform = new Main();
            mainform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct! Installation art is a hallmark of the Contemporary era.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect. Manuscript illumination belongs to the Medieval era.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect. Strict religious symbolism is more characteristic of Medieval art.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct! Contemporary art often explores social and political issues.");
        }
    }
}
