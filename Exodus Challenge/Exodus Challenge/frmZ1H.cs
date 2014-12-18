﻿using System;
using System.Windows.Forms;

namespace Exodus_Challenge
{
    public partial class frmZ1H : Form
    {
        #region Private Fields

        private int timeRemaining = 10;

        #endregion Private Fields

        #region Public Constructors

        public frmZ1H()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Private Methods

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form lvl = new LevelSelect();
            lvl.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbox1.Text == "Judah" &&
                tbar2.Value == 5 &&
                tbx3.Text == "Jochebed" &&
                rbtn4a.Checked)
            {
                MessageBox.Show("Congratulations!");
                loginSystem.user.scoreManna += 10 * timeRemaining;
            }
        }

        private void tbar2_Scroll(object sender, EventArgs e)
        {
            label5.Text = tbar2.Value.ToString();
        }

        #endregion Private Methods
    }
}