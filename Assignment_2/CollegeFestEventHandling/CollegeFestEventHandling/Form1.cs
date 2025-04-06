using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeFestEventHandling
{
    public partial class Form1 : Form
    {
        private College college;
        private Caterer caterer;
        private Decorator decorator;
        public Form1()
        {
            InitializeComponent();
            college = new College();
            caterer = new Caterer();
            decorator = new Decorator();

            // Subscribe to the event
            college.CollegeFest += caterer.OnCollegeFest;
            college.CollegeFest += decorator.OnCollegeFest;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtVisitors.Text, out int visitors) && visitors > 0)
            {
                // Trigger the event
                college.OrganizeFest(visitors);

                // Display costs in labels
                int cateringCost = caterer.GetCateringCost(visitors);
                int decorationCost = decorator.GetDecorationCost(visitors);
                int totalCost = cateringCost + decorationCost;

                lblCateringCost.Text = $"Rs. {cateringCost}";
                lblDecorationCost.Text = $"Rs. {decorationCost}";
                lblTotalCost.Text = $"Rs. {totalCost}";
            }
            else
            {
                MessageBox.Show("Please enter a valid number of visitors.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
