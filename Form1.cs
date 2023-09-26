namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkFirst()
        {
            if(screenLabel.Text == "0")
            {
                screenLabel.Text = "";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            checkFirst();
            screenLabel.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            checkFirst();
            screenLabel.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            checkFirst();
            screenLabel.Text += "3";
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            screenLabel.Text += " + ";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            checkFirst();
            screenLabel.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            checkFirst();
            screenLabel.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            checkFirst();
            screenLabel.Text += "6";
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            screenLabel.Text += " - ";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            checkFirst();
            screenLabel.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            checkFirst();
            screenLabel.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            checkFirst();
            screenLabel.Text += "9";
        }

        private void timesBtn_Click(object sender, EventArgs e)
        {
            screenLabel.Text += " * ";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            checkFirst();
            screenLabel.Text += "0";
        }

        private void pointBtn_Click(object sender, EventArgs e)
        {
            screenLabel.Text += ".";
        }

        private void divisionBtn_Click(object sender, EventArgs e)
        {
            screenLabel.Text += " / ";
        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            string line = screenLabel.Text + " ";
            bool readOp = true;
            string number = "";
            bool first = true;
            double acc = 0;
            char op = '+';
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ' ')
                {
                    double tmp = 0;
                    try
                    {
                        tmp = Double.Parse(number);
                    }
                    catch
                    {
                        screenLabel.Text = "Syntax Error";
                    }
                    readOp = true;
                    if (i + 1 < line.Length)
                    {
                        op = line[i + 1];
                    }
                    i += 2;
                    if (acc == 0 && first)
                    {
                        acc = tmp;
                        first = false;
                    }
                    else
                    {
                        acc = calculate(op, tmp, acc);
                    }
                    number = "";
                    continue;
                }
                else
                {
                    number += line[i];
                }
            }
            screenLabel.Text = "" + acc;
        }

        private double calculate(char operation, double value, double acc)
        {
            switch (operation)
            {
                case '+':
                    return acc + value;
                    break;

                case '-':
                    return acc - value;
                    break;
                case '*':
                    return acc * value;
                    break;
                case '/':
                    if (value == 0)
                    {
                        throw new Exception("Syntax Error.");
                    }
                    else
                    {
                        return acc / value;
                    }
                    break;
                default:
                    throw new Exception("Syntax Error.");
                    break;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            screenLabel.Text = 0 + "";
        }
    }
}
