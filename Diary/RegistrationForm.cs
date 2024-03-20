using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Diary
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegisterButtonClick(object sender, EventArgs e)
        {
            var db = new DataBase();
            var command = new MySqlCommand("INSERT INTO `users` (`Login`, `Password`, `Role`, `Name`, `Surname`, `Group`) VALUES (@u_login, @u_password, @u_role, @u_name, @u_surname, @u_group)", db.GetConnection());
            command.Parameters.Add("@u_login", MySqlDbType.VarChar).Value = login.Text;
            command.Parameters.Add("@u_password", MySqlDbType.VarChar).Value = password.Text;
            command.Parameters.Add("@u_role", MySqlDbType.VarChar).Value = role_box.SelectedItem;
            command.Parameters.Add("@u_name", MySqlDbType.VarChar).Value = name.Text;
            command.Parameters.Add("@u_surname", MySqlDbType.VarChar).Value = surname.Text;
            command.Parameters.Add("@u_group", MySqlDbType.Int64).Value = group.Text;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Вы успешно зарегистрированы.");
                if((string)role_box.SelectedItem == "Admin")
                {
                    var form = new AdminForm();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    var form_1 = new StudentForm();
                    form_1.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Вас не удалось зарегистрировать.");
            }

            db.CloseConnection();
        }
    }
}