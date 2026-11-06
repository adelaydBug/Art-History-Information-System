namespace dsa.STACK.RVA
{
    partial class ArtHistoryQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblQuestion = new Label();
            rdoA = new RadioButton();
            rdoB = new RadioButton();
            rdoC = new RadioButton();
            btnNext = new Button();
            lblProgress = new Label();
            bckButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(225, 242);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(122, 45);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "label1";
            // 
            // rdoA
            // 
            rdoA.AutoSize = true;
            rdoA.Font = new Font("Arial Rounded MT Bold", 22.2F);
            rdoA.Location = new Point(231, 340);
            rdoA.Name = "rdoA";
            rdoA.Size = new Size(274, 47);
            rdoA.TabIndex = 1;
            rdoA.TabStop = true;
            rdoA.Text = "radioButton1";
            rdoA.UseVisualStyleBackColor = true;
            // 
            // rdoB
            // 
            rdoB.AutoSize = true;
            rdoB.Font = new Font("Arial Rounded MT Bold", 22.2F);
            rdoB.Location = new Point(231, 436);
            rdoB.Name = "rdoB";
            rdoB.Size = new Size(274, 47);
            rdoB.TabIndex = 2;
            rdoB.TabStop = true;
            rdoB.Text = "radioButton2";
            rdoB.UseVisualStyleBackColor = true;
            // 
            // rdoC
            // 
            rdoC.AutoSize = true;
            rdoC.Font = new Font("Arial Rounded MT Bold", 22.2F);
            rdoC.Location = new Point(231, 532);
            rdoC.Name = "rdoC";
            rdoC.Size = new Size(274, 47);
            rdoC.TabIndex = 3;
            rdoC.TabStop = true;
            rdoC.Text = "radioButton3";
            rdoC.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Gill Sans Ultra Bold Condensed", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(1459, 737);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(192, 65);
            btnNext.TabIndex = 4;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Font = new Font("Cooper Black", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgress.Location = new Point(866, 832);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(150, 49);
            lblProgress.TabIndex = 6;
            lblProgress.Text = "label2";
            // 
            // bckButton
            // 
            bckButton.Font = new Font("Gill Sans Ultra Bold Condensed", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bckButton.Location = new Point(231, 737);
            bckButton.Name = "bckButton";
            bckButton.Size = new Size(183, 65);
            bckButton.TabIndex = 5;
            bckButton.Text = "Back";
            bckButton.UseVisualStyleBackColor = true;
            bckButton.Click += bckButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Peru;
            label1.Location = new Point(459, 57);
            label1.Name = "label1";
            label1.Size = new Size(965, 103);
            label1.TabIndex = 7;
            label1.Text = "ART HISTORY QUIZ";
            // 
            // ArtHistoryQuiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1882, 953);
            Controls.Add(label1);
            Controls.Add(lblProgress);
            Controls.Add(bckButton);
            Controls.Add(btnNext);
            Controls.Add(rdoC);
            Controls.Add(rdoB);
            Controls.Add(rdoA);
            Controls.Add(lblQuestion);
            Name = "ArtHistoryQuiz";
            Text = "Art History Quiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rdoA;
        private System.Windows.Forms.RadioButton rdoB;
        private System.Windows.Forms.RadioButton rdoC;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblProgress;
        private Button bckButton;
        private Label label1;
    }
}
