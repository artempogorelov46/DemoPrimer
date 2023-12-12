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
    public partial class TechnicForm : Form
    {
        public TechnicForm(string userName, decimal? userId, string userNickname)
        {
            InitializeComponent();
            label1.Text = $"Вы вошли как {userNickname}";
        }

        private void New_Order_btn_Click(object sender, EventArgs e)
        {

        }

        private void End_Order_Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
