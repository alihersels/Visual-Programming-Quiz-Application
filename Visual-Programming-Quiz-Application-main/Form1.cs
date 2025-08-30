using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsQuizNet8
{
    public partial class Form1 : Form
    {
        private readonly List<Question> _questions;
        private int _index = -1;
        private int _score = 0;

        public Form1()
        {
            InitializeComponent();

            
            _questions = LoadQuestionsFromFile("questions.txt");

            if (_questions.Count == 0)
            {
                MessageBox.Show("No questions loaded. Please check questions.txt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnStart.Enabled = false;
            }

            lblTotal.Text = $"/ {_questions.Count}";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _index = -1;
            _score = 0;
            lblScore.Text = "0";
            btnNext.Enabled = true;
            btnStart.Enabled = false;
            NextQuestion();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!AnySelected())
            {
                MessageBox.Show("Please choose an answer.", "Quiz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedIndex = SelectedAnswerIndex();
            if (selectedIndex == _questions[_index].AnswerIndex)
                _score++;

            lblScore.Text = _score.ToString();

            if (_index >= _questions.Count - 1)
            {
                FinishQuiz();
                return;
            }

            NextQuestion();
        }

        private void NextQuestion()
        {
            _index++;
            ClearSelection();

            var q = _questions[_index];
            lblQuestion.Text = q.Text;
            rbA.Text = q.Choices[0];
            rbB.Text = q.Choices[1];
            rbC.Text = q.Choices[2];
            rbD.Text = q.Choices[3];

            lblCurrent.Text = (_index + 1).ToString();
        }

        private void FinishQuiz()
        {
            btnNext.Enabled = false;
            btnStart.Enabled = true;
            MessageBox.Show($"Your score: {_score} / {_questions.Count}", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool AnySelected() => new[] { rbA, rbB, rbC, rbD }.Any(r => r.Checked);

        private int SelectedAnswerIndex()
        {
            if (rbA.Checked) return 0;
            if (rbB.Checked) return 1;
            if (rbC.Checked) return 2;
            if (rbD.Checked) return 3;
            return -1;
        }

        private void ClearSelection()
        {
            rbA.Checked = rbB.Checked = rbC.Checked = rbD.Checked = false;
        }

        private List<Question> LoadQuestionsFromFile(string filePath)
        {
            var questions = new List<Question>();

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Questions file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return questions;
            }

            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length != 6) continue;

                var text = parts[0];
                var choices = new[] { parts[1], parts[2], parts[3], parts[4] };
                if (!int.TryParse(parts[5], out int answerIndex)) continue;
                questions.Add(new Question(text, choices, answerIndex));
            }

            return questions;
        }
    }

    public record Question(string Text, string[] Choices, int AnswerIndex);
}
