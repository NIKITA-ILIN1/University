namespace University
{
    partial class InformationTeacher
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
            this.InfTchr = new System.Windows.Forms.Label();
            this.LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfTchr
            // 
            this.InfTchr.AutoSize = true;
            this.InfTchr.Location = new System.Drawing.Point(36, 28);
            this.InfTchr.Name = "InfTchr";
            this.InfTchr.Size = new System.Drawing.Size(41, 13);
            this.InfTchr.TabIndex = 0;
            this.InfTchr.Text = "InfTchr";
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(639, 28);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(107, 23);
            this.LogOut.TabIndex = 1;
            this.LogOut.Text = "Разлогиниться";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // InformationTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.InfTchr);
            this.Name = "InformationTeacher";
            this.Text = "Информация о преподавателе";
            this.Load += new System.EventHandler(this.InformationTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfTchr;
        private System.Windows.Forms.Button LogOut;
    }
}