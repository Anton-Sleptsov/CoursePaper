namespace Курсовая_работа
{
    partial class AddIncomeForm
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
            groupBox1 = new GroupBox();
            btnAddIncomeCategory = new Button();
            groupBox4 = new GroupBox();
            txtAmountOfIncome = new TextBox();
            groupBox3 = new GroupBox();
            dateOfIncome = new DateTimePicker();
            groupBox2 = new GroupBox();
            lstIncomeCategories = new ListBox();
            btnAddIncome = new Button();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddIncomeCategory);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btnAddIncome);
            groupBox1.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(417, 366);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавить доход";
            // 
            // btnAddIncomeCategory
            // 
            btnAddIncomeCategory.BackColor = Color.LightGoldenrodYellow;
            btnAddIncomeCategory.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAddIncomeCategory.Location = new Point(272, 311);
            btnAddIncomeCategory.Name = "btnAddIncomeCategory";
            btnAddIncomeCategory.Size = new Size(132, 35);
            btnAddIncomeCategory.TabIndex = 23;
            btnAddIncomeCategory.Text = "Добавить категорию";
            btnAddIncomeCategory.UseVisualStyleBackColor = false;
            btnAddIncomeCategory.Click += btnAddIncomeCategory_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtAmountOfIncome);
            groupBox4.Font = new Font("Calibri", 11.25F);
            groupBox4.Location = new Point(16, 50);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(185, 80);
            groupBox4.TabIndex = 21;
            groupBox4.TabStop = false;
            groupBox4.Text = "Введите сумму";
            // 
            // txtAmountOfIncome
            // 
            txtAmountOfIncome.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtAmountOfIncome.Location = new Point(6, 25);
            txtAmountOfIncome.Name = "txtAmountOfIncome";
            txtAmountOfIncome.Size = new Size(167, 26);
            txtAmountOfIncome.TabIndex = 17;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dateOfIncome);
            groupBox3.Font = new Font("Calibri", 11.25F);
            groupBox3.Location = new Point(207, 50);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(197, 80);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Выберите дату";
            // 
            // dateOfIncome
            // 
            dateOfIncome.Location = new Point(6, 25);
            dateOfIncome.Name = "dateOfIncome";
            dateOfIncome.Size = new Size(167, 26);
            dateOfIncome.TabIndex = 13;
            dateOfIncome.Value = new DateTime(2024, 3, 17, 16, 45, 18, 0);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstIncomeCategories);
            groupBox2.Font = new Font("Calibri", 11.25F);
            groupBox2.Location = new Point(16, 136);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(388, 169);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Выберите категорию";
            // 
            // lstIncomeCategories
            // 
            lstIncomeCategories.FormattingEnabled = true;
            lstIncomeCategories.ItemHeight = 18;
            lstIncomeCategories.Location = new Point(6, 25);
            lstIncomeCategories.Name = "lstIncomeCategories";
            lstIncomeCategories.Size = new Size(358, 112);
            lstIncomeCategories.TabIndex = 12;
            // 
            // btnAddIncome
            // 
            btnAddIncome.BackColor = Color.LightGoldenrodYellow;
            btnAddIncome.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddIncome.Location = new Point(16, 311);
            btnAddIncome.Name = "btnAddIncome";
            btnAddIncome.Size = new Size(167, 35);
            btnAddIncome.TabIndex = 18;
            btnAddIncome.Text = "Добавить доход";
            btnAddIncome.UseVisualStyleBackColor = false;
            btnAddIncome.Click += btnAddIncome_Click;
            // 
            // AddIncomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(445, 389);
            Controls.Add(groupBox1);
            Name = "AddIncomeForm";
            Text = "Добавление дохода";
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lstIncomeCategories;
        private Button btnAddIncome;
        private DateTimePicker dateOfIncome;
        private TextBox txtAmountOfIncome;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Button btnAddIncomeCategory;
    }
}