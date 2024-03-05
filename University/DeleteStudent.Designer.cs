namespace University
{
    partial class DeleteStudent
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
            this.listStudents = new System.Windows.Forms.DataGridView();
            this.DelStd = new System.Windows.Forms.Button();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.ReturnOnInitialForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // listStudents
            // 
            this.listStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listStudents.Location = new System.Drawing.Point(12, 12);
            this.listStudents.Name = "listStudents";
            this.listStudents.Size = new System.Drawing.Size(753, 249);
            this.listStudents.TabIndex = 0;
            // 
            // DelStd
            // 
            this.DelStd.Location = new System.Drawing.Point(12, 283);
            this.DelStd.Name = "DelStd";
            this.DelStd.Size = new System.Drawing.Size(112, 23);
            this.DelStd.TabIndex = 1;
            this.DelStd.Text = "Удалить студента";
            this.DelStd.UseVisualStyleBackColor = true;
            this.DelStd.Click += new System.EventHandler(this.DelStd_Click);
            // 
            // SaveChanges
            // 
            this.SaveChanges.Location = new System.Drawing.Point(265, 283);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(129, 23);
            this.SaveChanges.TabIndex = 2;
            this.SaveChanges.Text = "Сохранить изменения";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // ReturnOnInitialForm
            // 
            this.ReturnOnInitialForm.Location = new System.Drawing.Point(572, 283);
            this.ReturnOnInitialForm.Name = "ReturnOnInitialForm";
            this.ReturnOnInitialForm.Size = new System.Drawing.Size(193, 23);
            this.ReturnOnInitialForm.TabIndex = 3;
            this.ReturnOnInitialForm.Text = "Вернуться на начальную форму";
            this.ReturnOnInitialForm.UseVisualStyleBackColor = true;
            this.ReturnOnInitialForm.Click += new System.EventHandler(this.ReturnOnInitialForm_Click);
            // 
            // DeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReturnOnInitialForm);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.DelStd);
            this.Controls.Add(this.listStudents);
            this.Name = "DeleteStudent";
            this.Text = "Удаление студента";
            this.Load += new System.EventHandler(this.DeleteStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listStudents;
        private System.Windows.Forms.Button DelStd;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.Button ReturnOnInitialForm;
    }
}