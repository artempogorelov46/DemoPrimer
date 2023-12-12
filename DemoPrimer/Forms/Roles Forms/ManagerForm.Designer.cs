namespace DemoPrimer.Forms.Roles
{
    partial class ManagerForm
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
            this.Order_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Order_btn
            // 
            this.Order_btn.Location = new System.Drawing.Point(29, 57);
            this.Order_btn.Name = "Order_btn";
            this.Order_btn.Size = new System.Drawing.Size(196, 242);
            this.Order_btn.TabIndex = 1;
            this.Order_btn.Text = "Заказы";
            this.Order_btn.UseVisualStyleBackColor = true;
            this.Order_btn.Click += new System.EventHandler(this.Order_btn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 341);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Order_btn);
            this.Name = "ManagerForm";
            this.Text = "Менеджер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Order_btn;
        private System.Windows.Forms.Label label1;
    }
}