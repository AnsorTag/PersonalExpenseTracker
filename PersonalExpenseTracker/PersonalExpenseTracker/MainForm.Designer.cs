namespace PersonalExpenseTracker
{
    partial class MainForm
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
            this.btnAdd = new Button();
            this.btnUpdate = new Button();
            this.btnDelete = new Button();
            this.btnSearch = new Button();
            this.btnSummary = new Button();
            this.dgvExpenses = new DataGridView();
            this.lblTitle = new Label();
            this.panelControls = new Panel();

            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTitle.Location = new Point(25, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(300, 35);
            this.lblTitle.Text = "Personal Expense Tracker";

            // 
            // dgvExpenses
            // 
            this.dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Location = new Point(25, 75);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.RowHeadersWidth = 51;
            this.dgvExpenses.Size = new Size(900, 400);
            this.dgvExpenses.TabIndex = 0;

            // 
            // panelControls
            // 
            this.panelControls.Location = new Point(950, 75);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new Size(200, 400);
            this.panelControls.BorderStyle = BorderStyle.FixedSingle;

            // 
            // btnAdd
            // 
            this.btnAdd.Location = new Point(10, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new Size(180, 40);
            this.btnAdd.Text = "Add Expense";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);

            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new Point(10, 80);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new Size(180, 40);
            this.btnUpdate.Text = "Update Expense";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new EventHandler(this.btnUpdate_Click);

            // 
            // btnDelete
            // 
            this.btnDelete.Location = new Point(10, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new Size(180, 40);
            this.btnDelete.Text = "Delete Expense";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);

            // 
            // btnSearch
            // 
            this.btnSearch.Location = new Point(10, 200);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new Size(180, 40);
            this.btnSearch.Text = "Search Expense";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new EventHandler(this.btnSearch_Click);

            // 
            // btnSummary
            // 
            this.btnSummary.Location = new Point(10, 260);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new Size(180, 40);
            this.btnSummary.Text = "View Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new EventHandler(this.btnSummary_Click);

            // Add buttons to the panel
            this.panelControls.Controls.Add(this.btnAdd);
            this.panelControls.Controls.Add(this.btnUpdate);
            this.panelControls.Controls.Add(this.btnDelete);
            this.panelControls.Controls.Add(this.btnSearch);
            this.panelControls.Controls.Add(this.btnSummary);

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1200, 550);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.dgvExpenses);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainForm";
            this.Text = "Expense Tracker";

            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnSummary;
        private DataGridView dgvExpenses;
        private Label lblTitle;
        private Panel panelControls;
    }
}
