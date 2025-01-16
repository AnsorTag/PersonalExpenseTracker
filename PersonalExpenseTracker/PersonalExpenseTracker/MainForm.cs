using System;
using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadExpenses(); // Load data into the DataGridView when the form loads
        }

        // Load all expenses into the DataGridView
        private void LoadExpenses()
        {
            try
            {
                dgvExpenses.DataSource = DatabaseHelper.GetExpenses();
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Error in your method");
                MessageBox.Show("An error occurred. Check the log file for details."); ;
            }
        }

        // Add Expense
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUpdateForm addForm = new AddUpdateForm();
            addForm.ShowDialog(); // Open Add Form as a modal dialog
            LoadExpenses(); // Refresh the grid after adding a record
        }

        // Update Expense
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count > 0)
            {
                int expenseId = Convert.ToInt32(dgvExpenses.SelectedRows[0].Cells["ExpenseID"].Value);
                AddUpdateForm updateForm = new AddUpdateForm(expenseId); // Pass the selected expense ID
                updateForm.ShowDialog();
                LoadExpenses(); // Refresh the grid after updating a record
            }
            else
            {
                MessageBox.Show("Please select a record to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Delete Expense
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count > 0)
            {
                int expenseId = Convert.ToInt32(dgvExpenses.SelectedRows[0].Cells["ExpenseID"].Value);

                // Confirm deletion
                var result = MessageBox.Show("Are you sure you want to delete this expense?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DatabaseHelper.DeleteExpense(expenseId); // Call the database helper to delete the record
                        MessageBox.Show("Expense deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadExpenses(); // Refresh the grid after deletion
                    }
                    catch (Exception ex)
                    {
                        Logger.LogError(ex, "Error in your method");
                        MessageBox.Show("An error occurred. Check the log file for details."); ;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Search Expenses
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog(); // Open Search Form as a modal dialog
        }

        // View Summary
        private void btnSummary_Click(object sender, EventArgs e)
        {
            SummaryForm summaryForm = new SummaryForm();
            summaryForm.ShowDialog(); // Open Summary Form as a modal dialog
        }
    }
}