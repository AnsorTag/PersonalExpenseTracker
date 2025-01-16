namespace PersonalExpenseTracker
{
    partial class AddUpdateForm
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
            this.lblDescription = new Label();
            this.txtDescription = new TextBox();
            this.lblCategory = new Label();
            this.cmbCategory = new ComboBox();
            this.lblAmount = new Label();
            this.txtAmount = new TextBox();
            this.lblDate = new Label();
            this.dtpDate = new DateTimePicker();
            this.btnSave = new Button();

            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTitle.Location = new Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(238, 32);
            this.lblTitle.Text = "Add / Update Expense";

            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new Point(12, 60);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new Size(85, 20);
            this.lblDescription.Text = "Description:";

            // 
            // txtDescription
            // 
            this.txtDescription.Location = new Point(120, 57);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new Size(250, 27);
            this.txtDescription.TabIndex = 1;

            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new Point(12, 100);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new Size(72, 20);
            this.lblCategory.Text = "Category:";

            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new Point(120, 97);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new Size(250, 28);
            this.cmbCategory.TabIndex = 2;

            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new Point(12, 140);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new Size(65, 20);
            this.lblAmount.Text = "Amount:";

            // 
            // txtAmount
            // 
            this.txtAmount.Location = new Point(120, 137);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new Size(250, 27);
            this.txtAmount.TabIndex = 3;

            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new Point(12, 180);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new Size(43, 20);
            this.lblDate.Text = "Date:";

            // 
            // dtpDate
            // 
            this.dtpDate.Location = new Point(120, 177);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new Size(250, 27);
            this.dtpDate.TabIndex = 4;

            // 
            // btnSave
            // 
            this.btnSave.Location = new Point(120, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new Size(100, 35);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new EventHandler(this.btnSave_Click);

            // 
            // AddUpdateForm
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(400, 300);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnSave);
            this.Name = "AddUpdateForm";
            this.Text = "Add / Update Expense";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblAmount;
        private TextBox txtAmount;
        private Label lblDate;
        private DateTimePicker dtpDate;
        private Button btnSave;
    }
}
