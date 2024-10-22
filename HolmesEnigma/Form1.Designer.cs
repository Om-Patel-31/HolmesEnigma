namespace HolmesEnigma
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            outputLabel = new Label();
            option1Button = new Button();
            option2Button = new Button();
            option1Label = new Label();
            option2Label = new Label();
            SuspendLayout();
            // 
            // outputLabel
            // 
            outputLabel.BackColor = Color.Transparent;
            outputLabel.FlatStyle = FlatStyle.Flat;
            outputLabel.Font = new Font("Cinzel", 18F);
            outputLabel.ForeColor = Color.FromArgb(212, 175, 55);
            outputLabel.Location = new Point(12, 9);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(982, 128);
            outputLabel.TabIndex = 0;
            outputLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // option1Button
            // 
            option1Button.BackColor = Color.Transparent;
            option1Button.BackgroundImage = Properties.Resources.button_prototype2;
            option1Button.BackgroundImageLayout = ImageLayout.Zoom;
            option1Button.FlatAppearance.BorderSize = 0;
            option1Button.FlatStyle = FlatStyle.Flat;
            option1Button.Location = new Point(12, 580);
            option1Button.Name = "option1Button";
            option1Button.Size = new Size(60, 44);
            option1Button.TabIndex = 1;
            option1Button.UseVisualStyleBackColor = false;
            // 
            // option2Button
            // 
            option2Button.BackColor = Color.Transparent;
            option2Button.BackgroundImage = Properties.Resources.button_prototype2;
            option2Button.BackgroundImageLayout = ImageLayout.Zoom;
            option2Button.FlatAppearance.BorderSize = 0;
            option2Button.FlatStyle = FlatStyle.Flat;
            option2Button.Location = new Point(12, 655);
            option2Button.Name = "option2Button";
            option2Button.Size = new Size(60, 44);
            option2Button.TabIndex = 2;
            option2Button.UseVisualStyleBackColor = false;
            // 
            // option1Label
            // 
            option1Label.BackColor = Color.Transparent;
            option1Label.FlatStyle = FlatStyle.Flat;
            option1Label.Font = new Font("Cinzel", 24F, FontStyle.Bold);
            option1Label.ForeColor = Color.FromArgb(212, 175, 55);
            option1Label.Location = new Point(78, 580);
            option1Label.Name = "option1Label";
            option1Label.Size = new Size(885, 48);
            option1Label.TabIndex = 3;
            // 
            // option2Label
            // 
            option2Label.BackColor = Color.Transparent;
            option2Label.FlatStyle = FlatStyle.Flat;
            option2Label.Font = new Font("Cinzel", 24F, FontStyle.Bold);
            option2Label.ForeColor = Color.FromArgb(212, 175, 55);
            option2Label.Location = new Point(78, 651);
            option2Label.Name = "option2Label";
            option2Label.Size = new Size(885, 48);
            option2Label.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.page1image;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1006, 721);
            Controls.Add(option2Label);
            Controls.Add(option1Label);
            Controls.Add(option2Button);
            Controls.Add(option1Button);
            Controls.Add(outputLabel);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "Holmes' Enigma";
            ResumeLayout(false);
        }

        #endregion

        private Label outputLabel;
        private Button option1Button;
        private Button option2Button;
        private Label option1Label;
        private Label option2Label;
    }
}
