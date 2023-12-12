namespace DemoPrimer.Forms.Roles
{
    partial class AdminForm
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
            this.Users_btn = new System.Windows.Forms.Button();
            this.Orders_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Users_btn
            // 
            this.Users_btn.Location = new System.Drawing.Point(25, 47);
            this.Users_btn.Name = "Users_btn";
            this.Users_btn.Size = new System.Drawing.Size(154, 265);
            this.Users_btn.TabIndex = 0;
            this.Users_btn.Text = "Пользователи";
            this.Users_btn.UseVisualStyleBackColor = true;
            this.Users_btn.Click += new System.EventHandler(this.Users_btn_Click);
            // 
            // Orders_btn
            // 
            this.Orders_btn.Location = new System.Drawing.Point(208, 47);
            this.Orders_btn.Name = "Orders_btn";
            this.Orders_btn.Size = new System.Drawing.Size(154, 265);
            this.Orders_btn.TabIndex = 1;
            this.Orders_btn.Text = "Заказы";
            this.Orders_btn.UseVisualStyleBackColor = true;
            this.Orders_btn.Click += new System.EventHandler(this.Orders_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 387);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Orders_btn);
            this.Controls.Add(this.Users_btn);
            this.Name = "AdminForm";
            this.Text = "Администратор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Users_btn;
        private System.Windows.Forms.Button Orders_btn;
        private System.Windows.Forms.Label label1;
    }
}