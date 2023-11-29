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
            components = new System.ComponentModel.Container();
            languageLabel = new Label();
            languageComboBox = new ComboBox();
            lightSwitchGroupBox = new GroupBox();
            offRadioButton = new RadioButton();
            onRadioButton = new RadioButton();
            lightModeGroupBox = new GroupBox();
            lightModeComboBox = new ComboBox();
            openColorPaletteButton = new Button();
            colorDialog1 = new ColorDialog();
            allPanel = new Panel();
            checkBox107 = new CheckBox();
            checkBox108 = new CheckBox();
            checkBox106 = new CheckBox();
            checkBox104 = new CheckBox();
            checkBox105 = new CheckBox();
            checkBox102 = new CheckBox();
            checkBox103 = new CheckBox();
            checkBox101 = new CheckBox();
            checkBox100 = new CheckBox();
            checkBox99 = new CheckBox();
            checkBox98 = new CheckBox();
            checkBox88 = new CheckBox();
            checkBox89 = new CheckBox();
            checkBox90 = new CheckBox();
            checkBox91 = new CheckBox();
            checkBox92 = new CheckBox();
            checkBox93 = new CheckBox();
            checkBox94 = new CheckBox();
            checkBox95 = new CheckBox();
            checkBox96 = new CheckBox();
            checkBox97 = new CheckBox();
            checkBox87 = new CheckBox();
            checkBox86 = new CheckBox();
            checkBox75 = new CheckBox();
            checkBox76 = new CheckBox();
            checkBox77 = new CheckBox();
            checkBox78 = new CheckBox();
            checkBox79 = new CheckBox();
            checkBox80 = new CheckBox();
            checkBox81 = new CheckBox();
            checkBox82 = new CheckBox();
            checkBox83 = new CheckBox();
            checkBox84 = new CheckBox();
            checkBox85 = new CheckBox();
            checkBox74 = new CheckBox();
            checkBox62 = new CheckBox();
            checkBox63 = new CheckBox();
            checkBox64 = new CheckBox();
            checkBox65 = new CheckBox();
            checkBox66 = new CheckBox();
            checkBox67 = new CheckBox();
            checkBox68 = new CheckBox();
            checkBox69 = new CheckBox();
            checkBox70 = new CheckBox();
            checkBox71 = new CheckBox();
            checkBox72 = new CheckBox();
            checkBox73 = new CheckBox();
            checkBox61 = new CheckBox();
            checkBox60 = new CheckBox();
            checkBox59 = new CheckBox();
            checkBox56 = new CheckBox();
            checkBox57 = new CheckBox();
            checkBox58 = new CheckBox();
            checkBox55 = new CheckBox();
            checkBox54 = new CheckBox();
            checkBox51 = new CheckBox();
            checkBox52 = new CheckBox();
            checkBox53 = new CheckBox();
            checkBox50 = new CheckBox();
            checkBox49 = new CheckBox();
            checkBox46 = new CheckBox();
            checkBox47 = new CheckBox();
            checkBox48 = new CheckBox();
            checkBox43 = new CheckBox();
            checkBox44 = new CheckBox();
            checkBox45 = new CheckBox();
            checkBox40 = new CheckBox();
            checkBox41 = new CheckBox();
            checkBox42 = new CheckBox();
            checkBox33 = new CheckBox();
            checkBox34 = new CheckBox();
            checkBox35 = new CheckBox();
            checkBox36 = new CheckBox();
            checkBox37 = new CheckBox();
            checkBox38 = new CheckBox();
            checkBox39 = new CheckBox();
            checkBox30 = new CheckBox();
            checkBox31 = new CheckBox();
            checkBox32 = new CheckBox();
            checkBox29 = new CheckBox();
            checkBox24 = new CheckBox();
            checkBox25 = new CheckBox();
            checkBox26 = new CheckBox();
            checkBox27 = new CheckBox();
            checkBox28 = new CheckBox();
            checkBox20 = new CheckBox();
            checkBox21 = new CheckBox();
            checkBox22 = new CheckBox();
            checkBox23 = new CheckBox();
            checkBox19 = new CheckBox();
            checkBox16 = new CheckBox();
            checkBox17 = new CheckBox();
            checkBox18 = new CheckBox();
            checkBox12 = new CheckBox();
            checkBox13 = new CheckBox();
            checkBox14 = new CheckBox();
            checkBox15 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox10 = new CheckBox();
            checkBox11 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lightSwitchGroupBox.SuspendLayout();
            lightModeGroupBox.SuspendLayout();
            allPanel.SuspendLayout();
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
            openColorPaletteButton.Text = "選擇顏色";
            openColorPaletteButton.UseVisualStyleBackColor = true;
            openColorPaletteButton.Click += openColorPaletteButton_Click;
            // 
            // allPanel
            // 
            allPanel.Controls.Add(checkBox107);
            allPanel.Controls.Add(checkBox108);
            allPanel.Controls.Add(checkBox106);
            allPanel.Controls.Add(checkBox104);
            allPanel.Controls.Add(checkBox105);
            allPanel.Controls.Add(checkBox102);
            allPanel.Controls.Add(checkBox103);
            allPanel.Controls.Add(checkBox101);
            allPanel.Controls.Add(checkBox100);
            allPanel.Controls.Add(checkBox99);
            allPanel.Controls.Add(checkBox98);
            allPanel.Controls.Add(checkBox88);
            allPanel.Controls.Add(checkBox89);
            allPanel.Controls.Add(checkBox90);
            allPanel.Controls.Add(checkBox91);
            allPanel.Controls.Add(checkBox92);
            allPanel.Controls.Add(checkBox93);
            allPanel.Controls.Add(checkBox94);
            allPanel.Controls.Add(checkBox95);
            allPanel.Controls.Add(checkBox96);
            allPanel.Controls.Add(checkBox97);
            allPanel.Controls.Add(checkBox87);
            allPanel.Controls.Add(checkBox86);
            allPanel.Controls.Add(checkBox75);
            allPanel.Controls.Add(checkBox76);
            allPanel.Controls.Add(checkBox77);
            allPanel.Controls.Add(checkBox78);
            allPanel.Controls.Add(checkBox79);
            allPanel.Controls.Add(checkBox80);
            allPanel.Controls.Add(checkBox81);
            allPanel.Controls.Add(checkBox82);
            allPanel.Controls.Add(checkBox83);
            allPanel.Controls.Add(checkBox84);
            allPanel.Controls.Add(checkBox85);
            allPanel.Controls.Add(checkBox74);
            allPanel.Controls.Add(checkBox62);
            allPanel.Controls.Add(checkBox63);
            allPanel.Controls.Add(checkBox64);
            allPanel.Controls.Add(checkBox65);
            allPanel.Controls.Add(checkBox66);
            allPanel.Controls.Add(checkBox67);
            allPanel.Controls.Add(checkBox68);
            allPanel.Controls.Add(checkBox69);
            allPanel.Controls.Add(checkBox70);
            allPanel.Controls.Add(checkBox71);
            allPanel.Controls.Add(checkBox72);
            allPanel.Controls.Add(checkBox73);
            allPanel.Controls.Add(checkBox61);
            allPanel.Controls.Add(checkBox60);
            allPanel.Controls.Add(checkBox59);
            allPanel.Controls.Add(checkBox56);
            allPanel.Controls.Add(checkBox57);
            allPanel.Controls.Add(checkBox58);
            allPanel.Controls.Add(checkBox55);
            allPanel.Controls.Add(checkBox54);
            allPanel.Controls.Add(checkBox51);
            allPanel.Controls.Add(checkBox52);
            allPanel.Controls.Add(checkBox53);
            allPanel.Controls.Add(checkBox50);
            allPanel.Controls.Add(checkBox49);
            allPanel.Controls.Add(checkBox46);
            allPanel.Controls.Add(checkBox47);
            allPanel.Controls.Add(checkBox48);
            allPanel.Controls.Add(checkBox43);
            allPanel.Controls.Add(checkBox44);
            allPanel.Controls.Add(checkBox45);
            allPanel.Controls.Add(checkBox40);
            allPanel.Controls.Add(checkBox41);
            allPanel.Controls.Add(checkBox42);
            allPanel.Controls.Add(checkBox33);
            allPanel.Controls.Add(checkBox34);
            allPanel.Controls.Add(checkBox35);
            allPanel.Controls.Add(checkBox36);
            allPanel.Controls.Add(checkBox37);
            allPanel.Controls.Add(checkBox38);
            allPanel.Controls.Add(checkBox39);
            allPanel.Controls.Add(checkBox30);
            allPanel.Controls.Add(checkBox31);
            allPanel.Controls.Add(checkBox32);
            allPanel.Controls.Add(checkBox29);
            allPanel.Controls.Add(checkBox24);
            allPanel.Controls.Add(checkBox25);
            allPanel.Controls.Add(checkBox26);
            allPanel.Controls.Add(checkBox27);
            allPanel.Controls.Add(checkBox28);
            allPanel.Controls.Add(checkBox20);
            allPanel.Controls.Add(checkBox21);
            allPanel.Controls.Add(checkBox22);
            allPanel.Controls.Add(checkBox23);
            allPanel.Controls.Add(checkBox19);
            allPanel.Controls.Add(checkBox16);
            allPanel.Controls.Add(checkBox17);
            allPanel.Controls.Add(checkBox18);
            allPanel.Controls.Add(checkBox12);
            allPanel.Controls.Add(checkBox13);
            allPanel.Controls.Add(checkBox14);
            allPanel.Controls.Add(checkBox15);
            allPanel.Controls.Add(checkBox8);
            allPanel.Controls.Add(checkBox9);
            allPanel.Controls.Add(checkBox10);
            allPanel.Controls.Add(checkBox11);
            allPanel.Controls.Add(checkBox7);
            allPanel.Controls.Add(checkBox3);
            allPanel.Controls.Add(checkBox4);
            allPanel.Controls.Add(checkBox5);
            allPanel.Controls.Add(checkBox6);
            allPanel.Controls.Add(checkBox1);
            allPanel.Controls.Add(checkBox2);
            allPanel.Location = new Point(12, 203);
            allPanel.Name = "allPanel";
            allPanel.Size = new Size(760, 263);
            allPanel.TabIndex = 134;
            // 
            // checkBox107
            // 
            checkBox107.Appearance = Appearance.Button;
            checkBox107.BackColor = SystemColors.Control;
            checkBox107.Location = new Point(655, 20);
            checkBox107.Margin = new Padding(0);
            checkBox107.Name = "checkBox107";
            checkBox107.Size = new Size(25, 25);
            checkBox107.TabIndex = 236;
            checkBox107.UseVisualStyleBackColor = false;
            // 
            // checkBox108
            // 
            checkBox108.Appearance = Appearance.Button;
            checkBox108.BackColor = SystemColors.Control;
            checkBox108.Location = new Point(624, 20);
            checkBox108.Margin = new Padding(0);
            checkBox108.Name = "checkBox108";
            checkBox108.Size = new Size(25, 25);
            checkBox108.TabIndex = 235;
            checkBox108.UseVisualStyleBackColor = false;
            // 
            // checkBox106
            // 
            checkBox106.Appearance = Appearance.Button;
            checkBox106.BackColor = SystemColors.Control;
            checkBox106.Location = new Point(134, 189);
            checkBox106.Margin = new Padding(0);
            checkBox106.Name = "checkBox106";
            checkBox106.Size = new Size(170, 25);
            checkBox106.TabIndex = 234;
            checkBox106.UseVisualStyleBackColor = false;
            // 
            // checkBox104
            // 
            checkBox104.Appearance = Appearance.Button;
            checkBox104.BackColor = SystemColors.Control;
            checkBox104.Location = new Point(54, 189);
            checkBox104.Margin = new Padding(0);
            checkBox104.Name = "checkBox104";
            checkBox104.Size = new Size(35, 25);
            checkBox104.TabIndex = 233;
            checkBox104.UseVisualStyleBackColor = false;
            // 
            // checkBox105
            // 
            checkBox105.Appearance = Appearance.Button;
            checkBox105.BackColor = SystemColors.Control;
            checkBox105.Location = new Point(95, 189);
            checkBox105.Margin = new Padding(0);
            checkBox105.Name = "checkBox105";
            checkBox105.Size = new Size(35, 25);
            checkBox105.TabIndex = 232;
            checkBox105.UseVisualStyleBackColor = false;
            // 
            // checkBox102
            // 
            checkBox102.Appearance = Appearance.Button;
            checkBox102.BackColor = SystemColors.Control;
            checkBox102.Location = new Point(307, 189);
            checkBox102.Margin = new Padding(0);
            checkBox102.Name = "checkBox102";
            checkBox102.Size = new Size(35, 25);
            checkBox102.TabIndex = 231;
            checkBox102.UseVisualStyleBackColor = false;
            // 
            // checkBox103
            // 
            checkBox103.Appearance = Appearance.Button;
            checkBox103.BackColor = SystemColors.Control;
            checkBox103.Location = new Point(348, 189);
            checkBox103.Margin = new Padding(0);
            checkBox103.Name = "checkBox103";
            checkBox103.Size = new Size(35, 25);
            checkBox103.TabIndex = 230;
            checkBox103.UseVisualStyleBackColor = false;
            // 
            // checkBox101
            // 
            checkBox101.Appearance = Appearance.Button;
            checkBox101.BackColor = SystemColors.Control;
            checkBox101.Location = new Point(388, 189);
            checkBox101.Margin = new Padding(0);
            checkBox101.Name = "checkBox101";
            checkBox101.Size = new Size(35, 25);
            checkBox101.TabIndex = 229;
            checkBox101.UseVisualStyleBackColor = false;
            // 
            // checkBox100
            // 
            checkBox100.Appearance = Appearance.Button;
            checkBox100.BackColor = SystemColors.Control;
            checkBox100.Location = new Point(429, 189);
            checkBox100.Margin = new Padding(0);
            checkBox100.Name = "checkBox100";
            checkBox100.Size = new Size(35, 25);
            checkBox100.TabIndex = 228;
            checkBox100.UseVisualStyleBackColor = false;
            // 
            // checkBox99
            // 
            checkBox99.Appearance = Appearance.Button;
            checkBox99.BackColor = SystemColors.Control;
            checkBox99.Location = new Point(12, 189);
            checkBox99.Margin = new Padding(0);
            checkBox99.Name = "checkBox99";
            checkBox99.Size = new Size(35, 25);
            checkBox99.TabIndex = 227;
            checkBox99.UseVisualStyleBackColor = false;
            // 
            // checkBox98
            // 
            checkBox98.Appearance = Appearance.Button;
            checkBox98.BackColor = SystemColors.Control;
            checkBox98.Location = new Point(394, 158);
            checkBox98.Margin = new Padding(0);
            checkBox98.Name = "checkBox98";
            checkBox98.Size = new Size(70, 25);
            checkBox98.TabIndex = 226;
            checkBox98.UseVisualStyleBackColor = false;
            // 
            // checkBox88
            // 
            checkBox88.Appearance = Appearance.Button;
            checkBox88.BackColor = SystemColors.Control;
            checkBox88.Location = new Point(364, 158);
            checkBox88.Margin = new Padding(0);
            checkBox88.Name = "checkBox88";
            checkBox88.Size = new Size(25, 25);
            checkBox88.TabIndex = 225;
            checkBox88.UseVisualStyleBackColor = false;
            // 
            // checkBox89
            // 
            checkBox89.Appearance = Appearance.Button;
            checkBox89.BackColor = SystemColors.Control;
            checkBox89.Location = new Point(334, 158);
            checkBox89.Margin = new Padding(0);
            checkBox89.Name = "checkBox89";
            checkBox89.Size = new Size(25, 25);
            checkBox89.TabIndex = 224;
            checkBox89.UseVisualStyleBackColor = false;
            // 
            // checkBox90
            // 
            checkBox90.Appearance = Appearance.Button;
            checkBox90.BackColor = SystemColors.Control;
            checkBox90.Location = new Point(273, 158);
            checkBox90.Margin = new Padding(0);
            checkBox90.Name = "checkBox90";
            checkBox90.Size = new Size(25, 25);
            checkBox90.TabIndex = 223;
            checkBox90.UseVisualStyleBackColor = false;
            // 
            // checkBox91
            // 
            checkBox91.Appearance = Appearance.Button;
            checkBox91.BackColor = SystemColors.Control;
            checkBox91.Location = new Point(304, 158);
            checkBox91.Margin = new Padding(0);
            checkBox91.Name = "checkBox91";
            checkBox91.Size = new Size(25, 25);
            checkBox91.TabIndex = 221;
            checkBox91.UseVisualStyleBackColor = false;
            // 
            // checkBox92
            // 
            checkBox92.Appearance = Appearance.Button;
            checkBox92.BackColor = SystemColors.Control;
            checkBox92.Location = new Point(242, 158);
            checkBox92.Margin = new Padding(0);
            checkBox92.Name = "checkBox92";
            checkBox92.Size = new Size(25, 25);
            checkBox92.TabIndex = 222;
            checkBox92.UseVisualStyleBackColor = false;
            // 
            // checkBox93
            // 
            checkBox93.Appearance = Appearance.Button;
            checkBox93.BackColor = SystemColors.Control;
            checkBox93.Location = new Point(212, 158);
            checkBox93.Margin = new Padding(0);
            checkBox93.Name = "checkBox93";
            checkBox93.Size = new Size(25, 25);
            checkBox93.TabIndex = 220;
            checkBox93.UseVisualStyleBackColor = false;
            // 
            // checkBox94
            // 
            checkBox94.Appearance = Appearance.Button;
            checkBox94.BackColor = SystemColors.Control;
            checkBox94.Location = new Point(181, 158);
            checkBox94.Margin = new Padding(0);
            checkBox94.Name = "checkBox94";
            checkBox94.Size = new Size(25, 25);
            checkBox94.TabIndex = 219;
            checkBox94.UseVisualStyleBackColor = false;
            // 
            // checkBox95
            // 
            checkBox95.Appearance = Appearance.Button;
            checkBox95.BackColor = SystemColors.Control;
            checkBox95.Location = new Point(120, 158);
            checkBox95.Margin = new Padding(0);
            checkBox95.Name = "checkBox95";
            checkBox95.Size = new Size(25, 25);
            checkBox95.TabIndex = 218;
            checkBox95.UseVisualStyleBackColor = false;
            // 
            // checkBox96
            // 
            checkBox96.Appearance = Appearance.Button;
            checkBox96.BackColor = SystemColors.Control;
            checkBox96.Location = new Point(151, 158);
            checkBox96.Margin = new Padding(0);
            checkBox96.Name = "checkBox96";
            checkBox96.Size = new Size(25, 25);
            checkBox96.TabIndex = 216;
            checkBox96.UseVisualStyleBackColor = false;
            // 
            // checkBox97
            // 
            checkBox97.Appearance = Appearance.Button;
            checkBox97.BackColor = SystemColors.Control;
            checkBox97.Location = new Point(89, 158);
            checkBox97.Margin = new Padding(0);
            checkBox97.Name = "checkBox97";
            checkBox97.Size = new Size(25, 25);
            checkBox97.TabIndex = 217;
            checkBox97.UseVisualStyleBackColor = false;
            // 
            // checkBox87
            // 
            checkBox87.Appearance = Appearance.Button;
            checkBox87.BackColor = SystemColors.Control;
            checkBox87.Location = new Point(12, 158);
            checkBox87.Margin = new Padding(0);
            checkBox87.Name = "checkBox87";
            checkBox87.Size = new Size(70, 25);
            checkBox87.TabIndex = 215;
            checkBox87.UseVisualStyleBackColor = false;
            // 
            // checkBox86
            // 
            checkBox86.Appearance = Appearance.Button;
            checkBox86.BackColor = SystemColors.Control;
            checkBox86.Location = new Point(414, 127);
            checkBox86.Margin = new Padding(0);
            checkBox86.Name = "checkBox86";
            checkBox86.Size = new Size(50, 25);
            checkBox86.TabIndex = 214;
            checkBox86.UseVisualStyleBackColor = false;
            // 
            // checkBox75
            // 
            checkBox75.Appearance = Appearance.Button;
            checkBox75.BackColor = SystemColors.Control;
            checkBox75.Location = new Point(379, 127);
            checkBox75.Margin = new Padding(0);
            checkBox75.Name = "checkBox75";
            checkBox75.Size = new Size(25, 25);
            checkBox75.TabIndex = 213;
            checkBox75.UseVisualStyleBackColor = false;
            // 
            // checkBox76
            // 
            checkBox76.Appearance = Appearance.Button;
            checkBox76.BackColor = SystemColors.Control;
            checkBox76.Location = new Point(349, 127);
            checkBox76.Margin = new Padding(0);
            checkBox76.Name = "checkBox76";
            checkBox76.Size = new Size(25, 25);
            checkBox76.TabIndex = 212;
            checkBox76.UseVisualStyleBackColor = false;
            // 
            // checkBox77
            // 
            checkBox77.Appearance = Appearance.Button;
            checkBox77.BackColor = SystemColors.Control;
            checkBox77.Location = new Point(288, 127);
            checkBox77.Margin = new Padding(0);
            checkBox77.Name = "checkBox77";
            checkBox77.Size = new Size(25, 25);
            checkBox77.TabIndex = 211;
            checkBox77.UseVisualStyleBackColor = false;
            // 
            // checkBox78
            // 
            checkBox78.Appearance = Appearance.Button;
            checkBox78.BackColor = SystemColors.Control;
            checkBox78.Location = new Point(319, 127);
            checkBox78.Margin = new Padding(0);
            checkBox78.Name = "checkBox78";
            checkBox78.Size = new Size(25, 25);
            checkBox78.TabIndex = 209;
            checkBox78.UseVisualStyleBackColor = false;
            // 
            // checkBox79
            // 
            checkBox79.Appearance = Appearance.Button;
            checkBox79.BackColor = SystemColors.Control;
            checkBox79.Location = new Point(257, 127);
            checkBox79.Margin = new Padding(0);
            checkBox79.Name = "checkBox79";
            checkBox79.Size = new Size(25, 25);
            checkBox79.TabIndex = 210;
            checkBox79.UseVisualStyleBackColor = false;
            // 
            // checkBox80
            // 
            checkBox80.Appearance = Appearance.Button;
            checkBox80.BackColor = SystemColors.Control;
            checkBox80.Location = new Point(227, 127);
            checkBox80.Margin = new Padding(0);
            checkBox80.Name = "checkBox80";
            checkBox80.Size = new Size(25, 25);
            checkBox80.TabIndex = 208;
            checkBox80.UseVisualStyleBackColor = false;
            // 
            // checkBox81
            // 
            checkBox81.Appearance = Appearance.Button;
            checkBox81.BackColor = SystemColors.Control;
            checkBox81.Location = new Point(196, 127);
            checkBox81.Margin = new Padding(0);
            checkBox81.Name = "checkBox81";
            checkBox81.Size = new Size(25, 25);
            checkBox81.TabIndex = 207;
            checkBox81.UseVisualStyleBackColor = false;
            // 
            // checkBox82
            // 
            checkBox82.Appearance = Appearance.Button;
            checkBox82.BackColor = SystemColors.Control;
            checkBox82.Location = new Point(135, 127);
            checkBox82.Margin = new Padding(0);
            checkBox82.Name = "checkBox82";
            checkBox82.Size = new Size(25, 25);
            checkBox82.TabIndex = 206;
            checkBox82.UseVisualStyleBackColor = false;
            // 
            // checkBox83
            // 
            checkBox83.Appearance = Appearance.Button;
            checkBox83.BackColor = SystemColors.Control;
            checkBox83.Location = new Point(166, 127);
            checkBox83.Margin = new Padding(0);
            checkBox83.Name = "checkBox83";
            checkBox83.Size = new Size(25, 25);
            checkBox83.TabIndex = 204;
            checkBox83.UseVisualStyleBackColor = false;
            // 
            // checkBox84
            // 
            checkBox84.Appearance = Appearance.Button;
            checkBox84.BackColor = SystemColors.Control;
            checkBox84.Location = new Point(104, 127);
            checkBox84.Margin = new Padding(0);
            checkBox84.Name = "checkBox84";
            checkBox84.Size = new Size(25, 25);
            checkBox84.TabIndex = 205;
            checkBox84.UseVisualStyleBackColor = false;
            // 
            // checkBox85
            // 
            checkBox85.Appearance = Appearance.Button;
            checkBox85.BackColor = SystemColors.Control;
            checkBox85.Location = new Point(74, 127);
            checkBox85.Margin = new Padding(0);
            checkBox85.Name = "checkBox85";
            checkBox85.Size = new Size(25, 25);
            checkBox85.TabIndex = 203;
            checkBox85.UseVisualStyleBackColor = false;
            // 
            // checkBox74
            // 
            checkBox74.Appearance = Appearance.Button;
            checkBox74.BackColor = SystemColors.Control;
            checkBox74.Location = new Point(12, 127);
            checkBox74.Margin = new Padding(0);
            checkBox74.Name = "checkBox74";
            checkBox74.Size = new Size(50, 25);
            checkBox74.TabIndex = 202;
            checkBox74.UseVisualStyleBackColor = false;
            // 
            // checkBox62
            // 
            checkBox62.Appearance = Appearance.Button;
            checkBox62.BackColor = SystemColors.Control;
            checkBox62.Location = new Point(363, 96);
            checkBox62.Margin = new Padding(0);
            checkBox62.Name = "checkBox62";
            checkBox62.Size = new Size(25, 25);
            checkBox62.TabIndex = 201;
            checkBox62.UseVisualStyleBackColor = false;
            // 
            // checkBox63
            // 
            checkBox63.Appearance = Appearance.Button;
            checkBox63.BackColor = SystemColors.Control;
            checkBox63.Location = new Point(394, 96);
            checkBox63.Margin = new Padding(0);
            checkBox63.Name = "checkBox63";
            checkBox63.Size = new Size(25, 25);
            checkBox63.TabIndex = 200;
            checkBox63.UseVisualStyleBackColor = false;
            // 
            // checkBox64
            // 
            checkBox64.Appearance = Appearance.Button;
            checkBox64.BackColor = SystemColors.Control;
            checkBox64.Location = new Point(333, 96);
            checkBox64.Margin = new Padding(0);
            checkBox64.Name = "checkBox64";
            checkBox64.Size = new Size(25, 25);
            checkBox64.TabIndex = 199;
            checkBox64.UseVisualStyleBackColor = false;
            // 
            // checkBox65
            // 
            checkBox65.Appearance = Appearance.Button;
            checkBox65.BackColor = SystemColors.Control;
            checkBox65.Location = new Point(272, 96);
            checkBox65.Margin = new Padding(0);
            checkBox65.Name = "checkBox65";
            checkBox65.Size = new Size(25, 25);
            checkBox65.TabIndex = 198;
            checkBox65.UseVisualStyleBackColor = false;
            // 
            // checkBox66
            // 
            checkBox66.Appearance = Appearance.Button;
            checkBox66.BackColor = SystemColors.Control;
            checkBox66.Location = new Point(303, 96);
            checkBox66.Margin = new Padding(0);
            checkBox66.Name = "checkBox66";
            checkBox66.Size = new Size(25, 25);
            checkBox66.TabIndex = 196;
            checkBox66.UseVisualStyleBackColor = false;
            // 
            // checkBox67
            // 
            checkBox67.Appearance = Appearance.Button;
            checkBox67.BackColor = SystemColors.Control;
            checkBox67.Location = new Point(241, 96);
            checkBox67.Margin = new Padding(0);
            checkBox67.Name = "checkBox67";
            checkBox67.Size = new Size(25, 25);
            checkBox67.TabIndex = 197;
            checkBox67.UseVisualStyleBackColor = false;
            // 
            // checkBox68
            // 
            checkBox68.Appearance = Appearance.Button;
            checkBox68.BackColor = SystemColors.Control;
            checkBox68.Location = new Point(211, 96);
            checkBox68.Margin = new Padding(0);
            checkBox68.Name = "checkBox68";
            checkBox68.Size = new Size(25, 25);
            checkBox68.TabIndex = 195;
            checkBox68.UseVisualStyleBackColor = false;
            // 
            // checkBox69
            // 
            checkBox69.Appearance = Appearance.Button;
            checkBox69.BackColor = SystemColors.Control;
            checkBox69.Location = new Point(180, 96);
            checkBox69.Margin = new Padding(0);
            checkBox69.Name = "checkBox69";
            checkBox69.Size = new Size(25, 25);
            checkBox69.TabIndex = 194;
            checkBox69.UseVisualStyleBackColor = false;
            // 
            // checkBox70
            // 
            checkBox70.Appearance = Appearance.Button;
            checkBox70.BackColor = SystemColors.Control;
            checkBox70.Location = new Point(119, 96);
            checkBox70.Margin = new Padding(0);
            checkBox70.Name = "checkBox70";
            checkBox70.Size = new Size(25, 25);
            checkBox70.TabIndex = 193;
            checkBox70.UseVisualStyleBackColor = false;
            // 
            // checkBox71
            // 
            checkBox71.Appearance = Appearance.Button;
            checkBox71.BackColor = SystemColors.Control;
            checkBox71.Location = new Point(150, 96);
            checkBox71.Margin = new Padding(0);
            checkBox71.Name = "checkBox71";
            checkBox71.Size = new Size(25, 25);
            checkBox71.TabIndex = 191;
            checkBox71.UseVisualStyleBackColor = false;
            // 
            // checkBox72
            // 
            checkBox72.Appearance = Appearance.Button;
            checkBox72.BackColor = SystemColors.Control;
            checkBox72.Location = new Point(88, 96);
            checkBox72.Margin = new Padding(0);
            checkBox72.Name = "checkBox72";
            checkBox72.Size = new Size(25, 25);
            checkBox72.TabIndex = 192;
            checkBox72.UseVisualStyleBackColor = false;
            // 
            // checkBox73
            // 
            checkBox73.Appearance = Appearance.Button;
            checkBox73.BackColor = SystemColors.Control;
            checkBox73.Location = new Point(58, 96);
            checkBox73.Margin = new Padding(0);
            checkBox73.Name = "checkBox73";
            checkBox73.Size = new Size(25, 25);
            checkBox73.TabIndex = 190;
            checkBox73.UseVisualStyleBackColor = false;
            // 
            // checkBox61
            // 
            checkBox61.Appearance = Appearance.Button;
            checkBox61.BackColor = SystemColors.Control;
            checkBox61.Location = new Point(424, 96);
            checkBox61.Margin = new Padding(0);
            checkBox61.Name = "checkBox61";
            checkBox61.Size = new Size(40, 25);
            checkBox61.TabIndex = 189;
            checkBox61.UseVisualStyleBackColor = false;
            // 
            // checkBox60
            // 
            checkBox60.Appearance = Appearance.Button;
            checkBox60.BackColor = SystemColors.Control;
            checkBox60.Location = new Point(12, 96);
            checkBox60.Margin = new Padding(0);
            checkBox60.Name = "checkBox60";
            checkBox60.Size = new Size(40, 25);
            checkBox60.TabIndex = 188;
            checkBox60.UseVisualStyleBackColor = false;
            // 
            // checkBox59
            // 
            checkBox59.Appearance = Appearance.Button;
            checkBox59.BackColor = SystemColors.Control;
            checkBox59.Location = new Point(542, 158);
            checkBox59.Margin = new Padding(0);
            checkBox59.Name = "checkBox59";
            checkBox59.Size = new Size(25, 25);
            checkBox59.TabIndex = 187;
            checkBox59.UseVisualStyleBackColor = false;
            // 
            // checkBox56
            // 
            checkBox56.Appearance = Appearance.Button;
            checkBox56.BackColor = SystemColors.Control;
            checkBox56.Location = new Point(572, 189);
            checkBox56.Margin = new Padding(0);
            checkBox56.Name = "checkBox56";
            checkBox56.Size = new Size(25, 25);
            checkBox56.TabIndex = 186;
            checkBox56.UseVisualStyleBackColor = false;
            // 
            // checkBox57
            // 
            checkBox57.Appearance = Appearance.Button;
            checkBox57.BackColor = SystemColors.Control;
            checkBox57.Location = new Point(511, 189);
            checkBox57.Margin = new Padding(0);
            checkBox57.Name = "checkBox57";
            checkBox57.Size = new Size(25, 25);
            checkBox57.TabIndex = 185;
            checkBox57.UseVisualStyleBackColor = false;
            // 
            // checkBox58
            // 
            checkBox58.Appearance = Appearance.Button;
            checkBox58.BackColor = SystemColors.Control;
            checkBox58.Location = new Point(542, 189);
            checkBox58.Margin = new Padding(0);
            checkBox58.Name = "checkBox58";
            checkBox58.Size = new Size(25, 25);
            checkBox58.TabIndex = 184;
            checkBox58.UseVisualStyleBackColor = false;
            // 
            // checkBox55
            // 
            checkBox55.Appearance = Appearance.Button;
            checkBox55.BackColor = SystemColors.Control;
            checkBox55.Location = new Point(625, 189);
            checkBox55.Margin = new Padding(0);
            checkBox55.Name = "checkBox55";
            checkBox55.Size = new Size(55, 25);
            checkBox55.TabIndex = 183;
            checkBox55.UseVisualStyleBackColor = false;
            // 
            // checkBox54
            // 
            checkBox54.Appearance = Appearance.Button;
            checkBox54.BackColor = SystemColors.Control;
            checkBox54.Location = new Point(686, 189);
            checkBox54.Margin = new Padding(0);
            checkBox54.Name = "checkBox54";
            checkBox54.Size = new Size(25, 25);
            checkBox54.TabIndex = 182;
            checkBox54.UseVisualStyleBackColor = false;
            // 
            // checkBox51
            // 
            checkBox51.Appearance = Appearance.Button;
            checkBox51.BackColor = SystemColors.Control;
            checkBox51.Location = new Point(625, 158);
            checkBox51.Margin = new Padding(0);
            checkBox51.Name = "checkBox51";
            checkBox51.Size = new Size(25, 25);
            checkBox51.TabIndex = 179;
            checkBox51.UseVisualStyleBackColor = false;
            // 
            // checkBox52
            // 
            checkBox52.Appearance = Appearance.Button;
            checkBox52.BackColor = SystemColors.Control;
            checkBox52.Location = new Point(655, 158);
            checkBox52.Margin = new Padding(0);
            checkBox52.Name = "checkBox52";
            checkBox52.Size = new Size(25, 25);
            checkBox52.TabIndex = 180;
            checkBox52.UseVisualStyleBackColor = false;
            // 
            // checkBox53
            // 
            checkBox53.Appearance = Appearance.Button;
            checkBox53.BackColor = SystemColors.Control;
            checkBox53.Location = new Point(686, 158);
            checkBox53.Margin = new Padding(0);
            checkBox53.Name = "checkBox53";
            checkBox53.Size = new Size(25, 25);
            checkBox53.TabIndex = 181;
            checkBox53.UseVisualStyleBackColor = false;
            // 
            // checkBox50
            // 
            checkBox50.Appearance = Appearance.Button;
            checkBox50.BackColor = SystemColors.Control;
            checkBox50.Location = new Point(717, 158);
            checkBox50.Margin = new Padding(0);
            checkBox50.Name = "checkBox50";
            checkBox50.Size = new Size(25, 56);
            checkBox50.TabIndex = 178;
            checkBox50.UseVisualStyleBackColor = false;
            // 
            // checkBox49
            // 
            checkBox49.Appearance = Appearance.Button;
            checkBox49.BackColor = SystemColors.Control;
            checkBox49.Location = new Point(717, 96);
            checkBox49.Margin = new Padding(0);
            checkBox49.Name = "checkBox49";
            checkBox49.Size = new Size(25, 56);
            checkBox49.TabIndex = 177;
            checkBox49.UseVisualStyleBackColor = false;
            // 
            // checkBox46
            // 
            checkBox46.Appearance = Appearance.Button;
            checkBox46.BackColor = SystemColors.Control;
            checkBox46.Location = new Point(625, 127);
            checkBox46.Margin = new Padding(0);
            checkBox46.Name = "checkBox46";
            checkBox46.Size = new Size(25, 25);
            checkBox46.TabIndex = 174;
            checkBox46.UseVisualStyleBackColor = false;
            // 
            // checkBox47
            // 
            checkBox47.Appearance = Appearance.Button;
            checkBox47.BackColor = SystemColors.Control;
            checkBox47.Location = new Point(655, 127);
            checkBox47.Margin = new Padding(0);
            checkBox47.Name = "checkBox47";
            checkBox47.Size = new Size(25, 25);
            checkBox47.TabIndex = 175;
            checkBox47.UseVisualStyleBackColor = false;
            // 
            // checkBox48
            // 
            checkBox48.Appearance = Appearance.Button;
            checkBox48.BackColor = SystemColors.Control;
            checkBox48.Location = new Point(686, 127);
            checkBox48.Margin = new Padding(0);
            checkBox48.Name = "checkBox48";
            checkBox48.Size = new Size(25, 25);
            checkBox48.TabIndex = 176;
            checkBox48.UseVisualStyleBackColor = false;
            // 
            // checkBox43
            // 
            checkBox43.Appearance = Appearance.Button;
            checkBox43.BackColor = SystemColors.Control;
            checkBox43.Location = new Point(625, 96);
            checkBox43.Margin = new Padding(0);
            checkBox43.Name = "checkBox43";
            checkBox43.Size = new Size(25, 25);
            checkBox43.TabIndex = 171;
            checkBox43.UseVisualStyleBackColor = false;
            // 
            // checkBox44
            // 
            checkBox44.Appearance = Appearance.Button;
            checkBox44.BackColor = SystemColors.Control;
            checkBox44.Location = new Point(655, 96);
            checkBox44.Margin = new Padding(0);
            checkBox44.Name = "checkBox44";
            checkBox44.Size = new Size(25, 25);
            checkBox44.TabIndex = 172;
            checkBox44.UseVisualStyleBackColor = false;
            // 
            // checkBox45
            // 
            checkBox45.Appearance = Appearance.Button;
            checkBox45.BackColor = SystemColors.Control;
            checkBox45.Location = new Point(686, 96);
            checkBox45.Margin = new Padding(0);
            checkBox45.Name = "checkBox45";
            checkBox45.Size = new Size(25, 25);
            checkBox45.TabIndex = 173;
            checkBox45.UseVisualStyleBackColor = false;
            // 
            // checkBox40
            // 
            checkBox40.Appearance = Appearance.Button;
            checkBox40.BackColor = SystemColors.Control;
            checkBox40.Location = new Point(572, 96);
            checkBox40.Margin = new Padding(0);
            checkBox40.Name = "checkBox40";
            checkBox40.Size = new Size(25, 25);
            checkBox40.TabIndex = 170;
            checkBox40.UseVisualStyleBackColor = false;
            // 
            // checkBox41
            // 
            checkBox41.Appearance = Appearance.Button;
            checkBox41.BackColor = SystemColors.Control;
            checkBox41.Location = new Point(511, 96);
            checkBox41.Margin = new Padding(0);
            checkBox41.Name = "checkBox41";
            checkBox41.Size = new Size(25, 25);
            checkBox41.TabIndex = 169;
            checkBox41.UseVisualStyleBackColor = false;
            // 
            // checkBox42
            // 
            checkBox42.Appearance = Appearance.Button;
            checkBox42.BackColor = SystemColors.Control;
            checkBox42.Location = new Point(542, 96);
            checkBox42.Margin = new Padding(0);
            checkBox42.Name = "checkBox42";
            checkBox42.Size = new Size(25, 25);
            checkBox42.TabIndex = 168;
            checkBox42.UseVisualStyleBackColor = false;
            // 
            // checkBox33
            // 
            checkBox33.Appearance = Appearance.Button;
            checkBox33.BackColor = SystemColors.Control;
            checkBox33.Location = new Point(572, 65);
            checkBox33.Margin = new Padding(0);
            checkBox33.Name = "checkBox33";
            checkBox33.Size = new Size(25, 25);
            checkBox33.TabIndex = 167;
            checkBox33.UseVisualStyleBackColor = false;
            // 
            // checkBox34
            // 
            checkBox34.Appearance = Appearance.Button;
            checkBox34.BackColor = SystemColors.Control;
            checkBox34.Location = new Point(511, 65);
            checkBox34.Margin = new Padding(0);
            checkBox34.Name = "checkBox34";
            checkBox34.Size = new Size(25, 25);
            checkBox34.TabIndex = 166;
            checkBox34.UseVisualStyleBackColor = false;
            // 
            // checkBox35
            // 
            checkBox35.Appearance = Appearance.Button;
            checkBox35.BackColor = SystemColors.Control;
            checkBox35.Location = new Point(542, 65);
            checkBox35.Margin = new Padding(0);
            checkBox35.Name = "checkBox35";
            checkBox35.Size = new Size(25, 25);
            checkBox35.TabIndex = 165;
            checkBox35.UseVisualStyleBackColor = false;
            // 
            // checkBox36
            // 
            checkBox36.Appearance = Appearance.Button;
            checkBox36.BackColor = SystemColors.Control;
            checkBox36.Location = new Point(717, 65);
            checkBox36.Margin = new Padding(0);
            checkBox36.Name = "checkBox36";
            checkBox36.Size = new Size(25, 25);
            checkBox36.TabIndex = 164;
            checkBox36.UseVisualStyleBackColor = false;
            // 
            // checkBox37
            // 
            checkBox37.Appearance = Appearance.Button;
            checkBox37.BackColor = SystemColors.Control;
            checkBox37.Location = new Point(625, 65);
            checkBox37.Margin = new Padding(0);
            checkBox37.Name = "checkBox37";
            checkBox37.Size = new Size(25, 25);
            checkBox37.TabIndex = 161;
            checkBox37.UseVisualStyleBackColor = false;
            // 
            // checkBox38
            // 
            checkBox38.Appearance = Appearance.Button;
            checkBox38.BackColor = SystemColors.Control;
            checkBox38.Location = new Point(655, 65);
            checkBox38.Margin = new Padding(0);
            checkBox38.Name = "checkBox38";
            checkBox38.Size = new Size(25, 25);
            checkBox38.TabIndex = 162;
            checkBox38.UseVisualStyleBackColor = false;
            // 
            // checkBox39
            // 
            checkBox39.Appearance = Appearance.Button;
            checkBox39.BackColor = SystemColors.Control;
            checkBox39.Location = new Point(686, 65);
            checkBox39.Margin = new Padding(0);
            checkBox39.Name = "checkBox39";
            checkBox39.Size = new Size(25, 25);
            checkBox39.TabIndex = 163;
            checkBox39.UseVisualStyleBackColor = false;
            // 
            // checkBox30
            // 
            checkBox30.Appearance = Appearance.Button;
            checkBox30.BackColor = SystemColors.Control;
            checkBox30.Location = new Point(378, 65);
            checkBox30.Margin = new Padding(0);
            checkBox30.Name = "checkBox30";
            checkBox30.Size = new Size(25, 25);
            checkBox30.TabIndex = 160;
            checkBox30.UseVisualStyleBackColor = false;
            // 
            // checkBox31
            // 
            checkBox31.Appearance = Appearance.Button;
            checkBox31.BackColor = SystemColors.Control;
            checkBox31.Location = new Point(317, 65);
            checkBox31.Margin = new Padding(0);
            checkBox31.Name = "checkBox31";
            checkBox31.Size = new Size(25, 25);
            checkBox31.TabIndex = 159;
            checkBox31.UseVisualStyleBackColor = false;
            // 
            // checkBox32
            // 
            checkBox32.Appearance = Appearance.Button;
            checkBox32.BackColor = SystemColors.Control;
            checkBox32.Location = new Point(348, 65);
            checkBox32.Margin = new Padding(0);
            checkBox32.Name = "checkBox32";
            checkBox32.Size = new Size(25, 25);
            checkBox32.TabIndex = 158;
            checkBox32.UseVisualStyleBackColor = false;
            // 
            // checkBox29
            // 
            checkBox29.Appearance = Appearance.Button;
            checkBox29.BackColor = SystemColors.Control;
            checkBox29.Location = new Point(409, 65);
            checkBox29.Margin = new Padding(0);
            checkBox29.Name = "checkBox29";
            checkBox29.Size = new Size(55, 25);
            checkBox29.TabIndex = 157;
            checkBox29.UseVisualStyleBackColor = false;
            // 
            // checkBox24
            // 
            checkBox24.Appearance = Appearance.Button;
            checkBox24.BackColor = SystemColors.Control;
            checkBox24.Location = new Point(287, 65);
            checkBox24.Margin = new Padding(0);
            checkBox24.Name = "checkBox24";
            checkBox24.Size = new Size(25, 25);
            checkBox24.TabIndex = 156;
            checkBox24.UseVisualStyleBackColor = false;
            // 
            // checkBox25
            // 
            checkBox25.Appearance = Appearance.Button;
            checkBox25.BackColor = SystemColors.Control;
            checkBox25.Location = new Point(226, 65);
            checkBox25.Margin = new Padding(0);
            checkBox25.Name = "checkBox25";
            checkBox25.Size = new Size(25, 25);
            checkBox25.TabIndex = 155;
            checkBox25.UseVisualStyleBackColor = false;
            // 
            // checkBox26
            // 
            checkBox26.Appearance = Appearance.Button;
            checkBox26.BackColor = SystemColors.Control;
            checkBox26.Location = new Point(257, 65);
            checkBox26.Margin = new Padding(0);
            checkBox26.Name = "checkBox26";
            checkBox26.Size = new Size(25, 25);
            checkBox26.TabIndex = 153;
            checkBox26.UseVisualStyleBackColor = false;
            // 
            // checkBox27
            // 
            checkBox27.Appearance = Appearance.Button;
            checkBox27.BackColor = SystemColors.Control;
            checkBox27.Location = new Point(195, 65);
            checkBox27.Margin = new Padding(0);
            checkBox27.Name = "checkBox27";
            checkBox27.Size = new Size(25, 25);
            checkBox27.TabIndex = 154;
            checkBox27.UseVisualStyleBackColor = false;
            // 
            // checkBox28
            // 
            checkBox28.Appearance = Appearance.Button;
            checkBox28.BackColor = SystemColors.Control;
            checkBox28.Location = new Point(165, 65);
            checkBox28.Margin = new Padding(0);
            checkBox28.Name = "checkBox28";
            checkBox28.Size = new Size(25, 25);
            checkBox28.TabIndex = 152;
            checkBox28.UseVisualStyleBackColor = false;
            // 
            // checkBox20
            // 
            checkBox20.Appearance = Appearance.Button;
            checkBox20.BackColor = SystemColors.Control;
            checkBox20.Location = new Point(134, 65);
            checkBox20.Margin = new Padding(0);
            checkBox20.Name = "checkBox20";
            checkBox20.Size = new Size(25, 25);
            checkBox20.TabIndex = 151;
            checkBox20.UseVisualStyleBackColor = false;
            // 
            // checkBox21
            // 
            checkBox21.Appearance = Appearance.Button;
            checkBox21.BackColor = SystemColors.Control;
            checkBox21.Location = new Point(73, 65);
            checkBox21.Margin = new Padding(0);
            checkBox21.Name = "checkBox21";
            checkBox21.Size = new Size(25, 25);
            checkBox21.TabIndex = 150;
            checkBox21.UseVisualStyleBackColor = false;
            // 
            // checkBox22
            // 
            checkBox22.Appearance = Appearance.Button;
            checkBox22.BackColor = SystemColors.Control;
            checkBox22.Location = new Point(104, 65);
            checkBox22.Margin = new Padding(0);
            checkBox22.Name = "checkBox22";
            checkBox22.Size = new Size(25, 25);
            checkBox22.TabIndex = 148;
            checkBox22.UseVisualStyleBackColor = false;
            // 
            // checkBox23
            // 
            checkBox23.Appearance = Appearance.Button;
            checkBox23.BackColor = SystemColors.Control;
            checkBox23.Location = new Point(42, 65);
            checkBox23.Margin = new Padding(0);
            checkBox23.Name = "checkBox23";
            checkBox23.Size = new Size(25, 25);
            checkBox23.TabIndex = 149;
            checkBox23.UseVisualStyleBackColor = false;
            // 
            // checkBox19
            // 
            checkBox19.Appearance = Appearance.Button;
            checkBox19.BackColor = SystemColors.Control;
            checkBox19.Location = new Point(12, 65);
            checkBox19.Margin = new Padding(0);
            checkBox19.Name = "checkBox19";
            checkBox19.Size = new Size(25, 25);
            checkBox19.TabIndex = 147;
            checkBox19.UseVisualStyleBackColor = false;
            // 
            // checkBox16
            // 
            checkBox16.Appearance = Appearance.Button;
            checkBox16.BackColor = SystemColors.Control;
            checkBox16.Location = new Point(572, 20);
            checkBox16.Margin = new Padding(0);
            checkBox16.Name = "checkBox16";
            checkBox16.Size = new Size(25, 25);
            checkBox16.TabIndex = 146;
            checkBox16.UseVisualStyleBackColor = false;
            // 
            // checkBox17
            // 
            checkBox17.Appearance = Appearance.Button;
            checkBox17.BackColor = SystemColors.Control;
            checkBox17.Location = new Point(511, 20);
            checkBox17.Margin = new Padding(0);
            checkBox17.Name = "checkBox17";
            checkBox17.Size = new Size(25, 25);
            checkBox17.TabIndex = 145;
            checkBox17.UseVisualStyleBackColor = false;
            // 
            // checkBox18
            // 
            checkBox18.Appearance = Appearance.Button;
            checkBox18.BackColor = SystemColors.Control;
            checkBox18.Location = new Point(542, 20);
            checkBox18.Margin = new Padding(0);
            checkBox18.Name = "checkBox18";
            checkBox18.Size = new Size(25, 25);
            checkBox18.TabIndex = 144;
            checkBox18.UseVisualStyleBackColor = false;
            // 
            // checkBox12
            // 
            checkBox12.Appearance = Appearance.Button;
            checkBox12.BackColor = SystemColors.Control;
            checkBox12.Location = new Point(439, 20);
            checkBox12.Margin = new Padding(0);
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size(25, 25);
            checkBox12.TabIndex = 143;
            checkBox12.UseVisualStyleBackColor = false;
            // 
            // checkBox13
            // 
            checkBox13.Appearance = Appearance.Button;
            checkBox13.BackColor = SystemColors.Control;
            checkBox13.Location = new Point(378, 20);
            checkBox13.Margin = new Padding(0);
            checkBox13.Name = "checkBox13";
            checkBox13.Size = new Size(25, 25);
            checkBox13.TabIndex = 142;
            checkBox13.UseVisualStyleBackColor = false;
            // 
            // checkBox14
            // 
            checkBox14.Appearance = Appearance.Button;
            checkBox14.BackColor = SystemColors.Control;
            checkBox14.Location = new Point(409, 20);
            checkBox14.Margin = new Padding(0);
            checkBox14.Name = "checkBox14";
            checkBox14.Size = new Size(25, 25);
            checkBox14.TabIndex = 140;
            checkBox14.UseVisualStyleBackColor = false;
            // 
            // checkBox15
            // 
            checkBox15.Appearance = Appearance.Button;
            checkBox15.BackColor = SystemColors.Control;
            checkBox15.Location = new Point(347, 20);
            checkBox15.Margin = new Padding(0);
            checkBox15.Name = "checkBox15";
            checkBox15.Size = new Size(25, 25);
            checkBox15.TabIndex = 141;
            checkBox15.UseVisualStyleBackColor = false;
            // 
            // checkBox8
            // 
            checkBox8.Appearance = Appearance.Button;
            checkBox8.BackColor = SystemColors.Control;
            checkBox8.Location = new Point(301, 20);
            checkBox8.Margin = new Padding(0);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(25, 25);
            checkBox8.TabIndex = 139;
            checkBox8.UseVisualStyleBackColor = false;
            // 
            // checkBox9
            // 
            checkBox9.Appearance = Appearance.Button;
            checkBox9.BackColor = SystemColors.Control;
            checkBox9.Location = new Point(240, 20);
            checkBox9.Margin = new Padding(0);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(25, 25);
            checkBox9.TabIndex = 138;
            checkBox9.UseVisualStyleBackColor = false;
            // 
            // checkBox10
            // 
            checkBox10.Appearance = Appearance.Button;
            checkBox10.BackColor = SystemColors.Control;
            checkBox10.Location = new Point(271, 20);
            checkBox10.Margin = new Padding(0);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(25, 25);
            checkBox10.TabIndex = 136;
            checkBox10.UseVisualStyleBackColor = false;
            // 
            // checkBox11
            // 
            checkBox11.Appearance = Appearance.Button;
            checkBox11.BackColor = SystemColors.Control;
            checkBox11.Location = new Point(209, 20);
            checkBox11.Margin = new Padding(0);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(25, 25);
            checkBox11.TabIndex = 137;
            checkBox11.UseVisualStyleBackColor = false;
            // 
            // checkBox7
            // 
            checkBox7.Appearance = Appearance.Button;
            checkBox7.BackColor = SystemColors.Control;
            checkBox7.Location = new Point(165, 20);
            checkBox7.Margin = new Padding(0);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(25, 25);
            checkBox7.TabIndex = 135;
            checkBox7.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            checkBox3.Appearance = Appearance.Button;
            checkBox3.BackColor = SystemColors.Control;
            checkBox3.Location = new Point(104, 20);
            checkBox3.Margin = new Padding(0);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(25, 25);
            checkBox3.TabIndex = 134;
            checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox4
            // 
            checkBox4.Appearance = Appearance.Button;
            checkBox4.BackColor = SystemColors.Control;
            checkBox4.Location = new Point(12, 20);
            checkBox4.Margin = new Padding(0);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(25, 25);
            checkBox4.TabIndex = 131;
            checkBox4.UseVisualStyleBackColor = false;
            // 
            // checkBox5
            // 
            checkBox5.Appearance = Appearance.Button;
            checkBox5.BackColor = SystemColors.Control;
            checkBox5.Location = new Point(135, 20);
            checkBox5.Margin = new Padding(0);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(25, 25);
            checkBox5.TabIndex = 132;
            checkBox5.UseVisualStyleBackColor = false;
            // 
            // checkBox6
            // 
            checkBox6.Appearance = Appearance.Button;
            checkBox6.BackColor = SystemColors.Control;
            checkBox6.Location = new Point(73, 20);
            checkBox6.Margin = new Padding(0);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(25, 25);
            checkBox6.TabIndex = 133;
            checkBox6.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.Appearance = Appearance.Button;
            checkBox1.BackColor = SystemColors.Control;
            checkBox1.Location = new Point(717, 20);
            checkBox1.Margin = new Padding(0);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(25, 25);
            checkBox1.TabIndex = 130;
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            checkBox2.Appearance = Appearance.Button;
            checkBox2.BackColor = SystemColors.Control;
            checkBox2.Location = new Point(686, 20);
            checkBox2.Margin = new Padding(0);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(25, 25);
            checkBox2.TabIndex = 129;
            checkBox2.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(784, 561);
            Controls.Add(allPanel);
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
            allPanel.ResumeLayout(false);
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
        private Button escButton;
        private Button f1Button;
        private Button f2Button;
        private Button f3Button;
        private Panel allPanel;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox7;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox16;
        private CheckBox checkBox17;
        private CheckBox checkBox18;
        private CheckBox checkBox12;
        private CheckBox checkBox13;
        private CheckBox checkBox14;
        private CheckBox checkBox15;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
        private CheckBox checkBox11;
        private CheckBox checkBox30;
        private CheckBox checkBox31;
        private CheckBox checkBox32;
        private CheckBox checkBox29;
        private CheckBox checkBox24;
        private CheckBox checkBox25;
        private CheckBox checkBox26;
        private CheckBox checkBox27;
        private CheckBox checkBox28;
        private CheckBox checkBox20;
        private CheckBox checkBox21;
        private CheckBox checkBox22;
        private CheckBox checkBox23;
        private CheckBox checkBox19;
        private CheckBox checkBox59;
        private CheckBox checkBox56;
        private CheckBox checkBox57;
        private CheckBox checkBox58;
        private CheckBox checkBox55;
        private CheckBox checkBox54;
        private CheckBox checkBox51;
        private CheckBox checkBox52;
        private CheckBox checkBox53;
        private CheckBox checkBox50;
        private CheckBox checkBox49;
        private CheckBox checkBox46;
        private CheckBox checkBox47;
        private CheckBox checkBox48;
        private CheckBox checkBox43;
        private CheckBox checkBox44;
        private CheckBox checkBox45;
        private CheckBox checkBox40;
        private CheckBox checkBox41;
        private CheckBox checkBox42;
        private CheckBox checkBox33;
        private CheckBox checkBox34;
        private CheckBox checkBox35;
        private CheckBox checkBox36;
        private CheckBox checkBox37;
        private CheckBox checkBox38;
        private CheckBox checkBox39;
        private CheckBox checkBox60;
        private CheckBox checkBox87;
        private CheckBox checkBox86;
        private CheckBox checkBox75;
        private CheckBox checkBox76;
        private CheckBox checkBox77;
        private CheckBox checkBox78;
        private CheckBox checkBox79;
        private CheckBox checkBox80;
        private CheckBox checkBox81;
        private CheckBox checkBox82;
        private CheckBox checkBox83;
        private CheckBox checkBox84;
        private CheckBox checkBox85;
        private CheckBox checkBox74;
        private CheckBox checkBox62;
        private CheckBox checkBox63;
        private CheckBox checkBox64;
        private CheckBox checkBox65;
        private CheckBox checkBox66;
        private CheckBox checkBox67;
        private CheckBox checkBox68;
        private CheckBox checkBox69;
        private CheckBox checkBox70;
        private CheckBox checkBox71;
        private CheckBox checkBox72;
        private CheckBox checkBox73;
        private CheckBox checkBox61;
        private CheckBox checkBox106;
        private CheckBox checkBox104;
        private CheckBox checkBox105;
        private CheckBox checkBox102;
        private CheckBox checkBox103;
        private CheckBox checkBox101;
        private CheckBox checkBox100;
        private CheckBox checkBox99;
        private CheckBox checkBox98;
        private CheckBox checkBox88;
        private CheckBox checkBox89;
        private CheckBox checkBox90;
        private CheckBox checkBox91;
        private CheckBox checkBox92;
        private CheckBox checkBox93;
        private CheckBox checkBox94;
        private CheckBox checkBox95;
        private CheckBox checkBox96;
        private CheckBox checkBox97;
        private CheckBox checkBox107;
        private CheckBox checkBox108;
        private System.Windows.Forms.Timer timer1;
    }
}