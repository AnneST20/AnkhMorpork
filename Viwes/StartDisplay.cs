using System;
using System.Windows.Forms;

namespace AnkhMorpork
{
    public partial class StartDisplay : Form
    {
        GameDisplay gameDisplay;
        public StartDisplay()
        {
            InitializeComponent();
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
