namespace DemoPrimer.Forms.Users
{
    partial class UsersForm
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
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.Add_User_btn = new System.Windows.Forms.Button();
            this.Update_Users_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(12, 29);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(776, 332);
            this.dataGridViewUsers.TabIndex = 0;
            // 
            // Add_User_btn
            // 
            this.Add_User_btn.Location = new System.Drawing.Point(212, 385);
            this.Add_User_btn.Name = "Add_User_btn";
            this.Add_User_btn.Size = new System.Drawing.Size(137, 53);
            this.Add_User_btn.TabIndex = 1;
            this.Add_User_btn.Text = "Добавить";
            this.Add_User_btn.UseVisualStyleBackColor = true;
            this.Add_User_btn.Click += new System.EventHandler(this.Add_User_btn_Click);
            // 
            // Update_Users_btn
            // 
            this.Update_Users_btn.Location = new System.Drawing.Point(412, 385);
            this.Update_Users_btn.Name = "Update_Users_btn";
            this.Update_Users_btn.Size = new System.Drawing.Size(137, 53);
            this.Update_Users_btn.TabIndex = 2;
            this.Update_Users_btn.Text = "Обновить";
            this.Update_Users_btn.UseVisualStyleBackColor = true;
            this.Update_Users_btn.Click += new System.EventHandler(this.Update_Users_btn_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Update_Users_btn);
            this.Controls.Add(this.Add_User_btn);
            this.Controls.Add(this.dataGridViewUsers);
            this.Name = "UsersForm";
            this.Text = "Пользователи";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button Add_User_btn;
        private System.Windows.Forms.Button Update_Users_btn;
    }
}