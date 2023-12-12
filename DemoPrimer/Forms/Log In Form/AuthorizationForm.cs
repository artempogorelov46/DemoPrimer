using DemoPrimer.database;
using DemoPrimer.Forms;
using DemoPrimer.Forms.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoPrimer
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }
        private decimal? _userId = null;
        private string _userName = null;
        private string _roleName = "no avtorized";
        private string _usernickname = null;

        private void Log_In_btn_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            try
            {
                using (var db = new demodbEntities())
                {
                    var userData = db.Users.FirstOrDefault(user => user.Login == login);
                  
                    if (userData != null)
                    {
                        _userName = userData.FirstName;
                        _userId = userData.ID;
                        _usernickname = userData.Nickname;
                       
                    }

                    var roleId = userData.ID_role;

                    _roleName = db.Roles.First(role => role.ID == roleId).RoleName;
                }
                MessageBox.Show("Вы вошли как " + _roleName);
                LoadMainForms();
            }
            catch (Exception ex)
            {
                MessageBox.Show("неверный логин или пароль, повторте попытку снова.");
            }
        }

        private void LoadMainForms()
        {
            switch (_roleName)
            {
                case "Клиент              ":
                    ClientForm cForm = new ClientForm(_userName, _userId, _usernickname);
                    cForm.Show();
                    this.Hide();
                    break;
                case "Менеджер            ":
                    ManagerForm mForm = new ManagerForm(_userName, _userId, _usernickname);
                    mForm.Show();
                    this.Hide();
                    break;
                case "Админ               ":
                    AdminForm aForm = new AdminForm(_userName, _userId, _usernickname);
                    aForm.Show();
                    this.Hide();
                    break;
                case "Техник              ":
                    TechnicForm tForm = new TechnicForm(_userName, _userId, _usernickname);
                    tForm.Show();
                    this.Hide();
                    break;
                default:
                    //
                    break;

            }
        }
    }
}
