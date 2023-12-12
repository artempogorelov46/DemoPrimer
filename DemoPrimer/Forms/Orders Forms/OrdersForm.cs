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

namespace DemoPrimer.Forms.Orders
{
    public partial class OrdersForm : Form
    {
        private decimal? _roleId = null;
        public OrdersForm(decimal? roleId)
        {
            InitializeComponent();
            _roleId = roleId;
            using (var db = new demodbEntities())
            {
                dataGridViewOrders.DataSource = db.Orders.Select(o => new
                {
                   Номер_заказа = o.ID,
                   Имя_клиента = o.Users.FirstName,
                   Фамилия_клиента = o.Users.LastName,
                   Оборудование = o.EquipmentTypes.EquipmentType,
                   Проблема = o.ProblemTypes.ProblemType,
                   Имя_техника = o.Technicians.Users.FirstName,
                   Фамилия_техника = o.Technicians.Users.LastName,
                   Статус = o.Statuses.StatusName,
                   Дата_оформления = o.DateOrderOpen
                }).ToArray();
            }
        }

     
        private void Add_Order_btn_Click(object sender, EventArgs e)
        {
            NewOrderForm noForm = new NewOrderForm();
            noForm.ShowDialog();
           
        }

        private void Update_Orders_btn_Click(object sender, EventArgs e)
        {
            using (var db = new demodbEntities())
            {
                dataGridViewOrders.DataSource = db.Orders.Select(o => new
                {
                    Номер_заказа = o.ID,
                    Имя_клиента = o.Users.FirstName,
                    Фамилия_клиента = o.Users.LastName,
                    Оборудование = o.EquipmentTypes.EquipmentType,
                    Проблема = o.ProblemTypes.ProblemType,
                    Имя_техника = o.Technicians.Users.FirstName,
                    Фамилия_техника = o.Technicians.Users.LastName,
                    Статус = o.Statuses.StatusName,
                    Дата_оформления = o.DateOrderOpen
                }).ToArray();
            }
        }
    }
}
