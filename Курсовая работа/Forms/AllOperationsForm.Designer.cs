namespace CoursePaper.Forms
{
    partial class AllOperationsForm
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
            Expenses = new TabPage();
            pbEditExpense = new PictureBox();
            pbDeleteExpense = new PictureBox();
            lstExpenses = new ListBox();
            Incomes = new TabPage();
            pbEditIncome = new PictureBox();
            pbDeleteIncome = new PictureBox();
            lstIncomes = new ListBox();
            tabAllCategories.SuspendLayout();
            Expenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEditExpense).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteExpense).BeginInit();
            Incomes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEditIncome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteIncome).BeginInit();
            SuspendLayout();
            // 
            // tabAllCategories
            // 
            tabAllCategories.Controls.Add(Expenses);
            tabAllCategories.Controls.Add(Incomes);
            tabAllCategories.Location = new Point(41, 64);
            tabAllCategories.Name = "tabAllCategories";
            tabAllCategories.SelectedIndex = 0;
            tabAllCategories.Size = new Size(246, 262);
            tabAllCategories.TabIndex = 1;
            // 
            // Expenses
            // 
            Expenses.Controls.Add(pbEditExpense);
            Expenses.Controls.Add(pbDeleteExpense);
            Expenses.Controls.Add(lstExpenses);
            Expenses.Location = new Point(4, 24);
            Expenses.Name = "Expenses";
            Expenses.Padding = new Padding(3);
            Expenses.Size = new Size(238, 234);
            Expenses.TabIndex = 0;
            Expenses.Text = "Расходы";
            Expenses.UseVisualStyleBackColor = true;
            // 
            // pbEditExpense
            // 
            pbEditExpense.Image = Properties.Resources.Edit;
            pbEditExpense.Location = new Point(6, 196);
            pbEditExpense.Name = "pbEditExpense";
            pbEditExpense.Size = new Size(31, 31);
            pbEditExpense.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEditExpense.TabIndex = 16;
            pbEditExpense.TabStop = false;
            pbEditExpense.Click += pbEditExpense_Click;
            // 
            // pbDeleteExpense
            // 
            pbDeleteExpense.Image = Properties.Resources.Trash;
            pbDeleteExpense.Location = new Point(201, 196);
            pbDeleteExpense.Name = "pbDeleteExpense";
            pbDeleteExpense.Size = new Size(31, 31);
            pbDeleteExpense.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDeleteExpense.TabIndex = 14;
            pbDeleteExpense.TabStop = false;
            pbDeleteExpense.Click += pbDeleteExpense_Click;
            // 
            // lstExpenses
            // 
            lstExpenses.FormattingEnabled = true;
            lstExpenses.ItemHeight = 15;
            lstExpenses.Location = new Point(6, 6);
            lstExpenses.Name = "lstExpenses";
            lstExpenses.Size = new Size(226, 184);
            lstExpenses.TabIndex = 13;
            // 
            // Incomes
            // 
            Incomes.Controls.Add(pbEditIncome);
            Incomes.Controls.Add(pbDeleteIncome);
            Incomes.Controls.Add(lstIncomes);
            Incomes.Location = new Point(4, 24);
            Incomes.Name = "Incomes";
            Incomes.Padding = new Padding(3);
            Incomes.Size = new Size(238, 234);
            Incomes.TabIndex = 1;
            Incomes.Text = "Доходы";
            Incomes.UseVisualStyleBackColor = true;
            // 
            // pbEditIncome
            // 
            pbEditIncome.Image = Properties.Resources.Edit;
            pbEditIncome.Location = new Point(6, 196);
            pbEditIncome.Name = "pbEditIncome";
            pbEditIncome.Size = new Size(31, 31);
            pbEditIncome.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEditIncome.TabIndex = 18;
            pbEditIncome.TabStop = false;
            pbEditIncome.Click += pbEditIncome_Click;
            // 
            // pbDeleteIncome
            // 
            pbDeleteIncome.Image = Properties.Resources.Trash;
            pbDeleteIncome.Location = new Point(201, 196);
            pbDeleteIncome.Name = "pbDeleteIncome";
            pbDeleteIncome.Size = new Size(31, 31);
            pbDeleteIncome.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDeleteIncome.TabIndex = 16;
            pbDeleteIncome.TabStop = false;
            pbDeleteIncome.Click += pbDeleteIncome_Click;
            // 
            // lstIncomes
            // 
            lstIncomes.FormattingEnabled = true;
            lstIncomes.ItemHeight = 15;
            lstIncomes.Location = new Point(6, 6);
            lstIncomes.Name = "lstIncomes";
            lstIncomes.Size = new Size(226, 184);
            lstIncomes.TabIndex = 13;
            // 
            // AllOperationsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(330, 401);
            Controls.Add(tabAllCategories);
            Name = "AllOperationsForm";
            Text = "Все операции";
            tabAllCategories.ResumeLayout(false);
            Expenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbEditExpense).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteExpense).EndInit();
            Incomes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbEditIncome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteIncome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabAllCategories;
        private TabPage Expenses;
        private PictureBox pbEditExpense;
        private PictureBox pbDeleteExpense;
        private ListBox lstExpenses;
        private TabPage Incomes;
        private PictureBox pbEditIncome;
        private PictureBox pbDeleteIncome;
        private ListBox lstIncomes;
    }
}