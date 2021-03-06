﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magicEightBall
{
    public partial class magicBallForm : Form
    {
        Image magicBall = new Bitmap(@"8ball.png");

        string[] choices = new string[]{"It is certain", "Very doubtful", "Decidedly so",
                    "Outlook not good", "Without question", "Never", "Most likely",
                    "Ask again later", "Absolutely", "Cannot tell", "Do it", "Yes" };

        public magicBallForm()
        {
            InitializeComponent();
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            if(sheevModeCheck.Checked)
            {
                Image sheev = new Bitmap(@"sheevball.png");
                this.BackgroundImage = sheev;

                answerLabel.Text = "Do it.";
            }
            else
            {
                this.BackgroundImage = magicBall;
                answerLabel.Text = "";
                int upperBound = choices.Length + 1;
                int decision = rand.Next(1, upperBound); // (inclusive, exclusive)
                string response = choices[decision-1];
                answerLabel.Text = response;
            }
        }
    }
}
