namespace University
{
    partial class InformationAdministrator
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
            this.InfAdmin = new System.Windows.Forms.Label();
            this.CreateStudent = new System.Windows.Forms.Button();
            this.CreateTeacher = new System.Windows.Forms.Button();
            this.DeleteStudent = new System.Windows.Forms.Button();
            this.ExitOnInitialForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfAdmin
            // 
            this.InfAdmin.AutoSize = true;
            this.InfAdmin.Location = new System.Drawing.Point(55, 30);
            this.InfAdmin.Name = "InfAdmin";
            this.InfAdmin.Size = new System.Drawing.Size(48, 13);
            this.InfAdmin.TabIndex = 0;
            this.InfAdmin.Text = "InfAdmin";
            // 
            // CreateStudent
            // 
            this.CreateStudent.Location = new System.Drawing.Point(23, 208);
            this.CreateStudent.Name = "CreateStudent";
            this.CreateStudent.Size = new System.Drawing.Size(108, 23);
            this.CreateStudent.TabIndex = 1;
            this.CreateStudent.Text = "Создать студента";
            this.CreateStudent.UseVisualStyleBackColor = true;
            this.CreateStudent.Click += new System.EventHandler(this.CreateStudent_Click);
            // 
            // CreateTeacher
            // 
            this.CreateTeacher.Location = new System.Drawing.Point(166, 208);
            this.CreateTeacher.Name = "CreateTeacher";
            this.CreateTeacher.Size = new System.Drawing.Size(158, 23);
            this.CreateTeacher.TabIndex = 2;
            this.CreateTeacher.Text = "Создать преподавателя";
            this.CreateTeacher.UseVisualStyleBackColor = true;
            this.CreateTeacher.Click += new System.EventHandler(this.CreateTeacher_Click);
            // 
            // DeleteStudent
            // 
            this.DeleteStudent.Location = new System.Drawing.Point(370, 208);
            this.DeleteStudent.Name = "DeleteStudent";
            this.DeleteStudent.Size = new System.Drawing.Size(111, 23);
            this.DeleteStudent.TabIndex = 3;
            this.DeleteStudent.Text = "Удалить студента";
            this.DeleteStudent.UseVisualStyleBackColor = true;
            this.DeleteStudent.Click += new System.EventHandler(this.DeleteStudent_Click);
            // 
            // ExitOnInitialForm
            // 
            this.ExitOnInitialForm.Location = new System.Drawing.Point(607, 20);
            this.ExitOnInitialForm.Name = "ExitOnInitialForm";
            this.ExitOnInitialForm.Size = new System.Drawing.Size(181, 23);
            this.ExitOnInitialForm.TabIndex = 4;
            this.ExitOnInitialForm.Text = "Вернуться на начальную форму";
            this.ExitOnInitialForm.UseVisualStyleBackColor = true;
            this.ExitOnInitialForm.Click += new System.EventHandler(this.ExitOnInitialForm_Click);
            // 
            // InformationAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitOnInitialForm);
            this.Controls.Add(this.DeleteStudent);
            this.Controls.Add(this.CreateTeacher);
            this.Controls.Add(this.CreateStudent);
            this.Controls.Add(this.InfAdmin);
            this.Name = "InformationAdministrator";
            this.Text = "Администратор";
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfAdmin;
        private System.Windows.Forms.Button CreateStudent;
        private System.Windows.Forms.Button CreateTeacher;
        private System.Windows.Forms.Button DeleteStudent;
        private System.Windows.Forms.Button ExitOnInitialForm;
    }
}