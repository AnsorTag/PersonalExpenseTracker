using System;
using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    public partial class AddUpdateForm : Form
    {
        private bool isUpdateMode = false;
        private int expenseId = 0;

        public AddUpdateForm()
        {
            InitializeComponent();
            txtAmount.KeyPress += txtAmount_KeyPress;
            PopulateCategories(); // Populate the ComboBox when the form loads
        }

        // Constructor for update mode
        public AddUpdateForm(int expenseId)
        {
            InitializeComponent();
            txtAmount.KeyPress += txtAmount_KeyPress;
            this.expenseId = expenseId;
            this.isUpdateMode = true;
            PopulateCategories(); // Populate the ComboBox when the form loads
            LoadExpenseData();
        }

        // Populate the ComboBox with categories
        private void PopulateCategories()
        {
            cmbCategory.Items.AddRange(Categories.GetCategories()); // Use the shared list of categories
            cmbCategory.SelectedIndex = 0; // Set the first item as the default selected item
        }

        // Load existing expense data for update mode
        private void LoadExpenseData()
        {
            try
            {
                var expense = DatabaseHelper.GetExpenseById(expenseId);
                if (expense != null)
                {
                    txtDescription.Text = expense.Description;
                    cmbCategory.SelectedItem = expense.Category;
                    txtAmount.Text = expense.Amount.ToString();
                    dtpDate.Value = expense.Date;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading expense data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            // Allow only one decimal point
            if (e.KeyChar == '.' && txtAmount.Text.Contains('.'))
            {
                e.Handled = true;
            }
            // Allow only one negative sign and only at the beginning
            if (e.KeyChar == '-' && (txtAmount.Text.Contains('-') || txtAmount.SelectionStart != 0))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrEmpty(txtDescription.Text) || string.IsNullOrEmpty(cmbCategory.Text) || !decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Please fill all fields correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string description = txtDescription.Text;
            string category = cmbCategory.Text; // Use Text instead of SelectedItem
            DateTime date = dtpDate.Value;

            try
            {
                if (isUpdateMode)
                {
                    DatabaseHelper.UpdateExpense(expenseId, description, category, amount, date);
                }
                else
                {
                    DatabaseHelper.AddExpense(description, category, amount, date);
                }
                this.Close(); // Close the form after saving
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Error in your method");
                MessageBox.Show("An error occurred. Check the log file for details.");
            }
        }
    }
}