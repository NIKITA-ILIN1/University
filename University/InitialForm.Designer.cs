namespace University
{
    partial class InitialForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Authorization = new System.Windows.Forms.Button();
            this.ExitTheApplication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(32, 27);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 20);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(32, 67);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // Authorization
            // 
            this.Authorization.Location = new System.Drawing.Point(32, 117);
            this.Authorization.Name = "Authorization";
            this.Authorization.Size = new System.Drawing.Size(90, 23);
            this.Authorization.TabIndex = 2;
            this.Authorization.Text = "Авторизация";
            this.Authorization.UseVisualStyleBackColor = true;
            this.Authorization.Click += new System.EventHandler(this.Authorization_Click);
            // 
            // ExitTheApplication
            // 
            this.ExitTheApplication.Location = new System.Drawing.Point(624, 23);
            this.ExitTheApplication.Name = "ExitTheApplication";
            this.ExitTheApplication.Size = new System.Drawing.Size(130, 23);
            this.ExitTheApplication.TabIndex = 3;
            this.ExitTheApplication.Text = "Выйти из приложения";
            this.ExitTheApplication.UseVisualStyleBackColor = true;
            this.ExitTheApplication.Click += new System.EventHandler(this.ExitTheApplication_Click);
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitTheApplication);
            this.Controls.Add(this.Authorization);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Name = "InitialForm";
            this.Text = "Начальная форма";
            this.Load += new System.EventHandler(this.InitialForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Authorization;
        private System.Windows.Forms.Button ExitTheApplication;
    }
}

