namespace Курсовая_работа
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBalance = new Label();
            txtBalance = new TextBox();
            pbEdit = new PictureBox();
            btnOpenAddExpenditureForm = new Button();
            btnOpenAddIncomeForm = new Button();
            btnAllCategories = new Button();
            btnTableOfOperations = new Button();
            ((System.ComponentModel.ISupportInitialize)pbEdit).BeginInit();
            SuspendLayout();
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblBalance.Location = new Point(12, 9);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(81, 26);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "Баланс:";
            // 
            // txtBalance
            // 
            txtBalance.Enabled = false;
            txtBalance.Font = new Font("Calibri", 15.75F, FontStyle.Bold);
            txtBalance.Location = new Point(99, 6);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(80, 33);
            txtBalance.TabIndex = 1;
            txtBalance.Text = "0";
            // 
            // pbEdit
            // 
            pbEdit.Image = Properties.Resources.Edit;
            pbEdit.Location = new Point(186, 6);
            pbEdit.Name = "pbEdit";
            pbEdit.Size = new Size(33, 34);
            pbEdit.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEdit.TabIndex = 2;
            pbEdit.TabStop = false;
            pbEdit.Click += pbEdit_Click;
            // 
            // btnOpenAddExpenditureForm
            // 
            btnOpenAddExpenditureForm.BackColor = Color.LightGoldenrodYellow;
            btnOpenAddExpenditureForm.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnOpenAddExpenditureForm.Location = new Point(12, 74);
            btnOpenAddExpenditureForm.Name = "btnOpenAddExpenditureForm";
            btnOpenAddExpenditureForm.Size = new Size(207, 35);
            btnOpenAddExpenditureForm.TabIndex = 19;
            btnOpenAddExpenditureForm.Text = "Добавить расход";
            btnOpenAddExpenditureForm.UseVisualStyleBackColor = false;
            btnOpenAddExpenditureForm.Click += btnOpenAddExpenditureForm_Click;
            // 
            // btnOpenAddIncomeForm
            // 
            btnOpenAddIncomeForm.BackColor = Color.LightGoldenrodYellow;
            btnOpenAddIncomeForm.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnOpenAddIncomeForm.Location = new Point(12, 124);
            btnOpenAddIncomeForm.Name = "btnOpenAddIncomeForm";
            btnOpenAddIncomeForm.Size = new Size(207, 35);
            btnOpenAddIncomeForm.TabIndex = 20;
            btnOpenAddIncomeForm.Text = "Добавить доход";
            btnOpenAddIncomeForm.UseVisualStyleBackColor = false;
            btnOpenAddIncomeForm.Click += btnOpenAddIncomeForm_Click;
            // 
            // btnAllCategories
            // 
            btnAllCategories.BackColor = Color.LightGoldenrodYellow;
            btnAllCategories.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAllCategories.Location = new Point(12, 174);
            btnAllCategories.Name = "btnAllCategories";
            btnAllCategories.Size = new Size(207, 35);
            btnAllCategories.TabIndex = 21;
            btnAllCategories.Text = "Категории";
            btnAllCategories.UseVisualStyleBackColor = false;
            btnAllCategories.Click += btnAllCategories_Click;
            // 
            // btnTableOfOperations
            // 
            btnTableOfOperations.BackColor = Color.LightGoldenrodYellow;
            btnTableOfOperations.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnTableOfOperations.Location = new Point(12, 225);
            btnTableOfOperations.Name = "btnTableOfOperations";
            btnTableOfOperations.Size = new Size(207, 35);
            btnTableOfOperations.TabIndex = 22;
            btnTableOfOperations.Text = "Список операций";
            btnTableOfOperations.UseVisualStyleBackColor = false;
            btnTableOfOperations.Click += btnTableOfOperations_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(315, 318);
            Controls.Add(btnTableOfOperations);
            Controls.Add(btnAllCategories);
            Controls.Add(btnOpenAddIncomeForm);
            Controls.Add(btnOpenAddExpenditureForm);
            Controls.Add(pbEdit);
            Controls.Add(txtBalance);
            Controls.Add(lblBalance);
            Name = "MainForm";
            Text = "Личный бюджет";
            ((System.ComponentModel.ISupportInitialize)pbEdit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBalance;
        private TextBox txtBalance;
        private PictureBox pbEdit;
        private Button btnOpenAddExpenditureForm;
        private Button btnOpenAddIncomeForm;
        private Button btnAllCategories;
        private Button btnTableOfOperations;
    }
}
