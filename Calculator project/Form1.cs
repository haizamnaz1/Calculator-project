namespace Calculator_project
{
    public partial class Form1 : Form
    {
        double firstNumber;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TextBoxDisplay.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            TextBoxDisplay.Text += "4";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            TextBoxDisplay.Text += "7";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TextBoxDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TextBoxDisplay.Text += "2";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TextBoxDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TextBoxDisplay.Text += "6";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TextBoxDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            TextBoxDisplay.Text += "9";
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            TextBoxDisplay.Text += "0";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(TextBoxDisplay.Text);
            operation = "+";
            TextBoxDisplay.Clear();
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(TextBoxDisplay.Text);
            operation = "-";
            TextBoxDisplay.Clear();
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(TextBoxDisplay.Text);
            operation = "*";
            TextBoxDisplay.Clear();
        }

        private void btndevision_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(TextBoxDisplay.Text);
            operation = "/";
            TextBoxDisplay.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double secondNumber = double.Parse(TextBoxDisplay.Text);
            double result = 0;

            if (operation == "+")
            {
                result = firstNumber + secondNumber;
            }

            if (operation == "-")
            {
                result = firstNumber - secondNumber;
            }

            if (operation == "*")
            {
                result = firstNumber * secondNumber;
            }

            if (operation == "/")
            {
                result = firstNumber / secondNumber;
            }
            TextBoxDisplay.Text = firstNumber + " " + operation + " " + secondNumber + " " + result.ToString();
        }
    }
}
