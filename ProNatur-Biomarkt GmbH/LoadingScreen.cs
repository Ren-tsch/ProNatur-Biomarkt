﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatur_Biomarkt_GmbH
{
    public partial class LoadingScreen : Form
    {
        int valueProgressBar;

        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            timerProgressBar.Start();
            
        }

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            valueProgressBar++;
            progressBar1.Value = valueProgressBar;
            lblProgressBarPercent.Text = valueProgressBar.ToString() + "%";

            if (progressBar1.Maximum == valueProgressBar)
            {
                timerProgressBar.Stop();

                MainMenuScreen mainMenu = new MainMenuScreen();
                mainMenu.Show();

                this.Hide();
            }
        }
    }
}
