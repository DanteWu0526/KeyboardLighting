using System.Windows.Forms;

namespace KeyboardLighting
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 語言陣列
        /// </summary>
        string[] languageArr = { "English", "中文" };
        /// <summary>
        /// 中文燈光陣列
        /// </summary>
        string[] lightModeChArr = { "恆亮", "呼吸", "自訂" };
        /// <summary>
        /// 英文燈光陣列
        /// </summary>
        string[] lightModeEnArr = { "Always bright", "Respire", "Customize" };

        private Color currentColor;
        private System.Windows.Forms.Timer brightnessTimer;

        public Form1()
        {
            InitializeComponent();
            Initial();
        }

        #region 自訂邏輯區
        /// <summary>
        /// 初始化
        /// </summary>
        private void Initial()
        {
            LanguageComboBoxAdd();
            languageComboBox.SelectedIndex = 0;
            onRadioButton.Checked = true;
            lightModeComboBox.SelectedIndex = 0;
            selectFunctionGroupBox.Visible = false;
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
                selectFunctionGroupBox.Text = "Customize select function:";
                alwaysBrightRadioButton.Text = "Always bright";
                respireRadioButton.Text = "Respire";
            }
            else
            {
                lightSwitchGroupBox.Text = "鍵盤燈光開關:";
                onRadioButton.Text = "開";
                offRadioButton.Text = "關";

                lightModeGroupBox.Text = "燈光模式:";
                LightModeChage(lightModeChArr);
                openColorPaletteButton.Text = "選擇顏色";
                selectFunctionGroupBox.Text = "自訂選擇功能:";
                alwaysBrightRadioButton.Text = "恆亮";
                respireRadioButton.Text = "呼吸";
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

        /// <summary>
        /// 依選擇模式改變顏色邏輯
        /// </summary>
        private void ChangeColor()
        {
            if (lightModeComboBox.SelectedIndex == 0)
            {
                AlwaysBright();
            }
            else if (lightModeComboBox.SelectedIndex == 1)
            {
                Respire();
            }
            else
            {
                CustomizeFunction();
            }
        }

        /// <summary>
        /// 燈光恆亮邏輯
        /// </summary>
        private void AlwaysBright()
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (Control control in allPanel.Controls)
                {
                    control.BackColor = colorDialog1.Color;
                }
            }
        }

        /// <summary>
        /// 呼吸燈邏輯
        /// </summary>
        private void Respire()
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

        /// <summary>
        /// 自訂燈號邏輯
        /// </summary>
        private void CustomizeFunction()
        {
            List<Object> checkedItems = GetCheckedCheckBoxes();

            if (alwaysBrightRadioButton.Checked == true)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    foreach (Control control in checkedItems)
                    {
                        control.BackColor = colorDialog1.Color;
                    }
                }
            }
            else if (respireRadioButton.Checked == true)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    foreach (Control control in checkedItems)
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
            else
            {
                return;
            }
        }

        /// <summary>
        /// 取得所選擇的CheckBox邏輯
        /// </summary>
        /// <returns>選擇的CheckBox</returns>
        private List<Object> GetCheckedCheckBoxes()
        {
            List<Object> checkedItems = new List<Object>();
            foreach (Control control in allPanel.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    checkedItems.Add(checkBox);
                }
            }
            return checkedItems;
        }
        #endregion

        #region 表單控制區
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
        /// 呼吸燈計算功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            double breathingValue = (Math.Sin(DateTime.Now.Ticks / 10000000.0) + 1) / 2;
            Color newColor = ControlPaint.Light(currentColor, (float)breathingValue);

            if (lightModeComboBox.SelectedIndex != 2)
            {
                foreach (Control control in allPanel.Controls)
                {
                    control.BackColor = newColor;
                }
            }
            else
            {
                List<Object> checkedItems = GetCheckedCheckBoxes();
                foreach (Control control in checkedItems)
                {
                    control.BackColor = newColor;
                }
            }
        }

        private void lightModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lightModeComboBox.SelectedIndex == 2)
            {
                selectFunctionGroupBox.Visible = true;
            }
        }
        #endregion

    }
}