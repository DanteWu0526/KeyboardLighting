using System.Windows.Forms;

namespace KeyboardLighting
{
    public partial class Form1 : Form
    {
        string[] languageArr = { "English", "中文" };
        string[] lightModeChArr = { "恆亮", "呼吸" };
        string[] lightModeEnArr = { "Always bright", "respire" };

        private Color currentColor;
        private System.Windows.Forms.Timer brightnessTimer;
        public Form1()
        {
            InitializeComponent();
            Initial();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void Initial()
        {
            LanguageComboBoxAdd();
            languageComboBox.SelectedIndex = 0;
            onRadioButton.Checked = true;
            lightModeComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// 增加語言種類功能
        /// </summary>
        private void LanguageComboBoxAdd()
        {
            languageComboBox.Items.AddRange(languageArr);
        }

        /// <summary>
        /// 更改語言
        /// </summary>
        private void LanguageChange()
        {
            if (languageComboBox.SelectedIndex == 0)
            {
                lightSwitchGroupBox.Text = "keyboard light switch:";
                onRadioButton.Text = "ON";
                offRadioButton.Text = "Off";

                lightModeGroupBox.Text = "light mode:";
                LightModeChage(lightModeEnArr);
                openColorPaletteButton.Text = "choose the color";
            }
            else
            {
                lightSwitchGroupBox.Text = "鍵盤燈光開關:";
                onRadioButton.Text = "開";
                offRadioButton.Text = "關";

                lightModeGroupBox.Text = "燈光模式:";
                LightModeChage(lightModeChArr);
                openColorPaletteButton.Text = "選擇顏色";
            }
        }

        /// <summary>
        /// 燈光模式切換
        /// </summary>
        /// <param name="strs">字串陣列</param>
        private void LightModeChage(string[] strs)
        {
            lightModeComboBox.Items.Clear();
            lightModeComboBox.Items.AddRange(strs);
        }

        private void ChangeColor()
        {
            if (lightModeComboBox.SelectedIndex == 0)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    foreach (Control control in allPanel.Controls)
                    {
                        control.BackColor = colorDialog1.Color;
                    }
                }
            }
            else if (lightModeComboBox.SelectedIndex == 1)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    foreach (Control control in allPanel.Controls)
                    {
                        currentColor = colorDialog1.Color;
                        brightnessTimer = new System.Windows.Forms.Timer();
                        brightnessTimer.Interval = 50;
                        brightnessTimer.Tick += timer1_Tick;
                        brightnessTimer.Start();
                        control.BackColor = currentColor;
                    }
                }
            }
        }

        private void onRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            lightModeGroupBox.Visible = true;
        }

        private void offRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            lightModeGroupBox.Visible = false;
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LanguageChange();
        }

        private void openColorPaletteButton_Click(object sender, EventArgs e)
        {
            ChangeColor();
        }

        /// <summary>
        /// 呼吸燈功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            double breathingValue = (Math.Sin(DateTime.Now.Ticks / 10000000.0) + 1) / 2;
            Color newColor = ControlPaint.Light(currentColor, (float)breathingValue);
            foreach (Control control in allPanel.Controls)
            {
                control.BackColor = newColor;
            }
        }

    }
}