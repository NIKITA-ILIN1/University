namespace University
{
    partial class CreateStudent
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
            this.SurnameStudent = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.NameStudent = new System.Windows.Forms.TextBox();
            this.PatronymicStudent = new System.Windows.Forms.TextBox();
            this.AgeStudent = new System.Windows.Forms.TextBox();
            this.LoginStudent = new System.Windows.Forms.TextBox();
            this.PasswordStudent = new System.Windows.Forms.TextBox();
            this.GroupStudent = new System.Windows.Forms.TextBox();
            this.Patronymic = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Group = new System.Windows.Forms.Label();
            this.CreateStd = new System.Windows.Forms.Button();
            this.ExitOnInitialForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SurnameStudent
            // 
            this.SurnameStudent.Location = new System.Drawing.Point(87, 22);
            this.SurnameStudent.Name = "SurnameStudent";
            this.SurnameStudent.Size = new System.Drawing.Size(100, 20);
            this.SurnameStudent.TabIndex = 0;
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(23, 25);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(56, 13);
            this.Surname.TabIndex = 1;
            this.Surname.Text = "Фамилия";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(23, 60);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(29, 13);
            this.Name.TabIndex = 2;
            this.Name.Text = "Имя";
            // 
            // NameStudent
            // 
            this.NameStudent.Location = new System.Drawing.Point(87, 57);
            this.NameStudent.Name = "NameStudent";
            this.NameStudent.Size = new System.Drawing.Size(100, 20);
            this.NameStudent.TabIndex = 3;
            // 
            // PatronymicStudent
            // 
            this.PatronymicStudent.Location = new System.Drawing.Point(87, 97);
            this.PatronymicStudent.Name = "PatronymicStudent";
            this.PatronymicStudent.Size = new System.Drawing.Size(100, 20);
            this.PatronymicStudent.TabIndex = 4;
            // 
            // AgeStudent
            // 
            this.AgeStudent.Location = new System.Drawing.Point(87, 134);
            this.AgeStudent.Name = "AgeStudent";
            this.AgeStudent.Size = new System.Drawing.Size(100, 20);
            this.AgeStudent.TabIndex = 5;
            // 
            // LoginStudent
            // 
            this.LoginStudent.Location = new System.Drawing.Point(87, 174);
            this.LoginStudent.Name = "LoginStudent";
            this.LoginStudent.Size = new System.Drawing.Size(100, 20);
            this.LoginStudent.TabIndex = 6;
            // 
            // PasswordStudent
            // 
            this.PasswordStudent.Location = new System.Drawing.Point(87, 215);
            this.PasswordStudent.Name = "PasswordStudent";
            this.PasswordStudent.Size = new System.Drawing.Size(100, 20);
            this.PasswordStudent.TabIndex = 7;
            // 
            // GroupStudent
            // 
            this.GroupStudent.Location = new System.Drawing.Point(87, 255);
            this.GroupStudent.Name = "GroupStudent";
            this.GroupStudent.Size = new System.Drawing.Size(100, 20);
            this.GroupStudent.TabIndex = 8;
            // 
            // Patronymic
            // 
            this.Patronymic.AutoSize = true;
            this.Patronymic.Location = new System.Drawing.Point(23, 97);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(54, 13);
            this.Patronymic.TabIndex = 9;
            this.Patronymic.Text = "Отчество";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(23, 134);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(49, 13);
            this.Age.TabIndex = 10;
            this.Age.Text = "Возраст";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(23, 174);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(38, 13);
            this.Login.TabIndex = 11;
            this.Login.Text = "Логин";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(23, 215);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(45, 13);
            this.Password.TabIndex = 12;
            this.Password.Text = "Пароль";
            // 
            // Group
            // 
            this.Group.AutoSize = true;
            this.Group.Location = new System.Drawing.Point(23, 255);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(42, 13);
            this.Group.TabIndex = 13;
            this.Group.Text = "Группа";
            // 
            // CreateStd
            // 
            this.CreateStd.Location = new System.Drawing.Point(274, 253);
            this.CreateStd.Name = "CreateStd";
            this.CreateStd.Size = new System.Drawing.Size(117, 23);
            this.CreateStd.TabIndex = 14;
            this.CreateStd.Text = "Создать студента";
            this.CreateStd.UseVisualStyleBackColor = true;
            this.CreateStd.Click += new System.EventHandler(this.CreateStd_Click);
            // 
            // ExitOnInitialForm
            // 
            this.ExitOnInitialForm.Location = new System.Drawing.Point(601, 19);
            this.ExitOnInitialForm.Name = "ExitOnInitialForm";
            this.ExitOnInitialForm.Size = new System.Drawing.Size(187, 23);
            this.ExitOnInitialForm.TabIndex = 15;
            this.ExitOnInitialForm.Text = "Вернуться на начальную форму";
            this.ExitOnInitialForm.UseVisualStyleBackColor = true;
            this.ExitOnInitialForm.Click += new System.EventHandler(this.ExitOnInitialForm_Click);
            // 
            // CreateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitOnInitialForm);
            this.Controls.Add(this.CreateStd);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Patronymic);
            this.Controls.Add(this.GroupStudent);
            this.Controls.Add(this.PasswordStudent);
            this.Controls.Add(this.LoginStudent);
            this.Controls.Add(this.AgeStudent);
            this.Controls.Add(this.PatronymicStudent);
            this.Controls.Add(this.NameStudent);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.SurnameStudent);
            //this.Name = "CreateStudent";
            this.Text = "Создание студента";
            this.Load += new System.EventHandler(this.CreateStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SurnameStudent;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox NameStudent;
        private System.Windows.Forms.TextBox PatronymicStudent;
        private System.Windows.Forms.TextBox AgeStudent;
        private System.Windows.Forms.TextBox LoginStudent;
        private System.Windows.Forms.TextBox PasswordStudent;
        private System.Windows.Forms.TextBox GroupStudent;
        private System.Windows.Forms.Label Patronymic;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Group;
        private System.Windows.Forms.Button CreateStd;
        private System.Windows.Forms.Button ExitOnInitialForm;
    }
}