using DemoPrimer.database;
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
    public partial class ClientForm : Form
    {
        public ClientForm(string userName, decimal? userId, string userNickname)
        {
            InitializeComponent();
            label1.Text = $"Вы вошли как {userNickname}";
            using (var db = new demodbEntities())
            {
                dataGridViewOrderClient.DataSource = db.Orders.Where(o => o.ID_Client == userId).Select(o => new
                {
                   Номер_заказа = o.ID,
                   Статус = o.Statuses.StatusName,
                   Имя_техника=  o.Technicians.Users.FirstName,
                   Фамилия_техника= o.Technicians.Users.LastName,
                   Оборудование = o.EquipmentTypes.EquipmentType,
                   Тип_проблемы = o.ProblemTypes.ProblemType,
                   Комментарии = o.Comments
                }).ToArray();
                
            }
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
