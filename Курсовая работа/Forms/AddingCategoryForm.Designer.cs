namespace Курсовая_работа.Forms
{
    partial class AddingCategoryForm
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
            txtTitleOfCategory = new TextBox();
            btnAddingCategory = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtTitleOfCategory
            // 
            txtTitleOfCategory.Location = new Point(43, 54);
            txtTitleOfCategory.Name = "txtTitleOfCategory";
            txtTitleOfCategory.Size = new Size(247, 23);
            txtTitleOfCategory.TabIndex = 0;
            // 
            // btnAddingCategory
            // 
            btnAddingCategory.BackColor = Color.LightGoldenrodYellow;
            btnAddingCategory.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddingCategory.Location = new Point(43, 93);
            btnAddingCategory.Name = "btnAddingCategory";
            btnAddingCategory.Size = new Size(247, 35);
            btnAddingCategory.TabIndex = 19;
            btnAddingCategory.Text = "Добавить категорию";
            btnAddingCategory.UseVisualStyleBackColor = false;
            btnAddingCategory.Click += btnAddingCategory_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            label1.Location = new Point(43, 19);
            label1.Name = "label1";
            label1.Size = new Size(247, 23);
            label1.TabIndex = 20;
            label1.Text = "Введите название категории";
            // 
            // AddingCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(337, 162);
            Controls.Add(label1);
            Controls.Add(btnAddingCategory);
            Controls.Add(txtTitleOfCategory);
            Name = "AddingCategory";
            Text = "Добавление категории";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitleOfCategory;
        private Button btnAddingCategory;
        private Label label1;
    }
}