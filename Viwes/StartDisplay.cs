using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void buttonContinue_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
