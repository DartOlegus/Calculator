namespace Calculator
{
    public partial class Form1 : Form
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal result = 0.0m;
        private decimal memory = 0.0m;
        private string operators = "+";
        private bool isLight = true;
        enum ThemeColor
        {
            Primary,
            Text
        }
        Dictionary<ThemeColor, Color> Light = new Dictionary<ThemeColor, Color>();
        Dictionary<ThemeColor, Color> Dark = new Dictionary<ThemeColor, Color>();
        public Form1()
        {
            InitializeComponent();
            Light = new Dictionary<ThemeColor, Color>()
            {
                { ThemeColor.Primary, SystemColors.Control },
                { ThemeColor.Text, SystemColors.ControlText }
            };
            Dark = new Dictionary<ThemeColor, Color>()
            {
                { ThemeColor.Primary, Color.Black },
                { ThemeColor.Text, Color.White }
            };
        }
        private void ChangeTheme(Color primaryColor, Color textColor)
        {
            this.BackColor = primaryColor;
            TxtBox.BackColor = primaryColor;
            ThemeBtn.BackColor = primaryColor;
            ZeroBtn.BackColor = primaryColor;
            DotBtn.BackColor = primaryColor;
            EqualBtn.BackColor = primaryColor;
            OneBtn.BackColor = primaryColor;
            TwoBtn.BackColor = primaryColor;
            ThreeBtn.BackColor = primaryColor;
            FourBtn.BackColor = primaryColor;
            FiveBtn.BackColor = primaryColor;
            SixBtn.BackColor = primaryColor;
            SevenBtn.BackColor = primaryColor;
            EightBtn.BackColor = primaryColor;
            NineBtn.BackColor = primaryColor;
            MSaveBtn.BackColor = primaryColor;
            MReadBtn.BackColor = primaryColor;
            MClearBtn.BackColor = primaryColor;
            MPlusBtn.BackColor = primaryColor;
            MMinusBtn.BackColor = primaryColor;
            ClearBtn.BackColor = primaryColor;
            MinusBtn.BackColor = primaryColor;
            PlusBtn.BackColor = primaryColor;
            DivideBtn.BackColor = primaryColor;
            MultiplyBtn.BackColor = primaryColor;
            MinusPlusBtn.BackColor = primaryColor;
            PercentBtn.BackColor = primaryColor;
            TxtBox.ForeColor = textColor;
            ZeroBtn.ForeColor = textColor;
            DotBtn.ForeColor = textColor;
            EqualBtn.ForeColor = textColor;
            OneBtn.ForeColor = textColor;
            TwoBtn.ForeColor = textColor;
            ThreeBtn.ForeColor = textColor;
            FourBtn.ForeColor = textColor;
            FiveBtn.ForeColor = textColor;
            SixBtn.ForeColor = textColor;
            SevenBtn.ForeColor = textColor;
            EightBtn.ForeColor = textColor;
            NineBtn.ForeColor = textColor;
            MSaveBtn.ForeColor = textColor;
            MReadBtn.ForeColor = textColor;
            MClearBtn.ForeColor = textColor;
            MPlusBtn.ForeColor = textColor;
            MMinusBtn.ForeColor = textColor;
            ClearBtn.ForeColor = textColor;
            MinusBtn.ForeColor = textColor;
            PlusBtn.ForeColor = textColor;
            DivideBtn.ForeColor = textColor;
            MultiplyBtn.ForeColor = textColor;
            MinusPlusBtn.ForeColor = textColor;
            PercentBtn.ForeColor = textColor;

        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "0";
            }
            else TxtBox.Text += "0";
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            if (!TxtBox.Text.Contains("."))
            {
                TxtBox.Text += ".";
            }
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "1";
            }
            else TxtBox.Text += "1";
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            {
                if (TxtBox.Text == "0")
                {
                    TxtBox.Text = "2";
                }
                else TxtBox.Text += "2";
            }
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            {
                if (TxtBox.Text == "0")
                {
                    TxtBox.Text = "3";
                }
                else TxtBox.Text += "3";
            }
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            {
                if (TxtBox.Text == "0")
                {
                    TxtBox.Text = "4";
                }
                else TxtBox.Text += "4";
            }
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            {
                if (TxtBox.Text == "0")
                {
                    TxtBox.Text = "5";
                }
                else TxtBox.Text += "5";
            }
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            {
                if (TxtBox.Text == "0")
                {
                    TxtBox.Text = "6";
                }
                else TxtBox.Text += "6";
            }
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            {
                if (TxtBox.Text == "0")
                {
                    TxtBox.Text = "7";
                }
                else TxtBox.Text += "7";
            }
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            {
                if (TxtBox.Text == "0")
                {
                    TxtBox.Text = "8";
                }
                else TxtBox.Text += "8";
            }
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            {
                if (TxtBox.Text == "0")
                {
                    TxtBox.Text = "9";
                }
                else TxtBox.Text += "9";
            }
        }

        private void MinusPlusBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text.Contains("-"))
            {
                TxtBox.Text = TxtBox.Text.Trim('-');
            }
            else TxtBox.Text = "-" + TxtBox.Text;
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Text = "0";
            operators = "-";
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Text = "0";
            operators = "+";
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Text = "0";
            operators = "/";
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Text = "0";
            operators = "*";
        }

        private void PercentBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TxtBox.Text);
            TxtBox.Text = "0";
            operators = "%";
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    result = valueFirst - valueSecond;
                    TxtBox.Text = result.ToString();
                    break;
                case "+":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    result = valueFirst + valueSecond;
                    TxtBox.Text = result.ToString();
                    break;
                case "*":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    result = valueFirst * valueSecond;
                    TxtBox.Text = result.ToString();
                    break;
                case "/":
                    try
                    {
                        valueSecond = decimal.Parse(TxtBox.Text);
                        result = valueFirst / valueSecond;
                        TxtBox.Text = result.ToString();
                    }
                    catch (DivideByZeroException)
                    {
                        TxtBox.Text = "0";
                        MessageBox.Show("На ноль делить нельзя!");
                    }
                    break;
                case "%":
                    try
                    {
                        valueSecond = decimal.Parse(TxtBox.Text);
                        result = valueFirst % valueSecond;
                        TxtBox.Text = result.ToString();
                    }
                    catch (DivideByZeroException)
                    {
                        TxtBox.Text = "0";
                        MessageBox.Show("На ноль делить нельзя!");
                    }
                    break;
            }
        }
        private void MSaveBtn_Click(object sender, EventArgs e)
        {
            memory = decimal.Parse(TxtBox.Text);
        }

        private void MReadBtn_Click(object sender, EventArgs e)
        {
            TxtBox.Text = memory.ToString();
        }

        private void MClearBtn_Click(object sender, EventArgs e)
        {
            TxtBox.Text = "0";
            memory = 0.0m;
        }

        private void MPlusBtn_Click(object sender, EventArgs e)
        {
            memory += decimal.Parse(TxtBox.Text);
            TxtBox.Text = memory.ToString();
        }

        private void MMinusBtn_Click(object sender, EventArgs e)
        {
            memory -= decimal.Parse(TxtBox.Text);
            TxtBox.Text = memory.ToString();
        }

        private void ThemeBtn_Click(object sender, EventArgs e)
        {
            if (isLight)
            {
                ChangeTheme(Dark[ThemeColor.Primary], Dark[ThemeColor.Text]);
                ThemeBtn.Image = Properties.Resources.icons8_sun_24_1_;
                isLight = false;
            }
            else
            {
                ChangeTheme(Light[ThemeColor.Primary], Light[ThemeColor.Text]);
                ThemeBtn.Image = Properties.Resources.icons8_sun_24;
                isLight = true;
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            valueFirst = 0.0m;
            valueSecond = 0.0m;
            TxtBox.Text = "0";
        }

        private void TxtBox_TextChanged(object sender, EventArgs e)
        {
            if (TxtBox.Text.Length > 26)
            {
                TxtBox.Text = "0";
                MessageBox.Show("Слишком много символов!");
            }
        }
    }
}
