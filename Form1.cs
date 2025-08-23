using System;
using System.Drawing;
using System.Windows.Forms;

namespace SampleWinFormsAppNet8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBlue_Click(object? sender, EventArgs e) => this.BackColor = Color.Blue;
        private void btnRed_Click(object? sender, EventArgs e) => this.BackColor = Color.Red;
        private void btnGreen_Click(object? sender, EventArgs e) => this.BackColor = Color.Green;
        private void btnWhiteSmoke_Click(object? sender, EventArgs e) => this.BackColor = Color.WhiteSmoke;
    }
}
