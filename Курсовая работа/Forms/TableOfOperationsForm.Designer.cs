namespace CoursePaper.Forms
{
    partial class TableOfOperationsForm
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
            dataGridView1 = new DataGridView();
            radioExpenses = new RadioButton();
            groupBox1 = new GroupBox();
            radioAllOperations = new RadioButton();
            radioIncomes = new RadioButton();
            label1 = new Label();
            lblTotalAmount = new Label();
            cbCategories = new ComboBox();
            gbCategories = new GroupBox();
            groupBox2 = new GroupBox();
            radioAllTime = new RadioButton();
            radioThisMonth = new RadioButton();
            radioThisYear = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            gbCategories.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(539, 323);
            dataGridView1.TabIndex = 0;
            // 
            // radioExpenses
            // 
            radioExpenses.AutoSize = true;
            radioExpenses.Location = new Point(6, 22);
            radioExpenses.Name = "radioExpenses";
            radioExpenses.Size = new Size(72, 19);
            radioExpenses.TabIndex = 1;
            radioExpenses.Text = "Расходы";
            radioExpenses.UseVisualStyleBackColor = true;
            radioExpenses.CheckedChanged += radioExpenses_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioAllOperations);
            groupBox1.Controls.Add(radioIncomes);
            groupBox1.Controls.Add(radioExpenses);
            groupBox1.Location = new Point(12, 389);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(225, 54);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вид операции";
            // 
            // radioAllOperations
            // 
            radioAllOperations.AutoSize = true;
            radioAllOperations.Checked = true;
            radioAllOperations.Location = new Point(162, 22);
            radioAllOperations.Name = "radioAllOperations";
            radioAllOperations.Size = new Size(44, 19);
            radioAllOperations.TabIndex = 3;
            radioAllOperations.TabStop = true;
            radioAllOperations.Text = "Все";
            radioAllOperations.UseVisualStyleBackColor = true;
            radioAllOperations.CheckedChanged += radioAllOperations_CheckedChanged;
            // 
            // radioIncomes
            // 
            radioIncomes.AutoSize = true;
            radioIncomes.Location = new Point(84, 22);
            radioIncomes.Name = "radioIncomes";
            radioIncomes.Size = new Size(68, 19);
            radioIncomes.TabIndex = 2;
            radioIncomes.Text = "Доходы";
            radioIncomes.UseVisualStyleBackColor = true;
            radioIncomes.CheckedChanged += radioIncomes_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(404, 355);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 3;
            label1.Text = "Итог:";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblTotalAmount.Location = new Point(471, 355);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(23, 25);
            lblTotalAmount.TabIndex = 4;
            lblTotalAmount.Text = "0";
            // 
            // cbCategories
            // 
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(6, 18);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(164, 23);
            cbCategories.TabIndex = 5;
            cbCategories.SelectedIndexChanged += cbCategories_SelectedIndexChanged;
            // 
            // gbCategories
            // 
            gbCategories.Controls.Add(cbCategories);
            gbCategories.Location = new Point(261, 389);
            gbCategories.Name = "gbCategories";
            gbCategories.Size = new Size(176, 54);
            gbCategories.TabIndex = 6;
            gbCategories.TabStop = false;
            gbCategories.Text = "gbCategories";
            gbCategories.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioAllTime);
            groupBox2.Controls.Add(radioThisMonth);
            groupBox2.Controls.Add(radioThisYear);
            groupBox2.Location = new Point(12, 463);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(425, 54);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Период отображения";
            // 
            // radioAllTime
            // 
            radioAllTime.AutoSize = true;
            radioAllTime.Checked = true;
            radioAllTime.Location = new Point(6, 22);
            radioAllTime.Name = "radioAllTime";
            radioAllTime.Size = new Size(96, 19);
            radioAllTime.TabIndex = 3;
            radioAllTime.TabStop = true;
            radioAllTime.Text = "За всё время";
            radioAllTime.UseVisualStyleBackColor = true;
            radioAllTime.CheckedChanged += radioAllTime_CheckedChanged;
            // 
            // radioThisMonth
            // 
            radioThisMonth.AutoSize = true;
            radioThisMonth.Location = new Point(293, 22);
            radioThisMonth.Name = "radioThisMonth";
            radioThisMonth.Size = new Size(126, 19);
            radioThisMonth.TabIndex = 2;
            radioThisMonth.Text = "За текущий месяц";
            radioThisMonth.UseVisualStyleBackColor = true;
            radioThisMonth.CheckedChanged += radioThisMonth_CheckedChanged;
            // 
            // radioThisYear
            // 
            radioThisYear.AutoSize = true;
            radioThisYear.Location = new Point(148, 22);
            radioThisYear.Name = "radioThisYear";
            radioThisYear.Size = new Size(110, 19);
            radioThisYear.TabIndex = 1;
            radioThisYear.Text = "За текущий год";
            radioThisYear.UseVisualStyleBackColor = true;
            radioThisYear.CheckedChanged += radioThisYear_CheckedChanged;
            // 
            // TableOfOperationsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(563, 550);
            Controls.Add(groupBox2);
            Controls.Add(gbCategories);
            Controls.Add(lblTotalAmount);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "TableOfOperationsForm";
            Text = "Список операций";
            Load += TableOfOperationsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbCategories.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private RadioButton radioExpenses;
        private GroupBox groupBox1;
        private RadioButton radioAllOperations;
        private RadioButton radioIncomes;
        private Label label1;
        private Label lblTotalAmount;
        private ComboBox cbCategories;
        private GroupBox gbCategories;
        private GroupBox groupBox2;
        private RadioButton radioAllTime;
        private RadioButton radioThisMonth;
        private RadioButton radioThisYear;
    }
}