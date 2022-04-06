using System;
using System.Windows.Forms;

namespace AnkhMorpork.Viwes
{
    public partial class EndGame : Form
    {
        GameDisplay gameDisplay;
        public EndGame(string text)
        {
            InitializeComponent();
            labelDeath.Text = text;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Hide();
            gameDisplay = new GameDisplay();
            gameDisplay.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
