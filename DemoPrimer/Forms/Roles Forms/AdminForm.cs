using System;
using DemoPrimer.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoPrimer.database;
using DemoPrimer.Forms.Users;
using DemoPrimer.Forms.Orders;

namespace DemoPrimer.Forms.Roles
{
    public partial class AdminForm : Form
    {
        decimal? _roleID;
        public AdminForm(string userName, decimal? userId, string userNickname)
        {
            InitializeComponent();
            label1.Text = $"Вы вошли как {userNickname}";
        }

        private void Users_btn_Click(object sender, EventArgs e)
        {
            UsersForm uForm = new UsersForm();
            uForm.ShowDialog();
        }

        private void Orders_btn_Click(object sender, EventArgs e)
        {
            OrdersForm oForm = new OrdersForm(_roleID);
            oForm.ShowDialog();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
