using System;
using System.Windows.Forms;

namespace RailwayReservationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int ticketCount = (int)numTickets.Value;
            int farePerTicket = 0;

            // Set fare based on selected train
            if (cmbTrain.SelectedItem != null)
            {
                switch (cmbTrain.SelectedItem.ToString())
                {
                    case "Express Train": farePerTicket = 500; break;
                    case "Superfast Train": farePerTicket = 800; break;
                    case "Local Train": farePerTicket = 200; break;
                    default: farePerTicket = 0; break;
                }
            }

            // Apply class charges
            if (rdoAC.Checked) farePerTicket += 200; // AC Extra Charge

            int totalFare = farePerTicket * ticketCount;
            txtTotalFare.Text = totalFare.ToString();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassengerName.Text) || cmbSource.SelectedItem == null || cmbDestination.SelectedItem == null || cmbTrain.SelectedItem == null)
            {
                MessageBox.Show("Please fill all details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Booking Summary
            //string bookingDetails = $"Passenger: {txtPassengerName.Text}, " +
            //    $"From: {cmbSource.SelectedItem}, " + $"To: {cmbDestination.SelectedItem}, " +
            //    $"Train: {cmbTrain.SelectedItem}, " +
            //    $"Date: {dtpJourneyDate.Value.ToShortDateString()}, " +
            //    $"Tickets: {numTickets.Value}, Fare: Rs. {txtTotalFare.Text}";
            //lstSummary.Items.Add(bookingDetails);

            string bookingDetails = $"Passenger: {txtPassengerName.Text}" + Environment.NewLine +
                       $"From: {cmbSource.SelectedItem}" + Environment.NewLine +
                       $"To: {cmbDestination.SelectedItem}" + Environment.NewLine +
                       $"Train: {cmbTrain.SelectedItem}" + Environment.NewLine +
                       $"Date: {dtpJourneyDate.Value.ToShortDateString()}" + Environment.NewLine +
                       $"Tickets: {numTickets.Value}" + Environment.NewLine +
                       $"Fare: Rs. {txtTotalFare.Text}";

            // Display in Label or TextBox
            lstSummary.Items.Add(bookingDetails);


            MessageBox.Show("Ticket Booked Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPassengerName.Clear();
            cmbSource.SelectedIndex = -1;
            cmbDestination.SelectedIndex = -1;
            cmbTrain.SelectedIndex = -1;
            rdoAC.Checked = false;
            rdoNonAC.Checked = false;
            numTickets.Value = 1;
            txtTotalFare.Clear();
            lstSummary.Items.Clear();
        }

        private void cmbDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbSource_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lstSummary_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTicketDetails_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
