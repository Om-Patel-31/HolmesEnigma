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
            option3Button = new Button();
            option3Label = new Label();
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
            option1Button.FlatAppearance.CheckedBackColor = Color.Transparent;
            option1Button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            option1Button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            option1Button.FlatStyle = FlatStyle.Flat;
            option1Button.Location = new Point(12, 517);
            option1Button.Name = "option1Button";
            option1Button.Size = new Size(60, 44);
            option1Button.TabIndex = 1;
            option1Button.UseVisualStyleBackColor = false;
            option1Button.Click += option1Button_Click;
            // 
            // option2Button
            // 
            option2Button.BackColor = Color.Transparent;
            option2Button.BackgroundImage = Properties.Resources.button_prototype2;
            option2Button.BackgroundImageLayout = ImageLayout.Zoom;
            option2Button.FlatAppearance.BorderSize = 0;
            option2Button.FlatAppearance.CheckedBackColor = Color.Transparent;
            option2Button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            option2Button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            option2Button.FlatStyle = FlatStyle.Flat;
            option2Button.Location = new Point(12, 596);
            option2Button.Name = "option2Button";
            option2Button.Size = new Size(60, 44);
            option2Button.TabIndex = 2;
            option2Button.UseVisualStyleBackColor = false;
            // 
            // option1Label
            // 
            option1Label.BackColor = Color.Transparent;
            option1Label.FlatStyle = FlatStyle.Flat;
            option1Label.Font = new Font("Cinzel", 16F, FontStyle.Bold);
            option1Label.ForeColor = Color.FromArgb(255, 253, 208);
            option1Label.Location = new Point(78, 517);
            option1Label.Name = "option1Label";
            option1Label.Size = new Size(885, 48);
            option1Label.TabIndex = 3;
            // 
            // option2Label
            // 
            option2Label.BackColor = Color.Transparent;
            option2Label.FlatStyle = FlatStyle.Flat;
            option2Label.Font = new Font("Cinzel", 16F, FontStyle.Bold);
            option2Label.ForeColor = Color.FromArgb(255, 253, 208);
            option2Label.Location = new Point(78, 592);
            option2Label.Name = "option2Label";
            option2Label.Size = new Size(885, 48);
            option2Label.TabIndex = 4;
            // 
            // option3Button
            // 
            option3Button.BackColor = Color.Transparent;
            option3Button.BackgroundImage = Properties.Resources.button_prototype2;
            option3Button.BackgroundImageLayout = ImageLayout.Zoom;
            option3Button.FlatAppearance.BorderSize = 0;
            option3Button.FlatAppearance.CheckedBackColor = Color.Transparent;
            option3Button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            option3Button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            option3Button.FlatStyle = FlatStyle.Flat;
            option3Button.Location = new Point(12, 665);
            option3Button.Name = "option3Button";
            option3Button.Size = new Size(60, 44);
            option3Button.TabIndex = 5;
            option3Button.UseVisualStyleBackColor = false;
            // 
            // option3Label
            // 
            option3Label.BackColor = Color.Transparent;
            option3Label.FlatStyle = FlatStyle.Flat;
            option3Label.Font = new Font("Cinzel", 16F, FontStyle.Bold);
            option3Label.ForeColor = Color.FromArgb(255, 253, 208);
            option3Label.Location = new Point(78, 654);
            option3Label.Name = "option3Label";
            option3Label.Size = new Size(885, 48);
            option3Label.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.page1image;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1006, 721);
            Controls.Add(option3Label);
            Controls.Add(option3Button);
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
        private Button option3Button;
        private Label option3Label;
    }
}
