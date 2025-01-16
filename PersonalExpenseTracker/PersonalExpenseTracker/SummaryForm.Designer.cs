namespace PersonalExpenseTracker
{
    partial class SummaryForm
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
            lblTitle = new Label();
            dgvSummary = new DataGridView();
            lblTotalExpenses = new Label();
            txtTotalExpenses = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSummary).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(262, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Expense Summary";
            // 
            // dgvSummary
            // 
            dgvSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSummary.Location = new Point(12, 60);
            dgvSummary.Name = "dgvSummary";
            dgvSummary.RowHeadersWidth = 51;
            dgvSummary.Size = new Size(760, 300);
            dgvSummary.TabIndex = 0;
            // 
            // lblTotalExpenses
            // 
            lblTotalExpenses.AutoSize = true;
            lblTotalExpenses.Location = new Point(12, 380);
            lblTotalExpenses.Name = "lblTotalExpenses";
            lblTotalExpenses.Size = new Size(109, 20);
            lblTotalExpenses.TabIndex = 1;
            lblTotalExpenses.Text = "Total Expenses:";
            // 
            // txtTotalExpenses
            // 
            txtTotalExpenses.Location = new Point(130, 377);
            txtTotalExpenses.Name = "txtTotalExpenses";
            txtTotalExpenses.ReadOnly = true;
            txtTotalExpenses.Size = new Size(200, 27);
            txtTotalExpenses.TabIndex = 1;
            txtTotalExpenses.Padding = new Padding(-20); 
            // 
            // SummaryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(dgvSummary);
            Controls.Add(lblTotalExpenses);
            Controls.Add(txtTotalExpenses);
            Name = "SummaryForm";
            Text = "Expense Summary";
            ((System.ComponentModel.ISupportInitialize)dgvSummary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvSummary;
        private Label lblTotalExpenses;
        private TextBox txtTotalExpenses;
    }
}
