using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dsa.STACK.RVA
{
    public partial class RenaissanceArt : Form
    {
        public RenaissanceArt()
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
            MessageBox.Show("Incorrect. Michelangelo is known for the Sistine Chapel ceiling.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct! Leonardo da Vinci painted Monalisa.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect. Abstract symbolism is more associated with modern art.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct! Renaissance art emphasized humanism and realism.");
        }
    }
}
