using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Diary
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // проверяем данные пользователя в базе при авторизации .
        private void LoginButtonClick(object sender, EventArgs e)
        {
            var user_login = login.Text;
            var user_pass = password.Text;

            var db = new DataBase();
            var data_table = new DataTable();
            var check_data_table = new DataTable();
            // для заполнения таблицы данными из базы
            var adapter = new MySqlDataAdapter();

            // команда для выбора конкретных данных из бд
            // в команду не передаются изначально сами переменные для безопасности, заменяются строкой ниже
            var main_command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @u_login AND `Password` = @u_password", db.GetConnection());
            main_command.Parameters.Add("@u_login", MySqlDbType.VarChar).Value = user_login;
            main_command.Parameters.Add("@u_password", MySqlDbType.VarChar).Value = user_pass;
            var command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @u_login AND `Password` = @u_password AND `Role` = @u_role", db.GetConnection());
            command.Parameters.Add("@u_login", MySqlDbType.VarChar).Value = user_login;
            command.Parameters.Add("@u_password", MySqlDbType.VarChar).Value = user_pass;
            command.Parameters.Add("@u_role", MySqlDbType.VarChar).Value = "Admin";

            adapter.SelectCommand = main_command;
            try 
            {
                adapter.Fill(data_table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            adapter.SelectCommand = command;
            Student.Table = data_table;

            //лишние команды для того, чтобы проверить админ ли пользователь ...
            if(data_table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь авторизован.");
                adapter.Fill(check_data_table);
                if (check_data_table.Rows.Count > 0)
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
                MessageBox.Show("Не удалось авторизовать пользователя.");
            }
        }

        private void RegistrationButtonClick(object sender, EventArgs e)
        {
            var reg_form = new RegistrationForm();
            reg_form.Show();
            this.Hide();
        }
    }
}