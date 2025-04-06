using System;
using System.Windows.Forms;

namespace TShirtOrderingApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            cmbSize.Items.Add("Small");
            cmbSize.Items.Add("Medium");
            cmbSize.Items.Add("Large");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid number of T-shirts.", "Input Error");
                return;
            }

            // Get T-Shirt Price Based on Size
            int pricePerShirt = 0;
            switch (cmbSize.SelectedItem.ToString())
            {
                case "Small": pricePerShirt = 125; break;
                case "Medium": pricePerShirt = 175; break;
                case "Large": pricePerShirt = 250; break;
                default: MessageBox.Show("Please select a valid T-Shirt size."); return;
            }

            // Calculate Base Price
            double totalPrice = quantity * pricePerShirt;

            // Apply Discount if Promo Code is "TRUEBLUE"
            if (txtPromo.Text.Trim().ToUpper() == "TRUEBLUE")
            {
                totalPrice *= 0.90; // 10% Discount
            }

            // Apply 9% GST
            totalPrice *= 1.09;

            // Display Final Price
            lblTotal.Text = $"Total Price: Rs. {totalPrice:F2}";
        }

        //private void btnReset_Click(object sender, EventArgs e)
        //{
        //    txtQuantity.Clear();
        //    cmbSize.SelectedIndex = 0;
        //    txtPromo.Clear();
        //    lblTotal.Text = "Total Price: Rs. 0.00";
        //}

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtQuantity.Clear();  
            cmbSize.SelectedIndex = -1;  
            txtPromo.Clear();  
            lblTotal.Text = "Total Price: Rs. 0.00";  
        }

    }
}
