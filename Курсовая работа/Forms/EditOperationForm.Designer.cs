namespace Курсовая_работа.Forms
{
    partial class EditOperationForm
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
            groupBox5 = new GroupBox();
            txtDescription = new TextBox();
            groupBox4 = new GroupBox();
            txtAmount = new TextBox();
            groupBox3 = new GroupBox();
            date = new DateTimePicker();
            groupBox2 = new GroupBox();
            lstCategories = new ListBox();
            btnSave = new Button();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(417, 482);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Редактирование операции";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtDescription);
            groupBox5.Font = new Font("Calibri", 11.25F);
            groupBox5.Location = new Point(16, 311);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(388, 124);
            groupBox5.TabIndex = 24;
            groupBox5.TabStop = false;
            groupBox5.Text = "Введите описание";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(6, 25);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(358, 82);
            txtDescription.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtAmount);
            groupBox4.Font = new Font("Calibri", 11.25F);
            groupBox4.Location = new Point(16, 50);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(185, 80);
            groupBox4.TabIndex = 21;
            groupBox4.TabStop = false;
            groupBox4.Text = "Введите сумму";
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtAmount.Location = new Point(6, 25);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(167, 26);
            txtAmount.TabIndex = 17;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(date);
            groupBox3.Font = new Font("Calibri", 11.25F);
            groupBox3.Location = new Point(207, 50);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(197, 80);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Выберите дату";
            // 
            // date
            // 
            date.Location = new Point(6, 25);
            date.Name = "date";
            date.Size = new Size(167, 26);
            date.TabIndex = 13;
            date.Value = new DateTime(2024, 3, 17, 16, 45, 18, 0);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstCategories);
            groupBox2.Font = new Font("Calibri", 11.25F);
            groupBox2.Location = new Point(16, 136);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(388, 169);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Выберите категорию";
            // 
            // lstCategories
            // 
            lstCategories.FormattingEnabled = true;
            lstCategories.ItemHeight = 18;
            lstCategories.Location = new Point(6, 25);
            lstCategories.Name = "lstCategories";
            lstCategories.Size = new Size(358, 130);
            lstCategories.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightGoldenrodYellow;
            btnSave.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSave.Location = new Point(16, 441);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(167, 35);
            btnSave.TabIndex = 18;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // EditOperationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(445, 506);
            Controls.Add(groupBox1);
            Name = "EditOperationForm";
            Text = "EditOperationForm";
            Load += EditOperationForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox5;
        private TextBox txtDescription;
        private GroupBox groupBox4;
        private TextBox txtAmount;
        private GroupBox groupBox3;
        private DateTimePicker date;
        private GroupBox groupBox2;
        private ListBox lstCategories;
        private Button btnSave;
    }
}