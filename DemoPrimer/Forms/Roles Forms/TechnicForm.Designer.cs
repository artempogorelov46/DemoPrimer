namespace DemoPrimer.Forms.Roles
{
    partial class TechnicForm
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
            this.New_Order_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.End_Order_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // New_Order_btn
            // 
            this.New_Order_btn.Location = new System.Drawing.Point(21, 77);
            this.New_Order_btn.Name = "New_Order_btn";
            this.New_Order_btn.Size = new System.Drawing.Size(149, 247);
            this.New_Order_btn.TabIndex = 0;
            this.New_Order_btn.Text = "Новые заказы";
            this.New_Order_btn.UseVisualStyleBackColor = true;
            this.New_Order_btn.Click += new System.EventHandler(this.New_Order_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // End_Order_Btn
            // 
            this.End_Order_Btn.Location = new System.Drawing.Point(225, 77);
            this.End_Order_Btn.Name = "End_Order_Btn";
            this.End_Order_Btn.Size = new System.Drawing.Size(149, 247);
            this.End_Order_Btn.TabIndex = 2;
            this.End_Order_Btn.Text = "Завершенные заказы";
            this.End_Order_Btn.UseVisualStyleBackColor = true;
            this.End_Order_Btn.Click += new System.EventHandler(this.End_Order_Btn_Click);
            // 
            // TechnicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 400);
            this.Controls.Add(this.End_Order_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.New_Order_btn);
            this.Name = "TechnicForm";
            this.Text = "Техник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button New_Order_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button End_Order_Btn;
    }
}