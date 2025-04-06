using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNum1.Text, out double num1) ||
                !double.TryParse(txtNum2.Text, out double num2))
            {
                MessageBox.Show("Please enter valid numbers.", "Input Error");
                return;
            }

            if (cmbOperation.SelectedItem == null)
            {
                MessageBox.Show("Please select an operation.", "Selection Error");
                return;
            }

            double result = 0;
            string operation = cmbOperation.SelectedItem.ToString();

            // Perform calculation based on selected operation
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.", "Math Error");
                        return;
                    }
                    result = num1 / num2;
                    break;
                default:
                    MessageBox.Show("Invalid operation selected.");
                    return;
            }

            // Display result
            lblResult.Text = $"Result: {result:F2}";
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            cmbOperation.SelectedIndex = -1;
            lblResult.Text = "Result: ";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
