using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsQuizWithDesignerTimer
{
    public partial class Form1 : Form
    {
        public record Question(string Text, string[] Choices, int AnswerIndex);
        private List<Question> _questions = new();
        private int _current = -1;
        private int _score = 0;
        private int _timeLeft = 15;

        public Form1()
        {
            InitializeComponent();

            _questions = new List<Question>{
                new("Which keyword declares a constant in C#?", new[]{ "let", "const", "readonly", "var" }, 2),
                new("Which collection preserves insertion order and allows duplicates?", new[]{ "HashSet<T>", "Dictionary<TKey,TValue>", "List<T>", "SortedSet<T>" }, 2),
                new("What does WinForms stand for?", new[]{ "Windows Formatting System", "Windows Forms", "Windows Framework Services", "Windows Function Set" }, 1),
                new("Which event fires when a Button is clicked?", new[]{ "Changed", "Pressed", "Click", "Invoked" }, 2)
            };

            lblTotal.Text = "/ " + _questions.Count.ToString(); 
            progressBar.Maximum = _questions.Count;
            lblTimer.Text = "15";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _score = 0;
            lblScore.Text = "0";
            btnNext.Enabled = true;
            btnStart.Enabled = false;
            progressBar.Value = 0;
            NextQuestion();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (AnswerSelected() && SelectedAnswerIndex() == _questions[_current].AnswerIndex)
                _score++;
            lblScore.Text = _score.ToString();
            progressBar.Value = _current + 1;

            if (_current >= _questions.Count - 1) { FinishQuiz(); return; }
            NextQuestion();
        }

        private void NextQuestion()
        {
            _current++;
            ClearSelection();

            var q = _questions[_current];
            lblQuestion.Text = q.Text;
            rbA.Text = q.Choices[0];
            rbB.Text = q.Choices[1];
            rbC.Text = q.Choices[2];
            rbD.Text = q.Choices[3];

            lblCurrent.Text = (_current + 1).ToString();
            _timeLeft = 15;
            lblTimer.Text = _timeLeft.ToString();
            quizTimer.Start();
        }

        private void quizTimer_Tick(object sender, EventArgs e)
        {
            _timeLeft--;
            lblTimer.Text = _timeLeft.ToString();
            if (_timeLeft <= 0)
            {
                quizTimer.Stop();
                btnNext.PerformClick();
            }
        }

        private void FinishQuiz()
        {
            quizTimer.Stop();
            btnNext.Enabled = false;
            btnStart.Enabled = true;
            progressBar.Value = progressBar.Maximum;
            MessageBox.Show(
                     "Your score: " + _score.ToString() + " / " + _questions.Count.ToString(),
                     "Finished",
                     MessageBoxButtons.OK,
                    MessageBoxIcon.Information
            );
        }

        private bool AnswerSelected()
        {
            return rbA.Checked || rbB.Checked || rbC.Checked || rbD.Checked;
        }

        private int SelectedAnswerIndex() => rbA.Checked ? 0 : rbB.Checked ? 1 : rbC.Checked ? 2 : rbD.Checked ? 3 : -1;
        private void ClearSelection() { rbA.Checked = rbB.Checked = rbC.Checked = rbD.Checked = false; }
    }
}
