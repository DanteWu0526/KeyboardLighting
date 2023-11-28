namespace KeyboardLighting
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
            languageLabel = new Label();
            languageComboBox = new ComboBox();
            lightSwitchGroupBox = new GroupBox();
            offRadioButton = new RadioButton();
            onRadioButton = new RadioButton();
            lightModeGroupBox = new GroupBox();
            lightModeComboBox = new ComboBox();
            openColorPaletteButton = new Button();
            colorDialog1 = new ColorDialog();
            lightSwitchGroupBox.SuspendLayout();
            lightModeGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // languageLabel
            // 
            languageLabel.AutoSize = true;
            languageLabel.Location = new Point(12, 9);
            languageLabel.Name = "languageLabel";
            languageLabel.Size = new Size(88, 20);
            languageLabel.TabIndex = 1;
            languageLabel.Text = "Language:";
            // 
            // languageComboBox
            // 
            languageComboBox.FormattingEnabled = true;
            languageComboBox.Location = new Point(106, 5);
            languageComboBox.Name = "languageComboBox";
            languageComboBox.Size = new Size(120, 28);
            languageComboBox.TabIndex = 2;
            languageComboBox.SelectedIndexChanged += languageComboBox_SelectedIndexChanged;
            // 
            // lightSwitchGroupBox
            // 
            lightSwitchGroupBox.BackColor = SystemColors.ActiveCaptionText;
            lightSwitchGroupBox.Controls.Add(offRadioButton);
            lightSwitchGroupBox.Controls.Add(onRadioButton);
            lightSwitchGroupBox.ForeColor = SystemColors.ControlLightLight;
            lightSwitchGroupBox.Location = new Point(12, 43);
            lightSwitchGroupBox.Name = "lightSwitchGroupBox";
            lightSwitchGroupBox.Size = new Size(214, 65);
            lightSwitchGroupBox.TabIndex = 3;
            lightSwitchGroupBox.TabStop = false;
            lightSwitchGroupBox.Text = "keyboard light switch:";
            // 
            // offRadioButton
            // 
            offRadioButton.AutoSize = true;
            offRadioButton.Location = new Point(152, 27);
            offRadioButton.Name = "offRadioButton";
            offRadioButton.Size = new Size(56, 24);
            offRadioButton.TabIndex = 1;
            offRadioButton.TabStop = true;
            offRadioButton.Text = "OFF";
            offRadioButton.UseVisualStyleBackColor = true;
            offRadioButton.CheckedChanged += offRadioButton_CheckedChanged;
            // 
            // onRadioButton
            // 
            onRadioButton.AutoSize = true;
            onRadioButton.Location = new Point(6, 27);
            onRadioButton.Name = "onRadioButton";
            onRadioButton.Size = new Size(53, 24);
            onRadioButton.TabIndex = 0;
            onRadioButton.TabStop = true;
            onRadioButton.Text = "ON";
            onRadioButton.UseVisualStyleBackColor = true;
            onRadioButton.CheckedChanged += onRadioButton_CheckedChanged;
            // 
            // lightModeGroupBox
            // 
            lightModeGroupBox.BackColor = SystemColors.ActiveCaptionText;
            lightModeGroupBox.Controls.Add(lightModeComboBox);
            lightModeGroupBox.ForeColor = SystemColors.ControlLightLight;
            lightModeGroupBox.Location = new Point(232, 12);
            lightModeGroupBox.Name = "lightModeGroupBox";
            lightModeGroupBox.Size = new Size(210, 96);
            lightModeGroupBox.TabIndex = 4;
            lightModeGroupBox.TabStop = false;
            lightModeGroupBox.Text = "light mode:";
            // 
            // lightModeComboBox
            // 
            lightModeComboBox.FormattingEnabled = true;
            lightModeComboBox.Location = new Point(6, 42);
            lightModeComboBox.Name = "lightModeComboBox";
            lightModeComboBox.Size = new Size(198, 28);
            lightModeComboBox.TabIndex = 5;
            // 
            // openColorPaletteButton
            // 
            openColorPaletteButton.ForeColor = SystemColors.ActiveCaptionText;
            openColorPaletteButton.Location = new Point(458, 43);
            openColorPaletteButton.Name = "openColorPaletteButton";
            openColorPaletteButton.Size = new Size(191, 35);
            openColorPaletteButton.TabIndex = 5;
            openColorPaletteButton.Text = "開啟調色盤";
            openColorPaletteButton.UseVisualStyleBackColor = true;
            openColorPaletteButton.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(784, 561);
            Controls.Add(openColorPaletteButton);
            Controls.Add(lightModeGroupBox);
            Controls.Add(lightSwitchGroupBox);
            Controls.Add(languageComboBox);
            Controls.Add(languageLabel);
            Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.Control;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "主選單";
            lightSwitchGroupBox.ResumeLayout(false);
            lightSwitchGroupBox.PerformLayout();
            lightModeGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label languageLabel;
        private ComboBox languageComboBox;
        private GroupBox lightSwitchGroupBox;
        private RadioButton onRadioButton;
        private RadioButton offRadioButton;
        private GroupBox lightModeGroupBox;
        private ComboBox lightModeComboBox;
        private Button openColorPaletteButton;
        private ColorDialog colorDialog1;
    }
}