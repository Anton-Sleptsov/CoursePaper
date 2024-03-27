namespace Курсовая_работа
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            btnOpenAddExpenditureForm = new Button();
            btnOpenAddIncomeForm = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Edit;
            pictureBox1.Location = new Point(186, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
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
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(720, 318);
            Controls.Add(btnOpenAddIncomeForm);
            Controls.Add(btnOpenAddExpenditureForm);
            Controls.Add(pictureBox1);
            Controls.Add(txtBalance);
            Controls.Add(lblBalance);
            Name = "Form1";
            Text = "Личный бюджет";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBalance;
        private TextBox txtBalance;
        private PictureBox pictureBox1;
        private Button btnOpenAddExpenditureForm;
        private Button btnOpenAddIncomeForm;
    }
}
