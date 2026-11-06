using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace dsa.STACK.RVA
{
    public partial class ArtHistoryQuiz : Form
    {
        private List<Question> questions = new List<Question>();
        private int currentIndex = 0;
        private int score = 0;
        private string userName;

        public ArtHistoryQuiz()
        {
            InitializeComponent();
            userName = PromptForName();
            LoadQuestions();
            DisplayQuestion();
        }

        private string PromptForName()
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Enter your name:", "Art History Quiz");
            if (string.IsNullOrWhiteSpace(name))
                name = "Guest";
            return name.Trim();
        }

        private void LoadQuestions()
        {
            questions = new List<Question>
            {
                new Question("Which site is famous for prehistoric cave paintings?", new[] { "Lascaux", "Parthenon", "Stonehenge" }, 0),
                new Question("What does the Venus of Willendorf symbolize?", new[] { "Fertility", "Warfare", "Trade" }, 0),
                new Question("Who built the Pyramids of Giza?", new[] { "Ancient Egypt", "Ancient Rome", "Ancient Greece" }, 0),
                new Question("The Parthenon was dedicated to which goddess?", new[] { "Athena", "Venus", "Isis" }, 0),
                new Question("Which style is associated with Medieval architecture?", new[] { "Gothic", "Baroque", "Modernist" }, 0),
                new Question("Illuminated manuscripts preserved what?", new[] { "Religious texts", "Military plans", "Trade routes" }, 0),
                new Question("Who painted The Last Supper?", new[] { "Leonardo da Vinci", "Michelangelo", "Raphael" }, 0),
                new Question("Renaissance art emphasized what?", new[] { "Humanism", "Abstract symbolism", "Industrialism" }, 0),
                new Question("Which artist is known for dramatic Baroque painting?", new[] { "Caravaggio", "Monet", "Van Gogh" }, 0),
                new Question("Baroque architecture is known for?", new[] { "Ornate grandeur", "Minimalism", "Steel structures" }, 0),
                new Question("Neoclassical art was inspired by?", new[] { "Ancient Greece and Rome", "Medieval Europe", "Modern America" }, 0),
                new Question("Neoclassical painting emphasized?", new[] { "Order and rationality", "Emotion", "Chaos" }, 0),
                new Question("Romantic art focused on?", new[] { "Emotion and nature", "Industry", "Geometry" }, 0),
                new Question("Caspar David Friedrich painted?", new[] { "Romantic landscapes", "Cubist portraits", "Pop art" }, 0),
                new Question("Which movement is Modern?", new[] { "Cubism", "Gothic", "Rococo" }, 0),
                new Question("Pablo Picasso is a pioneer of?", new[] { "Modern art", "Renaissance", "Neoclassicism" }, 0),
                new Question("Contemporary art often uses?", new[] { "Installation art", "Frescoes", "Tempera" }, 0),
                new Question("Contemporary themes include?", new[] { "Social issues", "Royal lineage", "Medieval warfare" }, 0),
                new Question("Which Medieval structure is iconic?", new[] { "Notre Dame Cathedral", "Colosseum", "Eiffel Tower" }, 0),
                new Question("Which Renaissance artist sculpted David?", new[] { "Michelangelo", "Donatello", "Bernini" }, 0)
            };
        }

        private void DisplayQuestion()
        {
            if (currentIndex >= questions.Count)
            {
                SaveScoreToDatabase(userName, score, questions.Count);
                MessageBox.Show($"Quiz complete!\nYour score: {score} out of {questions.Count}",
                                "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            var q = questions[currentIndex];
            lblQuestion.Text = q.Text;
            rdoA.Text = "A) " + q.Choices[0];
            rdoB.Text = "B) " + q.Choices[1];
            rdoC.Text = "C) " + q.Choices[2];
            lblProgress.Text = $"Question {currentIndex + 1} of {questions.Count}";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int selectedIndex = -1;
            if (rdoA.Checked) selectedIndex = 0;
            else if (rdoB.Checked) selectedIndex = 1;
            else if (rdoC.Checked) selectedIndex = 2;

            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select an answer before continuing.");
                return;
            }

            if (selectedIndex == questions[currentIndex].CorrectIndex)
                score++;

            currentIndex++;
            rdoA.Checked = rdoB.Checked = rdoC.Checked = false;
            DisplayQuestion();
        }

        private void bckButton_Click(object sender, EventArgs e)
        {
            if (currentIndex <= 0)
            {
                MessageBox.Show("You're already at the first question.");
                return;
            }

            currentIndex--;
            rdoA.Checked = rdoB.Checked = rdoC.Checked = false;
            DisplayQuestion();
        }

        private void SaveScoreToDatabase(string userName, int score, int totalQuestions)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ArtHistoryDB"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    string sql = @"INSERT INTO QuizResults (UserName, Score, TotalQuestions) 
                                   VALUES (@UserName, @Score, @TotalQuestions)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", userName);
                        cmd.Parameters.AddWithValue("@Score", score);
                        cmd.Parameters.AddWithValue("@TotalQuestions", totalQuestions);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save score.\n{ex.Message}",
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class Question
    {
        public string Text { get; }
        public string[] Choices { get; }
        public int CorrectIndex { get; }

        public Question(string text, string[] choices, int correctIndex)
        {
            Text = text;
            Choices = choices;
            CorrectIndex = correctIndex;
        }
    }
}
