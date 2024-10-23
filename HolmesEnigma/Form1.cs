using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Security.Cryptography;
using System.Threading;
using static System.Windows.Forms.AxHost;
using System.Collections;

namespace HolmesEnigma
{
    public partial class Form1 : Form
    {
        int page = 1;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            //Opening page
            outputLabel.Text = "You are Sherlock Holmes, investigating a stolen heirloom at the Lockwood Estate.\nWhere do you start your investigation?";
            option1Label.Text = "Lockwood Estate";
            option2Label.Text = "Scotland Yard";
            option3Label.Text = "Talk to Dr.Watson for advice";
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 4)
            {
                page = 9;
            }
            else if (page == 5)
            {
                page = 12;
            }
            else if (page == 9)
            {
                page = 12;
            }
            else if (page == 12)
            {
                page = 15;
            }
            else if (page == 15)
            {
                page = 1;
            }
            DisplayPage();
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 4;
            }
            DisplayPage();
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 3)
            {
                int rand = random.Next(1, 100);
                if (rand > 70)
                {
                    page = 7;
                }
                else
                {
                    page = 8;
                }
            }
            else if (page == 7)
            {
                page = 12;
            }
            else if (page == 12)
            {
                page = 15;
            }

            DisplayPage();
        }

        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    outputLabel.Text = "You are Sherlock Holmes, investigating a stolen heirloom at the Lockwood Estate.\nWhere do you start your investigation?";
                    option1Label.Text = "Lockwood Estate";
                    option2Label.Text = "Scotland Yard";
                    option3Label.Text = "Talk to Dr.Watson for advice";
                    option3Label.Enabled = true;
                    _ = option3Button.BackgroundImage = Properties.Resources.button_prototype2;
                    option3Button.Enabled = true;
                    break;

                case 2:
                    outputLabel.Text = "You find a broken window and muddy footprints";
                    option1Label.Text = "Examine the window";
                    option2Label.Text = "Follow the footprints";
                    option3Label.Text = "";
                    option3Label.Enabled = false;
                    _ = option3Button.BackgroundImage = null;
                    option3Button.Enabled = false;
                    break;
                case 3:
                    outputLabel.Text = "Lestrade mentions Tobias Slade, a suspect.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option3Label.Enabled = false;
                    _ = option3Button.BackgroundImage = null;
                    option3Button.Enabled = false;
                    Thread.Sleep(1000);
                    break;
                case 4:
                    outputLabel.Text = "Watson suggests questioning the family. Who do you talk to first?";
                    option1Label.Text = "The butler";
                    option2Label.Text = "Lady Lockwood";
                    option3Label.Text = "Lockwood's Son";
                    option3Label.Enabled = true;
                    _ = option3Button.BackgroundImage = Properties.Resources.button_prototype2;
                    option3Button.Enabled = true;
                    break;
                case 5:
                    option1Label.Text = "Take the cloth as evidence";
                    option2Label.Text = "Ignore it";
                    option3Label.Text = "";
                    option3Label.Enabled = false;
                    _ = option3Button.BackgroundImage = null;
                    option3Button.Enabled = false;
                    outputLabel.Text = "You find a torn cloth at the window. Could this be from the thief?";
                    Thread.Sleep(1000);
                    outputLabel.Text = "You take the cloth as evidence.";
                    break;
                case 6:
                    outputLabel.Text = "Footprints lead to gardener's shed. Do you...";
                    option1Label.Text = "Confront the Gardener";
                    option2Label.Text = "Search the shed quietly";
                    option3Label.Text = "";
                    option3Label.Enabled = false;
                    _ = option3Button.BackgroundImage = null;
                    option3Button.Enabled = false;
                    break;
                case 7:
                    outputLabel.Text = "Tobias denies involvement but mentions a strange visitor to the estate.";
                    option1Label.Text = "Press him";
                    option2Label.Text = "Investigate the visitor";
                    option3Label.Text = "";
                    option3Label.Enabled = false;
                    _ = option3Button.BackgroundImage = null;
                    option3Button.Enabled = false;
                    break;
                case 8:
                    outputLabel.Text = "You overlook important clues and get stuck. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    option3Label.Enabled = false;
                    _ = option3Button.BackgroundImage = null;
                    option3Button.Enabled = false;
                    break;
                case 9:
                    outputLabel.Text = "The butler is nervous";
                    option1Label.Text = "Press him further";
                    option2Label.Text = "Leave and investigate someone else";
                    option3Label.Text = "";
                    option3Label.Enabled = false;
                    _ = option3Button.BackgroundImage = null;
                    option3Button.Enabled = false;
                    break;
                case 10:
                    outputLabel.Text = "Lady Lockwood gives no useful info. Is she hiding something?";
                    option1Label.Text = "Trust her";
                    option2Label.Text = "Suspect her";
                    option3Label.Text = "";
                    option3Label.Enabled = false;
                    _ = option3Button.BackgroundImage = null;
                    option3Button.Enabled = false;
                    break;
                case 11:
                    outputLabel.Text = "The son is evasive";
                    option1Label.Text = "Investigate elsewhere";
                    option2Label.Text = "Confront him";
                    option3Label.Text = "";
                    option3Label.Enabled = false;
                    _ = option3Button.BackgroundImage = null;
                    option3Button.Enabled = false;
                    break;
                case 12:
                    outputLabel.Text = "You find a hidden passage.";
                    option1Label.Text = "Open it";
                    option2Label.Text = "Search for traps first";
                    option3Label.Text = "";
                    option3Label.Enabled = false;
                    _ = option3Button.BackgroundImage = null;
                    option3Button.Enabled = false;
                    break;
                case 13:
                    outputLabel.Text = "You find a trap and continue.";
                    option1Label.Text = "Disarm and enter vault";
                    option2Label.Text = "Leave";
                    option3Label.Text = "";
                    option3Label.Enabled = false;
                    _ = option3Button.BackgroundImage = null;
                    option3Button.Enabled = false;
                    break;
                case 14:
                    outputLabel.Text = "You overlook important clues and get stuck. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    option3Label.Enabled = false;
                    _ = option3Button.BackgroundImage = null;
                    option3Button.Enabled = false;
                    break;
                case 15:
                    outputLabel.Text = "The trap detonates while you disarm it, but you escape unharmed. However, you find no further clues. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    option3Label.Enabled = false;
                    _ = option3Button.BackgroundImage = null;
                    option3Button.Enabled = false;
                    break;
                case 99:
                    outputLabel.Text = "Thanks for playing.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Enabled = false;
                    _ = option1Button.BackgroundImage = null;
                    _ = option2Button.BackgroundImage = null;
                    _ = option3Button.BackgroundImage = null;
                    option3Button.Enabled = false;
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
}