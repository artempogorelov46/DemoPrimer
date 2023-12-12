namespace DemoPrimer.Forms.Orders
{
    partial class OrdersForm
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
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_Order_btn = new System.Windows.Forms.Button();
            this.Update_Orders_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(776, 329);
            this.dataGridViewOrders.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(327, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Заказы";
            // 
            // Add_Order_btn
            // 
            this.Add_Order_btn.Location = new System.Drawing.Point(171, 383);
            this.Add_Order_btn.Name = "Add_Order_btn";
            this.Add_Order_btn.Size = new System.Drawing.Size(146, 46);
            this.Add_Order_btn.TabIndex = 2;
            this.Add_Order_btn.Text = "Добавить";
            this.Add_Order_btn.UseVisualStyleBackColor = true;
            this.Add_Order_btn.Click += new System.EventHandler(this.Add_Order_btn_Click);
            // 
            // Update_Orders_btn
            // 
            this.Update_Orders_btn.Location = new System.Drawing.Point(408, 383);
            this.Update_Orders_btn.Name = "Update_Orders_btn";
            this.Update_Orders_btn.Size = new System.Drawing.Size(146, 46);
            this.Update_Orders_btn.TabIndex = 3;
            this.Update_Orders_btn.Text = "Обновить";
            this.Update_Orders_btn.UseVisualStyleBackColor = true;
            this.Update_Orders_btn.Click += new System.EventHandler(this.Update_Orders_btn_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Update_Orders_btn);
            this.Controls.Add(this.Add_Order_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewOrders);
            this.Name = "OrdersForm";
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_Order_btn;
        private System.Windows.Forms.Button Update_Orders_btn;
    }
}