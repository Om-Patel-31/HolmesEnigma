namespace HolmesEnigma
{
    public partial class Form1 : Form
    {
        int page = 1;

        public Form1()
        {
            InitializeComponent();
            DisplayPage();
        }

        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    outputLabel.Text = "You are Sherlock Holmes, investigating a stolen heirloom at the Lockwood Estate.\nWhere do you start your investigation?";
                    break;
            }
        }
    }
}