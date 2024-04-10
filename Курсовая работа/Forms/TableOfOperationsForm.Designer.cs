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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
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
            groupBox1.Location = new Point(25, 360);
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
            // TableOfOperationsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(563, 450);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "TableOfOperationsForm";
            Text = "Список операций";
            Load += TableOfOperationsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private RadioButton radioExpenses;
        private GroupBox groupBox1;
        private RadioButton radioAllOperations;
        private RadioButton radioIncomes;
    }
}