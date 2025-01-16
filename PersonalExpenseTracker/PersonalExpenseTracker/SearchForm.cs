using System;
using System.Data;
using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            PopulateCategories(); // Populate the ComboBox when the form loads
        }

        // Populate the ComboBox with categories
        private void PopulateCategories()
        {
            cmbSearchCategory.Items.AddRange(Categories.GetCategories()); // Use the shared list of categories
            cmbSearchCategory.SelectedIndex = 0; // Set the first item as the default selected item
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string description = txtSearchDescription.Text;
            string category = cmbSearchCategory.Text; // Use Text instead of SelectedItem
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            try
            {
                DataTable searchResults = DatabaseHelper.SearchExpenses(description, category, startDate, endDate);
                dgvSearchResults.DataSource = searchResults;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Error in your method");
                MessageBox.Show("An error occurred. Check the log file for details.");
            }
        }
    }
}