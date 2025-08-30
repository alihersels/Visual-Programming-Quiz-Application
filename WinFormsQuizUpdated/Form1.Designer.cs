namespace WinFormsQuizWithDesignerTimer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.GroupBox groupAnswers;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblTimerCaption;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer quizTimer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.groupAnswers = new System.Windows.Forms.GroupBox();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblTimerCaption = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.quizTimer = new System.Windows.Forms.Timer(this.components);
            this.groupAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(24, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(153, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "WinForms Quiz";
            // 
            // lblQuestion
            // 
            this.lblQuestion.Location = new System.Drawing.Point(26, 62);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(628, 48);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Press Start to begin.";
            // 
            // groupAnswers
            // 
            this.groupAnswers.Controls.Add(this.rbD);
            this.groupAnswers.Controls.Add(this.rbC);
            this.groupAnswers.Controls.Add(this.rbB);
            this.groupAnswers.Controls.Add(this.rbA);
            this.groupAnswers.Location = new System.Drawing.Point(29, 120);
            this.groupAnswers.Name = "groupAnswers";
            this.groupAnswers.Size = new System.Drawing.Size(625, 152);
            this.groupAnswers.TabIndex = 2;
            this.groupAnswers.TabStop = false;
            this.groupAnswers.Text = "Choose one answer";
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(20, 32);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(41, 19);
            this.rbA.TabIndex = 0;
            this.rbA.TabStop = true;
            this.rbA.Text = "A)";
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(20, 62);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(41, 19);
            this.rbB.TabIndex = 1;
            this.rbB.TabStop = true;
            this.rbB.Text = "B)";
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(20, 92);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(41, 19);
            this.rbC.TabIndex = 2;
            this.rbC.TabStop = true;
            this.rbC.Text = "C)";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(20, 122);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(42, 19);
            this.rbD.TabIndex = 3;
            this.rbD.TabStop = true;
            this.rbD.Text = "D)";
            this.rbD.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(29, 340);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 30);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(560, 340);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 30);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(420, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Score:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblScore
            // 
            this.lblScore.Location = new System.Drawing.Point(478, 26);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(34, 22);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrent
            // 
            this.lblCurrent.Location = new System.Drawing.Point(524, 26);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(28, 22);
            this.lblCurrent.TabIndex = 7;
            this.lblCurrent.Text = "0";
            this.lblCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(552, 26);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(62, 22);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "/ 0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(29, 304);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(625, 18);
            this.progressBar.TabIndex = 9;
            // 
            // lblTimerCaption
            // 
            this.lblTimerCaption.Location = new System.Drawing.Point(620, 26);
            this.lblTimerCaption.Name = "lblTimerCaption";
            this.lblTimerCaption.Size = new System.Drawing.Size(44, 22);
            this.lblTimerCaption.TabIndex = 11;
            this.lblTimerCaption.Text = "Timer:";
            this.lblTimerCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTimer
            // 
            this.lblTimer.Location = new System.Drawing.Point(664, 26);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(28, 22);
            this.lblTimer.TabIndex = 12;
            this.lblTimer.Text = "15";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // quizTimer
            // 
            this.quizTimer.Interval = 1000;
            this.quizTimer.Tick += new System.EventHandler(this.quizTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(724, 391);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblTimerCaption);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupAnswers);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinForms Quiz";
            this.groupAnswers.ResumeLayout(false);
            this.groupAnswers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
