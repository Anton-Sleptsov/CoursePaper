﻿namespace Курсовая_работа.Forms
{
    partial class AddExpenditureForm
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
            groupBox4 = new GroupBox();
            txtAmountOfExpense = new TextBox();
            groupBox3 = new GroupBox();
            dateOfExpenditure = new DateTimePicker();
            groupBox2 = new GroupBox();
            lstExpenseCategories = new ListBox();
            btnAddExpense = new Button();
            btnAddExpenseCategory = new Button();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddExpenseCategory);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btnAddExpense);
            groupBox1.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(417, 366);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавить расход";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtAmountOfExpense);
            groupBox4.Font = new Font("Calibri", 11.25F);
            groupBox4.Location = new Point(16, 50);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(185, 80);
            groupBox4.TabIndex = 21;
            groupBox4.TabStop = false;
            groupBox4.Text = "Введите сумму";
            // 
            // txtAmountOfExpense
            // 
            txtAmountOfExpense.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtAmountOfExpense.Location = new Point(6, 25);
            txtAmountOfExpense.Name = "txtAmountOfExpense";
            txtAmountOfExpense.Size = new Size(167, 26);
            txtAmountOfExpense.TabIndex = 17;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dateOfExpenditure);
            groupBox3.Font = new Font("Calibri", 11.25F);
            groupBox3.Location = new Point(207, 50);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(197, 80);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Выберите дату";
            // 
            // dateOfExpenditure
            // 
            dateOfExpenditure.Location = new Point(6, 25);
            dateOfExpenditure.Name = "dateOfExpenditure";
            dateOfExpenditure.Size = new Size(167, 26);
            dateOfExpenditure.TabIndex = 13;
            dateOfExpenditure.Value = new DateTime(2024, 3, 17, 16, 45, 18, 0);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstExpenseCategories);
            groupBox2.Font = new Font("Calibri", 11.25F);
            groupBox2.Location = new Point(16, 136);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(388, 169);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Выберите категорию";
            // 
            // lstExpenseCategories
            // 
            lstExpenseCategories.FormattingEnabled = true;
            lstExpenseCategories.ItemHeight = 18;
            lstExpenseCategories.Location = new Point(6, 25);
            lstExpenseCategories.Name = "lstExpenseCategories";
            lstExpenseCategories.Size = new Size(358, 112);
            lstExpenseCategories.TabIndex = 12;
            // 
            // btnAddExpense
            // 
            btnAddExpense.BackColor = Color.LightGoldenrodYellow;
            btnAddExpense.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddExpense.Location = new Point(16, 311);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(167, 35);
            btnAddExpense.TabIndex = 18;
            btnAddExpense.Text = "Добавить расход";
            btnAddExpense.UseVisualStyleBackColor = false;
            // 
            // btnAddExpenseCategory
            // 
            btnAddExpenseCategory.BackColor = Color.LightGoldenrodYellow;
            btnAddExpenseCategory.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAddExpenseCategory.Location = new Point(272, 311);
            btnAddExpenseCategory.Name = "btnAddExpenseCategory";
            btnAddExpenseCategory.Size = new Size(132, 35);
            btnAddExpenseCategory.TabIndex = 22;
            btnAddExpenseCategory.Text = "Добавить категорию";
            btnAddExpenseCategory.UseVisualStyleBackColor = false;
            btnAddExpenseCategory.Click += btnAddExpenseCategory_Click;
            // 
            // AddExpenditureForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(445, 389);
            Controls.Add(groupBox1);
            Name = "AddExpenditureForm";
            Text = "Добавление расхода";
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lstExpenseCategories;
        private Button btnAddExpense;
        private DateTimePicker dateOfExpenditure;
        private TextBox txtAmountOfExpense;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Button btnAddExpenseCategory;
    }
}