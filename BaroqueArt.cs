using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dsa.STACK.RVA
{
    public partial class BaroqueArt : Form
    {
        public BaroqueArt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main mainForm = new Main();
            mainForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct! Caravaggio is famous for his dramatic Baroque paintings using chiaroscuro.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect. Claude Monet was an Impressionist, not a Baroque painter.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct! Baroque architecture is known for ornate detail and grandeur.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect. Minimalist simplicity is more associated with modern architecture.");
        }
    }
}
