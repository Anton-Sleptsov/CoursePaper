namespace CoursePaper.Forms
{
    partial class AllCategoriesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabAllCategories = new TabControl();
            ExpenseCategories = new TabPage();
            txtNewTitleExpenseCategory = new TextBox();
            lblNewTitleExpenseCategory = new Label();
            pbEditExpenseCategory = new PictureBox();
            pbAddExpenseCategory = new PictureBox();
            pbDeleteExpenseCategory = new PictureBox();
            lstExpenseCategories = new ListBox();
            IncomesCategories = new TabPage();
            txtNewTitleIncomeCategory = new TextBox();
            lblNewTitleIncomeCategory = new Label();
            pbEditIncomeCategory = new PictureBox();
            pbAddIncomeCategory = new PictureBox();
            pbDeleteIncomeCategory = new PictureBox();
            lstIncomeCategories = new ListBox();
            tabAllCategories.SuspendLayout();
            ExpenseCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEditExpenseCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAddExpenseCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteExpenseCategory).BeginInit();
            IncomesCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEditIncomeCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAddIncomeCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteIncomeCategory).BeginInit();
            SuspendLayout();
            // 
            // tabAllCategories
            // 
            tabAllCategories.Controls.Add(ExpenseCategories);
            tabAllCategories.Controls.Add(IncomesCategories);
            tabAllCategories.Location = new Point(30, 34);
            tabAllCategories.Name = "tabAllCategories";
            tabAllCategories.SelectedIndex = 0;
            tabAllCategories.Size = new Size(246, 316);
            tabAllCategories.TabIndex = 0;
            // 
            // ExpenseCategories
            // 
            ExpenseCategories.Controls.Add(txtNewTitleExpenseCategory);
            ExpenseCategories.Controls.Add(lblNewTitleExpenseCategory);
            ExpenseCategories.Controls.Add(pbEditExpenseCategory);
            ExpenseCategories.Controls.Add(pbAddExpenseCategory);
            ExpenseCategories.Controls.Add(pbDeleteExpenseCategory);
            ExpenseCategories.Controls.Add(lstExpenseCategories);
            ExpenseCategories.Location = new Point(4, 24);
            ExpenseCategories.Name = "ExpenseCategories";
            ExpenseCategories.Padding = new Padding(3);
            ExpenseCategories.Size = new Size(238, 288);
            ExpenseCategories.TabIndex = 0;
            ExpenseCategories.Text = "Категории расходов";
            ExpenseCategories.UseVisualStyleBackColor = true;
            // 
            // txtNewTitleExpenseCategory
            // 
            txtNewTitleExpenseCategory.Location = new Point(6, 259);
            txtNewTitleExpenseCategory.Name = "txtNewTitleExpenseCategory";
            txtNewTitleExpenseCategory.Size = new Size(162, 23);
            txtNewTitleExpenseCategory.TabIndex = 15;
            txtNewTitleExpenseCategory.Visible = false;
            // 
            // lblNewTitleExpenseCategory
            // 
            lblNewTitleExpenseCategory.AutoSize = true;
            lblNewTitleExpenseCategory.Location = new Point(6, 243);
            lblNewTitleExpenseCategory.Name = "lblNewTitleExpenseCategory";
            lblNewTitleExpenseCategory.Size = new Size(142, 15);
            lblNewTitleExpenseCategory.TabIndex = 16;
            lblNewTitleExpenseCategory.Text = "Введите новое название:";
            lblNewTitleExpenseCategory.Visible = false;
            // 
            // pbEditExpenseCategory
            // 
            pbEditExpenseCategory.Image = Properties.Resources.Edit;
            pbEditExpenseCategory.Location = new Point(164, 196);
            pbEditExpenseCategory.Name = "pbEditExpenseCategory";
            pbEditExpenseCategory.Size = new Size(31, 31);
            pbEditExpenseCategory.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEditExpenseCategory.TabIndex = 16;
            pbEditExpenseCategory.TabStop = false;
            pbEditExpenseCategory.Click += pbEditExpenseCategory_Click;
            // 
            // pbAddExpenseCategory
            // 
            pbAddExpenseCategory.Image = Properties.Resources.Add;
            pbAddExpenseCategory.Location = new Point(6, 196);
            pbAddExpenseCategory.Name = "pbAddExpenseCategory";
            pbAddExpenseCategory.Size = new Size(31, 31);
            pbAddExpenseCategory.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAddExpenseCategory.TabIndex = 15;
            pbAddExpenseCategory.TabStop = false;
            pbAddExpenseCategory.Click += pbAddExpenseCategory_Click;
            // 
            // pbDeleteExpenseCategory
            // 
            pbDeleteExpenseCategory.Image = Properties.Resources.Trash;
            pbDeleteExpenseCategory.Location = new Point(201, 196);
            pbDeleteExpenseCategory.Name = "pbDeleteExpenseCategory";
            pbDeleteExpenseCategory.Size = new Size(31, 31);
            pbDeleteExpenseCategory.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDeleteExpenseCategory.TabIndex = 14;
            pbDeleteExpenseCategory.TabStop = false;
            pbDeleteExpenseCategory.Click += pbDeleteExpenseCategory_Click;
            // 
            // lstExpenseCategories
            // 
            lstExpenseCategories.FormattingEnabled = true;
            lstExpenseCategories.ItemHeight = 15;
            lstExpenseCategories.Location = new Point(6, 6);
            lstExpenseCategories.Name = "lstExpenseCategories";
            lstExpenseCategories.Size = new Size(226, 184);
            lstExpenseCategories.TabIndex = 13;
            lstExpenseCategories.SelectedIndexChanged += lstExpenseCategories_SelectedIndexChanged;
            // 
            // IncomesCategories
            // 
            IncomesCategories.Controls.Add(txtNewTitleIncomeCategory);
            IncomesCategories.Controls.Add(lblNewTitleIncomeCategory);
            IncomesCategories.Controls.Add(pbEditIncomeCategory);
            IncomesCategories.Controls.Add(pbAddIncomeCategory);
            IncomesCategories.Controls.Add(pbDeleteIncomeCategory);
            IncomesCategories.Controls.Add(lstIncomeCategories);
            IncomesCategories.Location = new Point(4, 24);
            IncomesCategories.Name = "IncomesCategories";
            IncomesCategories.Padding = new Padding(3);
            IncomesCategories.Size = new Size(238, 288);
            IncomesCategories.TabIndex = 1;
            IncomesCategories.Text = "Категории доходов";
            IncomesCategories.UseVisualStyleBackColor = true;
            // 
            // txtNewTitleIncomeCategory
            // 
            txtNewTitleIncomeCategory.Location = new Point(6, 259);
            txtNewTitleIncomeCategory.Name = "txtNewTitleIncomeCategory";
            txtNewTitleIncomeCategory.Size = new Size(162, 23);
            txtNewTitleIncomeCategory.TabIndex = 19;
            txtNewTitleIncomeCategory.Visible = false;
            // 
            // lblNewTitleIncomeCategory
            // 
            lblNewTitleIncomeCategory.AutoSize = true;
            lblNewTitleIncomeCategory.Location = new Point(6, 243);
            lblNewTitleIncomeCategory.Name = "lblNewTitleIncomeCategory";
            lblNewTitleIncomeCategory.Size = new Size(142, 15);
            lblNewTitleIncomeCategory.TabIndex = 20;
            lblNewTitleIncomeCategory.Text = "Введите новое название:";
            lblNewTitleIncomeCategory.Visible = false;
            // 
            // pbEditIncomeCategory
            // 
            pbEditIncomeCategory.Image = Properties.Resources.Edit;
            pbEditIncomeCategory.Location = new Point(164, 196);
            pbEditIncomeCategory.Name = "pbEditIncomeCategory";
            pbEditIncomeCategory.Size = new Size(31, 31);
            pbEditIncomeCategory.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEditIncomeCategory.TabIndex = 18;
            pbEditIncomeCategory.TabStop = false;
            pbEditIncomeCategory.Click += pbEditIncomeCategory_Click;
            // 
            // pbAddIncomeCategory
            // 
            pbAddIncomeCategory.Image = Properties.Resources.Add;
            pbAddIncomeCategory.Location = new Point(6, 196);
            pbAddIncomeCategory.Name = "pbAddIncomeCategory";
            pbAddIncomeCategory.Size = new Size(31, 31);
            pbAddIncomeCategory.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAddIncomeCategory.TabIndex = 17;
            pbAddIncomeCategory.TabStop = false;
            pbAddIncomeCategory.Click += pbAddIncomeCategory_Click;
            // 
            // pbDeleteIncomeCategory
            // 
            pbDeleteIncomeCategory.Image = Properties.Resources.Trash;
            pbDeleteIncomeCategory.Location = new Point(201, 196);
            pbDeleteIncomeCategory.Name = "pbDeleteIncomeCategory";
            pbDeleteIncomeCategory.Size = new Size(31, 31);
            pbDeleteIncomeCategory.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDeleteIncomeCategory.TabIndex = 16;
            pbDeleteIncomeCategory.TabStop = false;
            pbDeleteIncomeCategory.Click += pbDeleteIncomeCategory_Click;
            // 
            // lstIncomeCategories
            // 
            lstIncomeCategories.FormattingEnabled = true;
            lstIncomeCategories.ItemHeight = 15;
            lstIncomeCategories.Location = new Point(6, 6);
            lstIncomeCategories.Name = "lstIncomeCategories";
            lstIncomeCategories.Size = new Size(226, 184);
            lstIncomeCategories.TabIndex = 13;
            lstIncomeCategories.SelectedIndexChanged += lstIncomeCategories_SelectedIndexChanged;
            // 
            // AllCategoriesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(348, 388);
            Controls.Add(tabAllCategories);
            Name = "AllCategoriesForm";
            Text = "Все категории";
            tabAllCategories.ResumeLayout(false);
            ExpenseCategories.ResumeLayout(false);
            ExpenseCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbEditExpenseCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAddExpenseCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteExpenseCategory).EndInit();
            IncomesCategories.ResumeLayout(false);
            IncomesCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbEditIncomeCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAddIncomeCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteIncomeCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabAllCategories;
        private TabPage ExpenseCategories;
        private TabPage IncomesCategories;
        private ListBox lstIncomeCategories;
        private ListBox lstExpenseCategories;
        private PictureBox pbDeleteExpenseCategory;
        private PictureBox pbAddExpenseCategory;
        private PictureBox pbAddIncomeCategory;
        private PictureBox pbDeleteIncomeCategory;
        private PictureBox pbEditExpenseCategory;
        private TextBox txtNewTitleExpenseCategory;
        private Label lblNewTitleExpenseCategory;
        private PictureBox pbEditIncomeCategory;
        private TextBox txtNewTitleIncomeCategory;
        private Label lblNewTitleIncomeCategory;
    }
}