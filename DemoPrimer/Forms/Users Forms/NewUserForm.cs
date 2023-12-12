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
    public partial class NewUserForm : Form
    {
        private List<string> _roleAdmin = new List<string> { "Клиент              ", "Админ               ", "Менеджер            ", "Техник              " };
        public NewUserForm()
        {
            InitializeComponent();
        }

        private void Add_NewUser_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new demodbEntities())
                {
                    if (db.Users.FirstOrDefault(u => u.Nickname == textBoxNickname.Text) != null)
                    {
                        MessageBox.Show("Такой никнейм уже существует");
                        return;
                    }
                    database.Users user = new database.Users
                    {
                        Login = textBoxLogin.Text,
                        Password = textBoxPassword.Text,
                        FirstName = textBoxName.Text,
                        LastName = textBoxLastname.Text,
                        Nickname = textBoxNickname.Text,
                        Mail = textBoxMail.Text,
                        Phone = Convert.ToInt32(textBoxPhone.Text),
                        RegisterDate = DateTime.Today,
                        ID_role = db.Roles.First(c => c.RoleName == comboBoxRole.Text).ID
                    };

                    db.Users.Add(user); db.SaveChanges();
                    MessageBox.Show("Пользователь добавлен");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка, попробуйте снова.\n" + ex.ToString());
            }
        }
    }
}
