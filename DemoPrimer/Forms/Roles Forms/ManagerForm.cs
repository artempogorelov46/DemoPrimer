using DemoPrimer.Forms.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoPrimer.Forms.Roles
{
    public partial class ManagerForm : Form
    {
        decimal? _roleId = null;
        public ManagerForm(string userName, decimal? userId, string userNickname)
        {
            InitializeComponent();
            label1.Text = $"Вы вошли как {userNickname}";
        }


        private void Order_btn_Click_1(object sender, EventArgs e)
        {
            OrdersForm oForm = new OrdersForm(_roleId);
            oForm.ShowDialog();
        }

        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
