namespace DemoPrimer.Forms.Orders
{
    partial class NewOrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewMasters = new System.Windows.Forms.DataGridView();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.comboBoxTypeEquipment = new System.Windows.Forms.ComboBox();
            this.comboBoxTypeProblem = new System.Windows.Forms.ComboBox();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.Create_Order_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оборудование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Проблема";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Техники";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Клиенты";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Поиск по";
            // 
            // dataGridViewMasters
            // 
            this.dataGridViewMasters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMasters.Location = new System.Drawing.Point(11, 43);
            this.dataGridViewMasters.Name = "dataGridViewMasters";
            this.dataGridViewMasters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMasters.Size = new System.Drawing.Size(467, 112);
            this.dataGridViewMasters.TabIndex = 5;
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(13, 202);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClients.Size = new System.Drawing.Size(467, 118);
            this.dataGridViewClients.TabIndex = 6;
            // 
            // comboBoxTypeEquipment
            // 
            this.comboBoxTypeEquipment.FormattingEnabled = true;
            this.comboBoxTypeEquipment.Location = new System.Drawing.Point(510, 52);
            this.comboBoxTypeEquipment.Name = "comboBoxTypeEquipment";
            this.comboBoxTypeEquipment.Size = new System.Drawing.Size(257, 21);
            this.comboBoxTypeEquipment.TabIndex = 7;
            this.comboBoxTypeEquipment.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeEquipment_SelectedIndexChanged);
            // 
            // comboBoxTypeProblem
            // 
            this.comboBoxTypeProblem.FormattingEnabled = true;
            this.comboBoxTypeProblem.Location = new System.Drawing.Point(510, 101);
            this.comboBoxTypeProblem.Name = "comboBoxTypeProblem";
            this.comboBoxTypeProblem.Size = new System.Drawing.Size(257, 21);
            this.comboBoxTypeProblem.TabIndex = 8;
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(567, 232);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(172, 21);
            this.comboBoxSearch.TabIndex = 9;
            this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearch_SelectedIndexChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(510, 202);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(229, 20);
            this.textBoxSearch.TabIndex = 10;
            this.textBoxSearch.Text = "Поиск";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Комментарий";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(15, 364);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(756, 86);
            this.textBoxComment.TabIndex = 12;
            // 
            // Create_Order_btn
            // 
            this.Create_Order_btn.Location = new System.Drawing.Point(294, 456);
            this.Create_Order_btn.Name = "Create_Order_btn";
            this.Create_Order_btn.Size = new System.Drawing.Size(198, 41);
            this.Create_Order_btn.TabIndex = 13;
            this.Create_Order_btn.Text = "Создать";
            this.Create_Order_btn.UseVisualStyleBackColor = true;
            this.Create_Order_btn.Click += new System.EventHandler(this.Create_Order_btn_Click);
            // 
            // NewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.Create_Order_btn);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.comboBoxTypeProblem);
            this.Controls.Add(this.comboBoxTypeEquipment);
            this.Controls.Add(this.dataGridViewClients);
            this.Controls.Add(this.dataGridViewMasters);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewOrderForm";
            this.Text = "Новый заказ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewMasters;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.ComboBox comboBoxTypeEquipment;
        private System.Windows.Forms.ComboBox comboBoxTypeProblem;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Button Create_Order_btn;
    }
}