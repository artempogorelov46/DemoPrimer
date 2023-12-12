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

namespace DemoPrimer.Forms.Users
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            using (var db = new demodbEntities())
            {
                dataGridViewUsers.DataSource = db.Users.Select(u => new {
                    u.ID,
                   Имя = u.FirstName,
                   Фамилия = u.LastName,
                   Роль = u.Roles.RoleName
                }).ToArray();
            }
        }

        private void Add_User_btn_Click(object sender, EventArgs e)
        {
            NewUserForm nuForm = new NewUserForm();
            nuForm.ShowDialog();
        }

        private void Update_Users_btn_Click(object sender, EventArgs e)
        {
            using (var db = new demodbEntities())
            {
                dataGridViewUsers.DataSource = db.Users.Select(u => new {
                    u.ID,
                    Имя = u.FirstName,
                    Фамилия = u.LastName,
                    Роль = u.Roles.RoleName
                }).ToArray();
            }
        }
    }
}
