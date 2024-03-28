namespace Курсовая_работа.Forms
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
            pbEditExpenseCategory = new PictureBox();
            pbAddExpenseCategory = new PictureBox();
            pbDeleteExpenseCategory = new PictureBox();
            lstExpenseCategories = new ListBox();
            IncomesCategories = new TabPage();
            pbAddIncomeCategory = new PictureBox();
            pbDeleteIncomeCategory = new PictureBox();
            lstIncomeCategories = new ListBox();
            txtNewTitle = new TextBox();
            lblNewTitle = new Label();
            pbEditIncomeCategory = new PictureBox();
            tabAllCategories.SuspendLayout();
            ExpenseCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEditExpenseCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAddExpenseCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteExpenseCategory).BeginInit();
            IncomesCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAddIncomeCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteIncomeCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEditIncomeCategory).BeginInit();
            SuspendLayout();
            // 
            // tabAllCategories
            // 
            tabAllCategories.Controls.Add(ExpenseCategories);
            tabAllCategories.Controls.Add(IncomesCategories);
            tabAllCategories.Location = new Point(30, 34);
            tabAllCategories.Name = "tabAllCategories";
            tabAllCategories.SelectedIndex = 0;
            tabAllCategories.Size = new Size(246, 270);
            tabAllCategories.TabIndex = 0;
            // 
            // ExpenseCategories
            // 
            ExpenseCategories.Controls.Add(pbEditExpenseCategory);
            ExpenseCategories.Controls.Add(pbAddExpenseCategory);
            ExpenseCategories.Controls.Add(pbDeleteExpenseCategory);
            ExpenseCategories.Controls.Add(lstExpenseCategories);
            ExpenseCategories.Location = new Point(4, 24);
            ExpenseCategories.Name = "ExpenseCategories";
            ExpenseCategories.Padding = new Padding(3);
            ExpenseCategories.Size = new Size(238, 242);
            ExpenseCategories.TabIndex = 0;
            ExpenseCategories.Text = "Категории расходов";
            ExpenseCategories.UseVisualStyleBackColor = true;
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
            // 
            // IncomesCategories
            // 
            IncomesCategories.Controls.Add(pbEditIncomeCategory);
            IncomesCategories.Controls.Add(pbAddIncomeCategory);
            IncomesCategories.Controls.Add(pbDeleteIncomeCategory);
            IncomesCategories.Controls.Add(lstIncomeCategories);
            IncomesCategories.Location = new Point(4, 24);
            IncomesCategories.Name = "IncomesCategories";
            IncomesCategories.Padding = new Padding(3);
            IncomesCategories.Size = new Size(238, 242);
            IncomesCategories.TabIndex = 1;
            IncomesCategories.Text = "Категории доходов";
            IncomesCategories.UseVisualStyleBackColor = true;
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
            // 
            // txtNewTitle
            // 
            txtNewTitle.Location = new Point(30, 329);
            txtNewTitle.Name = "txtNewTitle";
            txtNewTitle.Size = new Size(162, 23);
            txtNewTitle.TabIndex = 15;
            txtNewTitle.Visible = false;
            // 
            // lblNewTitle
            // 
            lblNewTitle.AutoSize = true;
            lblNewTitle.Location = new Point(30, 311);
            lblNewTitle.Name = "lblNewTitle";
            lblNewTitle.Size = new Size(142, 15);
            lblNewTitle.TabIndex = 16;
            lblNewTitle.Text = "Введите новое название:";
            lblNewTitle.Visible = false;
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
            // AllCategoriesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(348, 388);
            Controls.Add(lblNewTitle);
            Controls.Add(txtNewTitle);
            Controls.Add(tabAllCategories);
            Name = "AllCategoriesForm";
            Text = "Все категории";
            tabAllCategories.ResumeLayout(false);
            ExpenseCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbEditExpenseCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAddExpenseCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteExpenseCategory).EndInit();
            IncomesCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAddIncomeCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteIncomeCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEditIncomeCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox txtNewTitle;
        private Label lblNewTitle;
        private PictureBox pbEditIncomeCategory;
    }
}