namespace dsa.STACK.RVA
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void baroque_Click(object sender, EventArgs e)
        {
            BaroqueArt baroqueForm = new BaroqueArt();
            baroqueForm.Show();
            this.Hide();
        }

        private void prehistoric_Click(object sender, EventArgs e)
        {
            PrehistoricArt prehistoricForm = new PrehistoricArt();
            prehistoricForm.Show();
            this.Hide();
        }

        private void romantic_Click(object sender, EventArgs e)
        {
            RomanticArt romanticForm = new RomanticArt();
            romanticForm.Show();
            this.Hide();
        }

        private void ancient_Click(object sender, EventArgs e)
        {
            AncientArt ancientForm = new AncientArt();
            ancientForm.Show();
            this.Hide();
        }

        private void medieval_Click(object sender, EventArgs e)
        {
            MedievalArt medievalForm = new MedievalArt();
            medievalForm.Show();
            this.Hide();
        }

        private void renaissance_Click(object sender, EventArgs e)
        {
            RenaissanceArt renaissanceForm = new RenaissanceArt();
            renaissanceForm.Show();
            this.Hide();
        }

        private void neoclassical_Click(object sender, EventArgs e)
        {
            NeoclassicalArt neoclassicalForm = new NeoclassicalArt();
            neoclassicalForm.Show();
            this.Hide();
        }

        private void modern_Click(object sender, EventArgs e)
        {
            ModernArt modernForm = new ModernArt();
            modernForm.Show();
            this.Hide();
        }

        private void contemporary_Click(object sender, EventArgs e)
        {
            ContemporaryArt contemporaryForm = new ContemporaryArt();
            contemporaryForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArtHistoryQuiz quizForm = new ArtHistoryQuiz();
            quizForm.ShowDialog();
        }
    }
}
