namespace University
{
    partial class InformationStudent
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
            this.InfStd = new System.Windows.Forms.Label();
            this.LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfStd
            // 
            this.InfStd.AutoSize = true;
            this.InfStd.Location = new System.Drawing.Point(39, 32);
            this.InfStd.Name = "InfStd";
            this.InfStd.Size = new System.Drawing.Size(35, 13);
            this.InfStd.TabIndex = 0;
            this.InfStd.Text = "InfStd";
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(640, 22);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(109, 23);
            this.LogOut.TabIndex = 1;
            this.LogOut.Text = "Разлогиниться";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // InformationStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.InfStd);
            this.Name = "InformationStudent";
            this.Text = "Информация о студенте";
            this.Load += new System.EventHandler(this.InformationStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfStd;
        private System.Windows.Forms.Button LogOut;
    }
}