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
        //Declaring variables
        int page = 1;
        SoundPlayer player = new SoundPlayer();

        public Form1()
        {
            InitializeComponent();

            //Opening page
            outputLabel.Text = "You are Sherlock Holmes, investigating a stolen heirloom at the Lockwood Estate.\nWhere do you start your investigation?";
            option1Label.Text = "Lockwood Estate";
            option2Label.Text = "Scotland Yard";
            option3Label.Text = "Talk to Dr.Watson for advice";
            player = new SoundPlayer(Properties.Resources.page1sound);
            player.Play();
        }

        //Telling what the first button does
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
            else if (page == 6)
            {
                page = 13;
            }
            else if (page == 7)
            {
                page = 12;
            }
            else if (page == 8)
            {
                page = 1;
            }
            else if (page == 9)
            {
                page = 12;
            }
            else if (page == 10)
            {
                page = 6;
            }
            else if (page == 11)
            {
                page = 14;
            }
            else if (page == 12)
            {
                page = 15;
            }
            else if (page == 13)
            {
                page = 14;
            }
            else if (page == 14)
            {
                page = 1;
            }
            else if (page == 15)
            {
                page = 1;
            }
            DisplayPage();
        }

        //Telling what the first label does
        private void option1Label_Click(object sender, EventArgs e)
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
            else if (page == 6)
            {
                page = 13;
            }
            else if (page == 7)
            {
                page = 12;
            }
            else if (page == 8)
            {
                page = 1;
            }
            else if (page == 9)
            {
                page = 12;
            }
            else if (page == 10)
            {
                page = 6;
            }
            else if (page == 11)
            {
                page = 14;
            }
            else if (page == 12)
            {
                page = 15;
            }
            else if (page == 13)
            {
                page = 14;
            }
            else if (page == 14)
            {
                page = 1;
            }
            else if (page == 15)
            {
                page = 1;
            }
            DisplayPage();
        }

        //Telling what the second button does
        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 4;
            }
            else if (page == 2)
            {
                page = 6;
            }
            else if (page == 4)
            {
                page = 10;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 12;
            }
            else if (page == 7)
            {
                page = 15;
            }
            else if (page == 8)
            {
                page = 99;
            }
            else if (page == 9)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 12;
            }
            else if (page == 11)
            {
                page = 14;
            }
            else if (page == 12)
            {
                page = 13;
            }
            else if (page == 13)
            {
                page = 99;
            }
            else if (page == 14)
            {
                page = 99;
            }
            else if (page == 15)
            {
                page = 99;
            }
            DisplayPage();
        }

        //Telling what the second label does
        private void option2Label_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 4;
            }
            else if (page == 2)
            {
                page = 6;
            }
            else if (page == 4)
            {
                page = 10;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 12;
            }
            else if (page == 7)
            {
                page = 15;
            }
            else if (page == 8)
            {
                page = 99;
            }
            else if (page == 9)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 12;
            }
            else if (page == 11)
            {
                page = 14;
            }
            else if (page == 12)
            {
                page = 13;
            }
            else if (page == 13)
            {
                page = 99;
            }
            else if (page == 14)
            {
                page = 99;
            }
            else if (page == 15)
            {
                page = 99;
            }
            DisplayPage();
        }

        //Telling what the third button does
        private void option3Button_Click(object sender, EventArgs e)
        {
            {
                if (page == 1)
                {
                    page = 3;
                    DisplayPage();
                }
                else if (page == 3)
                {
                    DisplayPage();
                    Refresh();
                }

                else if (page == 4)
                {
                    page = 11;
                }
                DisplayPage();
            }
        }

        //Telling what the third label does
        private void option3Label_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
                DisplayPage();
            }
            else if (page == 3)
            {
                DisplayPage();
                Refresh();
            }

            else if (page == 4)
            {
                page = 11;
            }
            DisplayPage();
        }

        //Declaring a function that uses switch-case statement to show the pages' uses
        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    player = new SoundPlayer(Properties.Resources.page1sound);
                    player.Play();
                    this.BackgroundImage = Properties.Resources.page1image;
                    outputLabel.Text = "You are Sherlock Holmes, investigating a stolen heirloom at the Lockwood Estate.\nWhere do you start your investigation?";
                    option1Label.Text = "Lockwood Estate";
                    option2Label.Text = "Scotland Yard";
                    option3Label.Text = "Talk to Dr.Watson for advice";
                    option1Label.Enabled = true;
                    option2Label.Enabled = true;
                    option3Label.Enabled = true;
                    option3Button.Enabled = true;
                    _ = option3Button.BackgroundImage = Properties.Resources.button_prototype2;
                    _ = option1Button.BackgroundImage = Properties.Resources.button_prototype2;
                    _ = option2Button.BackgroundImage = Properties.Resources.button_prototype2;
                    break;
                case 2:
                    player = new SoundPlayer(Properties.Resources.page2sound);
                    player.Play();
                    this.BackgroundImage = Properties.Resources.page2image;
                    outputLabel.Text = "You find a broken window and muddy footprints";
                    option1Label.Text = "Examine the window";
                    option2Label.Text = "Follow the footprints";
                    option3Label.Text = "";
                    option3Label.Enabled = false;
                    _ = option3Button.BackgroundImage = null;
                    option3Button.Enabled = false;
                    _ = option1Button.BackgroundImage = Properties.Resources.button_prototype2;
                    _ = option2Button.BackgroundImage = Properties.Resources.button_prototype2;
                    break;
                case 3:
                    player = new SoundPlayer(Properties.Resources.page3sound);
                    player.Play();
                    this.BackgroundImage = Properties.Resources.page3image;
                    outputLabel.Text = "Lestrade mentions Tobias Slade, a suspect.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option1Label.Enabled = false;
                    option1Button.Enabled = false;
                    option2Label.Enabled = false;
                    option2Button.Enabled = false;
                    option3Label.Enabled = false;
                    option3Button.Enabled = false;
                    _ = option1Button.BackgroundImage = null;
                    _ = option2Button.BackgroundImage = null;
                    _ = option3Button.BackgroundImage = null;
                    Refresh();
                    Thread.Sleep(1000);
                    Random randGen = new Random();
                    int randomValue = randGen.Next(1, 11);
                    Thread.Sleep(1000);
                    if (randomValue >= 7)
                    {
                        page = 7;
                    }
                    else
                    {
                        page = 8;
                    }

                    break;
                case 4:
                    player = new SoundPlayer(Properties.Resources.page4sound);
                    player.Play();
                    this.BackgroundImage = Properties.Resources.page4image;
                    outputLabel.Text = "Watson suggests questioning the family. Who do you talk to first?";
                    option1Label.Text = "The butler";
                    option2Label.Text = "Lady Lockwood";
                    option3Label.Text = "Lockwood's Son";
                    option3Label.Enabled = true;
                    option1Button.Enabled = true;
                    option1Label.Enabled = true;
                    option2Label.Enabled = true;
                    option2Button.Enabled = true;
                    _ = option3Button.BackgroundImage = Properties.Resources.button_prototype2;
                    option3Button.Enabled = true;
                    _ = option1Button.BackgroundImage = Properties.Resources.button_prototype2;
                    _ = option2Button.BackgroundImage = Properties.Resources.button_prototype2;
                    break;
                case 5:
                    player = new SoundPlayer(Properties.Resources.page5sound);
                    player.Play();
                    this.BackgroundImage = Properties.Resources.page5image;
                    option1Label.Text = "Take the cloth as evidence";
                    option2Label.Text = "Ignore it";
                    option3Label.Text = "";
                    option3Label.Enabled = false;
                    _ = option3Button.BackgroundImage = null;
                    option3Button.Enabled = false;
                    outputLabel.Text = "You find a torn cloth at the window. Could this be from the thief?";
                    Refresh();
                    Thread.Sleep(2000);
                    outputLabel.Text += " You take the cloth as evidence?";
                    _ = option1Button.BackgroundImage = Properties.Resources.button_prototype2;
                    _ = option2Button.BackgroundImage = Properties.Resources.button_prototype2;
                    break;
                case 6:
                    player = new SoundPlayer(Properties.Resources.page6sound);
                    player.Play();
                    this.BackgroundImage = Properties.Resources.page6image;
                    outputLabel.Text = "Footprints lead to gardener's shed. Do you...";
                    option1Label.Text = "Confront the Gardener";
                    option2Label.Text = "Search the shed quietly";
                    option3Label.Text = "";
                    option3Label.Enabled = false;
                    _ = option3Button.BackgroundImage = null;
                    option3Button.Enabled = false;
                    _ = option1Button.BackgroundImage = Properties.Resources.button_prototype2;
                    _ = option2Button.BackgroundImage = Properties.Resources.button_prototype2;
                    break;
                case 7:
                    player = new SoundPlayer(Properties.Resources.page7sound);
                    Refresh();
                    player.Play();
                    this.BackgroundImage = Properties.Resources.page7image;
                    outputLabel.Text = "Tobias denies involvement but mentions a strange visitor to the estate.";
                    option1Label.Text = "Press him";
                    option2Label.Text = "Investigate the visitor";
                    option3Label.Text = "";
                    option1Button.Enabled = true;
                    option1Label.Enabled = true;
                    option2Label.Enabled = true;
                    option2Button.Enabled = true;
                    option3Label.Enabled = false;
                    option3Label.Enabled = false;
                    _ = option3Button.BackgroundImage = null;
                    option3Button.Enabled = false;
                    _ = option1Button.BackgroundImage = Properties.Resources.button_prototype2;
                    _ = option2Button.BackgroundImage = Properties.Resources.button_prototype2;
                    break;
                case 8:
                    player = new SoundPlayer(Properties.Resources.page8sound);
                    Refresh();
                    player.Play();
                    this.BackgroundImage = Properties.Resources.page8image;
                    outputLabel.Text = "You overlook important clues and get stuck. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    option1Button.Enabled = true;
                    option1Label.Enabled = true;
                    option2Label.Enabled = true;
                    option2Button.Enabled = true;
                    option3Label.Enabled = false;
                    _ = option3Button.BackgroundImage = null;
                    option3Button.Enabled = false;
                    _ = option1Button.BackgroundImage = Properties.Resources.button_prototype2;
                    _ = option2Button.BackgroundImage = Properties.Resources.button_prototype2;
                    break;
                case 9:
                    player = new SoundPlayer(Properties.Resources.page9sound);
                    player.Play();
                    this.BackgroundImage = Properties.Resources.page9image;
                    outputLabel.Text = "The butler is nervous";
                    option1Label.Text = "Press him further";
                    option2Label.Text = "Leave and investigate someone else";
                    option3Label.Text = "";
                    option3Label.Enabled = false;
                    _ = option3Button.BackgroundImage = null;
                    option3Button.Enabled = false;
                    _ = option1Button.BackgroundImage = Properties.Resources.button_prototype2;
                    _ = option2Button.BackgroundImage = Properties.Resources.button_prototype2;
                    break;
                case 10:
                    player = new SoundPlayer(Properties.Resources.page10sound);
                    player.Play();
                    this.BackgroundImage = Properties.Resources.page10image;
                    outputLabel.Text = "Lady Lockwood gives no useful info. Is she hiding something?";
                    option1Label.Text = "Trust her";
                    option2Label.Text = "Suspect her";
                    option3Label.Text = "";
                    option3Label.Enabled = false;
                    _ = option3Button.BackgroundImage = null;
                    option3Button.Enabled = false;
                    _ = option1Button.BackgroundImage = Properties.Resources.button_prototype2;
                    _ = option2Button.BackgroundImage = Properties.Resources.button_prototype2;
                    break;
                case 11:
                    player = new SoundPlayer(Properties.Resources.page11sound);
                    player.Play();
                    this.BackgroundImage = Properties.Resources.page11image;
                    outputLabel.Text = "The son is evasive";
                    option1Label.Text = "Investigate elsewhere";
                    option2Label.Text = "Confront him";
                    option3Label.Text = "";
                    option3Label.Enabled = false;
                    _ = option3Button.BackgroundImage = null;
                    option3Button.Enabled = false;
                    _ = option1Button.BackgroundImage = Properties.Resources.button_prototype2;
                    _ = option2Button.BackgroundImage = Properties.Resources.button_prototype2;
                    break;
                case 12:
                    player = new SoundPlayer(Properties.Resources.page12sound);
                    player.Play();
                    this.BackgroundImage = Properties.Resources.page12image;
                    outputLabel.Text = "You find a hidden passage.";
                    option1Label.Text = "Open it";
                    option2Label.Text = "Search for traps first";
                    option3Label.Text = "";
                    option3Label.Enabled = false;
                    _ = option3Button.BackgroundImage = null;
                    option3Button.Enabled = false;
                    _ = option1Button.BackgroundImage = Properties.Resources.button_prototype2;
                    _ = option2Button.BackgroundImage = Properties.Resources.button_prototype2;
                    break;
                case 13:
                    player = new SoundPlayer(Properties.Resources.page13sound);
                    player.Play();
                    this.BackgroundImage = Properties.Resources.page13image;
                    outputLabel.Text = "You find a trap and continue.";
                    option1Label.Text = "Disarm and enter vault";
                    option2Label.Text = "Leave";
                    option3Label.Text = "";
                    option3Label.Enabled = false;
                    _ = option3Button.BackgroundImage = null;
                    option3Button.Enabled = false;
                    _ = option1Button.BackgroundImage = Properties.Resources.button_prototype2;
                    _ = option2Button.BackgroundImage = Properties.Resources.button_prototype2;
                    break;
                case 14:
                    player = new SoundPlayer(Properties.Resources.page14sound);
                    player.Play();
                    this.BackgroundImage = Properties.Resources.page14image;
                    outputLabel.Text = "You overlook important clues and get stuck. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    option3Label.Enabled = false;
                    _ = option3Button.BackgroundImage = null;
                    option3Button.Enabled = false;
                    _ = option1Button.BackgroundImage = Properties.Resources.button_prototype2;
                    _ = option2Button.BackgroundImage = Properties.Resources.button_prototype2;
                    break;
                case 15:
                    player = new SoundPlayer(Properties.Resources.page15sound);
                    player.Play();
                    this.BackgroundImage = Properties.Resources.page15image;
                    outputLabel.Text = "You find the heirloom. It was an inside job! Congrats! Case Solved. Play Again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";
                    option3Label.Enabled = false;
                    _ = option3Button.BackgroundImage = null;
                    option3Button.Enabled = false;
                    _ = option1Button.BackgroundImage = Properties.Resources.button_prototype2;
                    _ = option2Button.BackgroundImage = Properties.Resources.button_prototype2;
                    break;
                case 99:
                    player = new SoundPlayer(Properties.Resources.page99sound);
                    player.Play();
                    this.BackgroundImage = Properties.Resources.page99image;
                    outputLabel.Text = "Thanks for playing.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Enabled = false;
                    _ = option1Button.BackgroundImage = null;
                    _ = option2Button.BackgroundImage = null;
                    _ = option3Button.BackgroundImage = null;
                    option3Button.Enabled = false;
                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
            }
        }
    }
}