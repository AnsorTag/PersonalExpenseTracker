using System;
using System.Data;
using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
            this.Load += SummaryForm_Load;  // Add Load event handler
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Fetch the summary data (grouped by category)
                DataTable summaryData = DatabaseHelper.GetExpenseSummary();

                // Bind the fetched data to the DataGridView
                dgvSummary.DataSource = summaryData;

                // Calculate and display total expenses
                decimal totalExpenses = summaryData.AsEnumerable()
                                                   .Sum(row => row.Field<decimal>("TotalAmount"));

                // Display total expenses
                lblTotalExpenses.Text = $"Total Expenses: {totalExpenses:C}"; // Display as currency
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Error in your method");
                MessageBox.Show("An error occurred. Check the log file for details.");
            }
        }
    }
}