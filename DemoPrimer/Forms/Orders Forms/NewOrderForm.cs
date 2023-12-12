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
    public partial class NewOrderForm : Form
    {
        public NewOrderForm()
        {
            InitializeComponent();
            comboBoxSearch.DataSource = _search;
            DataMastersandCLients();
        }

        private List<string> _search = new List<string>()
        { "Имени", "Фамилии", "Никнейму", "Номеру"};


        private void DataMastersandCLients()
        {
            using (var db = new demodbEntities())
            {
                var roleIdC = db.Roles.First(name => name.RoleName == "Клиент              ").ID;
                var roleIdT = db.Roles.First(name => name.RoleName == "Техник              ").ID;
                dataGridViewClients.DataSource = db.Users.Where(name => name.ID_role == roleIdC)
                                                        .Select(c => new { c.FirstName, c.LastName, c.Nickname })
                                                        .ToArray();
                dataGridViewMasters.DataSource = db.Users.Where(name => name.ID_role == roleIdT)
                                                        .Select(c => new { c.FirstName, c.LastName, c.Nickname, c.Roles.RoleName })
                                                        .ToArray();

                comboBoxTypeEquipment.DataSource = db.EquipmentTypes.Select(c => c.EquipmentType).ToArray();
                comboBoxTypeEquipment.SelectedIndex = 0;
                comboBoxTypeProblem.DataSource = db.ProblemTypes.Select(c => c.ProblemType).ToArray();
                comboBoxTypeProblem.SelectedIndex = 0;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            using (var db = new demodbEntities())
            {
                var roleId = db.Roles.First(name => name.RoleName == "Клиент              ").ID;
                switch (comboBoxSearch.SelectedItem.ToString())
                {
                    case "Имени":
                        dataGridViewClients.DataSource = db.Users.
                            Where(name => name.ID_role == roleId && name.FirstName.StartsWith(textBoxSearch.Text))
                            .OrderBy(c => c.FirstName)
                            .Select(c => new
                            {
                                c.FirstName,
                                c.LastName,
                                c.Nickname
                            }
                            )
                            .ToArray();
                        break;
                    case "Фамилии":
                        dataGridViewClients.DataSource = db.Users.
                            Where(name => name.ID_role == roleId && name.LastName.StartsWith(textBoxSearch.Text))
                            .OrderBy(c => c.FirstName)
                            .Select(c => new
                            {
                                c.FirstName,
                                c.LastName,
                                c.Nickname
                            }
                            )
                            .ToArray();
                        break;
                    case "Никнейму":
                        dataGridViewClients.DataSource = db.Users.
                            Where(name => name.ID_role == roleId && name.Nickname.StartsWith(textBoxSearch.Text))
                            .OrderBy(c => c.FirstName)
                            .Select(c => new
                            {
                                c.FirstName,
                                c.LastName,
                                c.Nickname
                            }
                            )
                            .ToArray();
                        break;
                    case "Номеру":
                        dataGridViewClients.DataSource = db.Users.
                            Where(name => name.ID_role == roleId && name.Phone.ToString().StartsWith(textBoxSearch.Text))
                            .OrderBy(c => c.FirstName)
                            .Select(c => new
                            {
                                c.FirstName,
                                c.LastName,
                                c.Nickname
                            }
                            )
                            .ToArray();
                        break;
                }


            }
        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void Create_Order_btn_Click(object sender, EventArgs e)
        {
            try
            {

                string clientNicname = dataGridViewClients.SelectedRows[0].Cells[2].Value.ToString();
                string masterNicname = dataGridViewMasters.SelectedRows[0].Cells[2].Value.ToString();
                using (var dbContext = new demodbEntities())
                {
                    database.Orders order = new database.Orders
                    {
                        ID_Client = dbContext.Users.First(c => c.Nickname == clientNicname).ID,
                        ID_TypeEquipment = dbContext.EquipmentTypes.FirstOrDefault(et => et.EquipmentType == comboBoxTypeEquipment.SelectedValue.ToString()).ID,
                        ID_TypeProblem = dbContext.ProblemTypes.First(pt => pt.ProblemType == comboBoxTypeProblem.SelectedValue.ToString()).ID,
                        ID_Technician = dbContext.Technicians.First(th => th.ID_User == dbContext.Users.FirstOrDefault(u => u.Nickname == masterNicname).ID).ID,
                        ID_Status = dbContext.Statuses.First(s => s.StatusName == "Выполняется                   ").ID,
                        DateOrderOpen = DateTime.Today,
                        Comments = textBoxComment.Text,
                        Photo = "нет"
                        
                    };
                    dbContext.Orders.Add(order);
                    dbContext.SaveChanges();
                    MessageBox.Show("Заявка создана");
                    
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка, попробуйте снова.\n" + ex.ToString());
            }
        }

        private void comboBoxTypeEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new demodbEntities())
                {
                    int IDEquipmentTypes = db.EquipmentTypes.First(et => et.EquipmentType == comboBoxTypeEquipment.SelectedValue.ToString()).ID;
                    var roleIdUserMaster = db.Roles.First(name => name.RoleName == "Техник              ").ID;
                    dataGridViewMasters.DataSource = db.Technicians.Where(t => t.Users.ID_role == roleIdUserMaster && (t.ID_TypeEquipment_1 == IDEquipmentTypes ||
                                                                                                                    t.ID_TypeEquipment_2 == IDEquipmentTypes ||
                                                                                                                    t.ID_TypeEquipment_3 == IDEquipmentTypes))
                                                           .Select(t => new { t.Users.FirstName, t.Users.LastName, t.Users.Nickname })
                                                           .ToArray();
                }
            }
            catch
            {
            }
        }
    }
}
