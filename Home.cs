using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DurakGame
{
    public partial class welcomeForm : Form
    {
        private int deckSize = 36;      // The size of the deck
        private bool transfers = false; // Whether transfers is enabled or not

        public welcomeForm()
        {
            InitializeComponent();
        }

        private void setDeckSize(int size, Button btn)
        {

            btnDeckSize20.BackColor = Color.White;
            btnDeckSize36.BackColor = Color.White;
            btnDeckSize52.BackColor = Color.White;
            deckSize = size;
            btn.BackColor = Color.LightBlue;

        }

        private void btnDeckSize20_Click(object sender, EventArgs e)
        {
            setDeckSize(20, (Button)sender);
        }

        private void btnDeckSize36_Click(object sender, EventArgs e)
        {
            setDeckSize(36, (Button)sender);
        }

        private void btnDeckSize52_Click(object sender, EventArgs e)
        {
            setDeckSize(52, (Button)sender);
        }

        private void cbTransfers_CheckedChanged(object sender, EventArgs e)
        {
            transfers = cbTransfers.Checked;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                return;
            }
            this.Hide();    // Hide the current form
            var gameForm = new Game(txtName.Text, transfers, deckSize);
            gameForm.Closed += (s, args) => this.Close();   // Close the current form
            gameForm.Show();    // Show the game form
        }

        private void welcomeForm_Load(object sender, EventArgs e)
        {
            // Set the color of the form elements
            this.BackColor = Color.FromArgb(3, 30, 84);
            btnPlay.BackColor = Color.FromArgb(114, 187, 8);
            lblDeckSize.BackColor = Color.FromArgb(190, 210, 239);
            lblName.BackColor = Color.FromArgb(190, 210, 239);
            lblTransfers.BackColor = Color.FromArgb(190, 210, 239);
        }
    }
}
