using MySql.Data.MySqlClient;
using System;
using System.Data;
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
            var user_login = login.Text;
            var user_pass = password.Text;

            var db = new DataBase();
            var table = new DataTable();
            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("INSERT INTO `users` (`Login`, `Password`, `Role`, `Name`, `Surname`, `Group`) VALUES (@u_login, @u_password, @u_role, @u_name, @u_surname, @u_group)", db.GetConnection());
            command.Parameters.Add("@u_login", MySqlDbType.VarChar).Value = login.Text;
            command.Parameters.Add("@u_password", MySqlDbType.VarChar).Value = password.Text;
            command.Parameters.Add("@u_role", MySqlDbType.VarChar).Value = role_box.SelectedItem;
            command.Parameters.Add("@u_name", MySqlDbType.VarChar).Value = name.Text;
            command.Parameters.Add("@u_surname", MySqlDbType.VarChar).Value = surname.Text;
            command.Parameters.Add("@u_group", MySqlDbType.VarChar).Value = group_box.SelectedItem;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                var new_command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @u_login AND `Password` = @u_password", db.GetConnection());
                new_command.Parameters.Add("@u_login", MySqlDbType.VarChar).Value = user_login;
                new_command.Parameters.Add("@u_password", MySqlDbType.VarChar).Value = user_pass;
                adapter.SelectCommand = new_command;

                try
                {
                    adapter.Fill(table);
                    Student.Table = table;
                }
                catch
                {
                    MessageBox.Show("Данные введены неверно.");
                }

                if ((string)role_box.SelectedItem == "Admin")
                {
                    var form = new CheckAdminForm();
                    form.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Вы успешно зарегистрированы.");
                    var form = new StudentForm();
                    form.Show();
                    Hide();
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