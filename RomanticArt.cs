using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dsa.STACK.RVA
{
    public partial class RomanticArt : Form
    {
        public RomanticArt()
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
            MessageBox.Show("Correct! Romantic art emphasized emotion and the power of nature.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect. Industrial progress was more linked to Realism and later movements.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct! Caspar David Friedrich is famous for his dramatic Romantic landscapes.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect. Pablo Picasso was a modernist, not a Romantic artist.");
        }
    }
}
