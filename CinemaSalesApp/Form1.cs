using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSalesApp
{
    public partial class cinemaSalesForm : Form
    {
        const double ADULT_TICKET_PRICE = 7.99;
        const double STUDENT_TICKET_PRICE = 4.99;
        const double CHILD_TICKET_PRICE = 2.99;

        private int ticketsSold = 0;
        private double totalReceipts = 0.0;
        private double avgTransationsValue = 0.0;
        private int totalCashiers = 0;

        public cinemaSalesForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            this.Text = "Purchase Tickets";
            megaCinemaPictureBox.Location = new Point(27, 470);
            enterButton.Visible = false;
            this.showCashierDetails();
            this.showTicketsButtonsSection();
            this.enableCashierDetails();
            this.enableTicketsSection();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.Text = "Welcome to Mega Cinema";
            megaCinemaPictureBox.Location = new Point(27, 33);
            enterButton.Visible = true;

            //Clearing the TextBox values
            cashierNameTextBox.Text = "";
            adultCountTextBox.Text = "";
            studentCountTextBox.Text = "";
            childCountTextBox.Text = "";

            //Hiding the Cashier Details, Tickets, Buttons and Cashier Summary Section
            this.hideTicketsButtonsSection();
            this.hideCashierDetails();
            this.hideCashierSummaryData();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            this.Text = "Transaction Summary";
            cashierSummaryGroupBox.Text = "Cashier Summary Data";

            cashierNameSummaryValue.Text = cashierNameTextBox.Text;

            try {
                ticketsSold += int.Parse(adultCountTextBox.Text) +
                          int.Parse(studentCountTextBox.Text) +
                          int.Parse(childCountTextBox.Text);
                totalTicketsSoldSummaryCount.Text = ticketsSold.ToString();
            }
            catch {
                string caption = "Data Entry Error";
                string message = "Please enter numerical data for number of adult tickets";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            totalReceipts += int.Parse(adultCountTextBox.Text) * ADULT_TICKET_PRICE +
                          int.Parse(studentCountTextBox.Text) * STUDENT_TICKET_PRICE +
                          int.Parse(childCountTextBox.Text) * CHILD_TICKET_PRICE;
            totalReceiptsSummaryAmount.Text = totalReceipts.ToString("c");

            this.showCashierSummaryData();
            this.disableTicketsSection();
            this.disableCashierDetails();

        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            this.Text = "All Transactions Summary";
            cashierSummaryGroupBox.Text = "Company Summary Data";

            cashierNameSummaryLabel.Visible = false;
            cashierNameSummaryValue.Visible = false;

            //Cashier's count
            totalCashiers = 1;
            totalCashiersCount.Text = totalCashiers.ToString("n");

            avgTransationsValue = totalReceipts / ticketsSold;
            avgTransationsSummaryAmount.Text = avgTransationsValue.ToString("c");


            this.showCompanySummaryData();

        }

        //Show/Hide Cashier Details
        private void showCashierDetails() {
            cashierNameLabel.Visible = true;
            cashierNameTextBox.Visible = true;
        }

        private void hideCashierDetails()
        {
            cashierNameLabel.Visible = false;
            cashierNameTextBox.Visible = false;
        }

        //Enable/Disable Cashier Details
        private void enableCashierDetails()
        {
            cashierNameLabel.Enabled = true;
            cashierNameTextBox.Enabled = true;
        }

        private void disableCashierDetails()
        {
            cashierNameLabel.Enabled = false;
            cashierNameTextBox.Enabled = false;
        }

        //Show/Hide Tickets and Buttons Section 
        private void showTicketsButtonsSection()
        {
            ticketCountGroupBox.Visible = true;

            adultLabel.Visible = true;
            adultCountTextBox.Visible = true;
            studentLabel.Visible = true;
            studentCountTextBox.Visible = true;
            childLabel.Visible = true;
            childCountTextBox.Visible = true;

            buttonsControlPanel.Visible = true;
            calculateButton.Visible = true;
            clearButton.Visible = true;
            summaryButton.Visible = true;
            exitButton.Visible = true;
        }

        private void hideTicketsButtonsSection()
        {
            ticketCountGroupBox.Visible = false;

            adultLabel.Visible = false;
            adultCountTextBox.Visible = false;
            studentLabel.Visible = false;
            studentCountTextBox.Visible = false;
            childLabel.Visible = false;
            childCountTextBox.Visible = false;

            buttonsControlPanel.Visible = false;
            calculateButton.Visible = false;
            clearButton.Visible = false;
            summaryButton.Visible = false;
            exitButton.Visible = false;
        }

        //Enable/Disable Tickets Section 
        private void enableTicketsSection()
        {
            ticketCountGroupBox.Enabled = true;

            adultCountTextBox.Enabled = true;
            studentCountTextBox.Enabled = true;
            childCountTextBox.Enabled = true;

            adultLabel.Enabled = true;
            studentLabel.Enabled = true;
            childLabel.Enabled = true;
        }

        private void disableTicketsSection()
        {
            ticketCountGroupBox.Enabled = false;

            adultCountTextBox.Enabled = false;
            studentCountTextBox.Enabled = false;
            childCountTextBox.Enabled = false;

            adultLabel.Enabled = false;
            studentLabel.Enabled = false;
            childLabel.Enabled = false;
        }

        //Show/Hide Cashier Summary Data Section 
        private void showCashierSummaryData()
        {
            cashierSummaryGroupBox.Visible = true;

            cashierNameSummaryLabel.Visible = true;
            cashierNameSummaryValue.Visible = true;

            totalTicketsSoldSummaryLabel.Visible = true;
            totalTicketsSoldSummaryCount.Visible = true;

            totalReceiptsSummaryLabel.Visible = true;
            totalReceiptsSummaryAmount.Visible = true;
        }

        private void hideCashierSummaryData()
        {
            cashierSummaryGroupBox.Visible = false;

            cashierNameSummaryLabel.Visible = false;
            cashierNameSummaryValue.Visible = false;

            totalTicketsSoldSummaryLabel.Visible = false;
            totalTicketsSoldSummaryCount.Visible = false;

            totalReceiptsSummaryLabel.Visible = false;
            totalReceiptsSummaryAmount.Visible = false;
        }

        //Show/Hide Company Summary Data Section 
        private void showCompanySummaryData()
        {
            avgTransationsSummaryAmount.Visible = true;
            avgTransationsValueLabel.Visible = true;

            totalCashiersLabel.Visible = true;
            totalCashiersCount.Visible = true;
        }

        private void hideCompanySummaryData()
        {

        }
    }
}
