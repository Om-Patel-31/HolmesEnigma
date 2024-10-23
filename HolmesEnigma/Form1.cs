namespace HolmesEnigma
{
    public partial class Form1 : Form
    {
        int page = 1;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            DisplayPage();
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
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
                    break;

                case 2:
                    outputLabel.Text = "You find a broken window and muddy footprints";
                    option1Label.Text = "Examine the window";
                    option2Label.Text = "Follow the footprints";
                    option3Label.Text = "";
                    _ = option3Button.BackgroundImage = null;
                    break;
                case 3:
                    outputLabel.Text = "You find a broken window and muddy footprints";
                    option1Label.Text = "Examine the window";
                    option2Label.Text = "Follow the footprints";
                    option3Label.Text = "";
                    _ = option3Button.BackgroundImage = null;
                    break;
            }
        }
    }
}