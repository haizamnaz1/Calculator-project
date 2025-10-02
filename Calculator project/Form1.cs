namespace Calculator_project
{
    public partial class Form1 : Form
    {
        double firstNumber;
        string operation;
        double result = 0;
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateDisplaylebel();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateDisplaylebel()
        {
            lblDisplay.Text = firstNumber + " " + operation + " " + TextBoxDisplay.Text;
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                TextBoxDisplay.Clear();
                isOperationPerformed = false;
            }
            TextBoxDisplay.Text += "3";
            UpdateDisplaylebel();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                TextBoxDisplay.Clear();
                isOperationPerformed = false;
            }
            TextBoxDisplay.Text += "4";
            UpdateDisplaylebel();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                TextBoxDisplay.Clear();
                isOperationPerformed = false;
            }
            TextBoxDisplay.Text += "7";
            UpdateDisplaylebel();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                TextBoxDisplay.Clear();
                isOperationPerformed = false;
            }
            TextBoxDisplay.Text += "1";
            UpdateDisplaylebel();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                TextBoxDisplay.Clear();
                isOperationPerformed = false;
            }
            TextBoxDisplay.Text += "2";
            UpdateDisplaylebel();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                TextBoxDisplay.Clear();
                isOperationPerformed = false;
            }
            TextBoxDisplay.Text += "5";
            UpdateDisplaylebel();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                TextBoxDisplay.Clear();
                isOperationPerformed = false;
            }
            TextBoxDisplay.Text += "6";
            UpdateDisplaylebel();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                TextBoxDisplay.Clear();
                isOperationPerformed = false;
            }
            TextBoxDisplay.Text += "8";
            UpdateDisplaylebel();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                TextBoxDisplay.Clear();
                isOperationPerformed = false;
            }
            TextBoxDisplay.Text += "9";
            UpdateDisplaylebel();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (isOperationPerformed)
            {
                TextBoxDisplay.Clear();
                isOperationPerformed = false;
            }
            TextBoxDisplay.Text += "0";
            UpdateDisplaylebel();
        }

        private void PerformCalculation(double secondNumber)
        {
            switch (operation)
            {
                case "+":
                    firstNumber += secondNumber;
                    break;
                case "-":
                    firstNumber -= secondNumber;
                    break;
                case "*":
                    firstNumber *= secondNumber;
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        TextBoxDisplay.Text = "dummy you made a mistake";
                        firstNumber = 0;
                        operation = "";
                        isOperationPerformed = true;
                        return;
                    }
                    firstNumber /= secondNumber;
                    break;
            }
        }

        private void HandleOperation(string newOperation)
        {
            if (TextBoxDisplay.Text == "") return;

            if (operation != "" && !isOperationPerformed)
            { 
                double secondNumber = double.Parse(TextBoxDisplay.Text);
                PerformCalculation(secondNumber);
                TextBoxDisplay.Text = firstNumber.ToString();
            }
            else
            {
                firstNumber = double.Parse(TextBoxDisplay.Text);
            }
            operation = newOperation;
            isOperationPerformed = true;
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            HandleOperation("+");
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            HandleOperation("-");
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            HandleOperation("*");
        }

        private void btndevision_Click(object sender, EventArgs e)
        {
            HandleOperation("/");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (operation == "" || TextBoxDisplay.Text == "") return;
            double secondNumber = double.Parse(TextBoxDisplay.Text);
            PerformCalculation(secondNumber);

            TextBoxDisplay.Text = firstNumber.ToString();
            operation = "";
            isOperationPerformed = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TextBoxDisplay.Clear();
            firstNumber = 0;
            operation = "";
            isOperationPerformed = true;
        }
    }
}
