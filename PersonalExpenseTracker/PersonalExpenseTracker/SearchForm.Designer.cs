namespace PersonalExpenseTracker
{
    partial class SearchForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblSearchDescription = new Label();
            this.txtSearchDescription = new TextBox();
            this.lblSearchCategory = new Label();
            this.cmbSearchCategory = new ComboBox();
            this.lblStartDate = new Label();
            this.dtpStartDate = new DateTimePicker();
            this.lblEndDate = new Label();
            this.dtpEndDate = new DateTimePicker();
            this.btnSearch = new Button();
            this.dgvSearchResults = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTitle.Location = new Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(161, 32);
            this.lblTitle.Text = "Search Expense";

            // 
            // lblSearchDescription
            // 
            this.lblSearchDescription.AutoSize = true;
            this.lblSearchDescription.Location = new Point(12, 60);
            this.lblSearchDescription.Name = "lblSearchDescription";
            this.lblSearchDescription.Size = new Size(85, 20);
            this.lblSearchDescription.Text = "Description:";

            // 
            // txtSearchDescription
            // 
            this.txtSearchDescription.Location = new Point(120, 57);
            this.txtSearchDescription.Name = "txtSearchDescription";
            this.txtSearchDescription.Size = new Size(250, 27);
            this.txtSearchDescription.TabIndex = 1;

            // 
            // lblSearchCategory
            // 
            this.lblSearchCategory.AutoSize = true;
            this.lblSearchCategory.Location = new Point(12, 100);
            this.lblSearchCategory.Name = "lblSearchCategory";
            this.lblSearchCategory.Size = new Size(72, 20);
            this.lblSearchCategory.Text = "Category:";

            // 
            // cmbSearchCategory
            // 
            this.cmbSearchCategory.FormattingEnabled = true;
            this.cmbSearchCategory.Location = new Point(120, 97);
            this.cmbSearchCategory.Name = "cmbSearchCategory";
            this.cmbSearchCategory.Size = new Size(250, 28);
            this.cmbSearchCategory.TabIndex = 2;

            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new Point(12, 140);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new Size(76, 20);
            this.lblStartDate.Text = "Start Date:";

            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new Point(120, 137);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new Size(250, 27);
            this.dtpStartDate.TabIndex = 3;

            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new Point(12, 180);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new Size(69, 20);
            this.lblEndDate.Text = "End Date:";

            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new Point(120, 177);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new Size(250, 27);
            this.dtpEndDate.TabIndex = 4;

            // 
            // btnSearch
            // 
            this.btnSearch.Location = new Point(120, 220);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new Size(100, 35);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new EventHandler(this.btnSearch_Click);

            // 
            // dgvSearchResults
            // 
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.Location = new Point(12, 270);
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.RowHeadersWidth = 51;
            this.dgvSearchResults.Size = new Size(760, 250);
            this.dgvSearchResults.TabIndex = 6;

            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 550);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSearchDescription);
            this.Controls.Add(this.txtSearchDescription);
            this.Controls.Add(this.lblSearchCategory);
            this.Controls.Add(this.cmbSearchCategory);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvSearchResults);
            this.Name = "SearchForm";
            this.Text = "Search Expense";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSearchDescription;
        private TextBox txtSearchDescription;
        private Label lblSearchCategory;
        private ComboBox cmbSearchCategory;
        private Label lblStartDate;
        private DateTimePicker dtpStartDate;
        private Label lblEndDate;
        private DateTimePicker dtpEndDate;
        private Button btnSearch;
        private DataGridView dgvSearchResults;
    }
}
