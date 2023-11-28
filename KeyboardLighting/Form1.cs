using System.Windows.Forms;

namespace KeyboardLighting
{
    public partial class Form1 : Form
    {
        string[] languageArr = { "English", "中文" };
        string[] lightModeChArr = { "恆亮", "呼吸" };
        string[] lightModeEnArr = { "Always bright", "respire" };
        public Form1()
        {
            InitializeComponent();
            Initial();
            //this.button1.Click += new System.EventHandler(this.button1_Click);
        }

        private void Initial()
        {
            LanguageComboBoxAdd();
            languageComboBox.SelectedIndex = 0;
            onRadioButton.Checked = true;
            lightModeComboBox.SelectedIndex = 0;
        }

        private void LanguageComboBoxAdd()
        {
            languageComboBox.Items.AddRange(languageArr);
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //這邊寫要改顏色的邏輯
                foreach (Control control in allPanel.Controls)
                {
                    control.BackColor = colorDialog1.Color;
                }
                //allPanel.BackColor = colorDialog1.Color;
            }
        }
    }
}