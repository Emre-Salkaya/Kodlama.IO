namespace Personal.Sql.KodlamaIO
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
            dgwCourses = new DataGridView();
            cbxCategory = new ComboBox();
            lblCategory = new Label();
            lblInstructor = new Label();
            cbxInstructor = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgwCourses).BeginInit();
            SuspendLayout();
            // 
            // dgwCourses
            // 
            dgwCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCourses.Location = new Point(12, 117);
            dgwCourses.Name = "dgwCourses";
            dgwCourses.RowHeadersWidth = 51;
            dgwCourses.Size = new Size(1187, 581);
            dgwCourses.TabIndex = 0;
            // 
            // cbxCategory
            // 
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(175, 41);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(305, 28);
            cbxCategory.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Azo Sans", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblCategory.Location = new Point(65, 44);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(90, 22);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Kategori :";
            // 
            // lblInstructor
            // 
            lblInstructor.AutoSize = true;
            lblInstructor.Font = new Font("Azo Sans", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblInstructor.Location = new Point(595, 44);
            lblInstructor.Name = "lblInstructor";
            lblInstructor.Size = new Size(89, 22);
            lblInstructor.TabIndex = 3;
            lblInstructor.Text = "Eğitmen :";
            // 
            // cbxInstructor
            // 
            cbxInstructor.FormattingEnabled = true;
            cbxInstructor.Location = new Point(704, 41);
            cbxInstructor.Name = "cbxInstructor";
            cbxInstructor.Size = new Size(305, 28);
            cbxInstructor.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 710);
            Controls.Add(cbxInstructor);
            Controls.Add(lblInstructor);
            Controls.Add(lblCategory);
            Controls.Add(cbxCategory);
            Controls.Add(dgwCourses);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwCourses;
        private ComboBox cbxCategory;
        private Label lblCategory;
        private Label lblInstructor;
        private ComboBox cbxInstructor;
    }
}
