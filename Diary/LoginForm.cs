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

        // сверяем введённые данные с бд
        void LoginButtonClick(object sender, EventArgs e)
        {
            var user_login = login.Text;
            var user_pass = password.Text;

            var db = new DataBase();
            var data_table = new DataTable();
            var check_data_table = new DataTable();
            var adapter = new MySqlDataAdapter();

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
            catch
            {
                MessageBox.Show("Данные отсутствуют. Неправильный логин или пароль.");
            }

            adapter.SelectCommand = command;
            User.Login = user_login;
            User.Table = data_table;

            // лишние команды для того, чтобы проверить админ ли пользователь
            if (data_table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь успешно авторизован.");
                adapter.Fill(check_data_table);
                if (check_data_table.Rows.Count > 0)
                {
                    var form = new AdminForm();
                    User.Role = "Admin";
                    form.Show();
                    Hide();
                }
                else
                {
                    var form = new StudentForm();
                    form.Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Не удалось авторизовать пользователя.");
            }
        }

        void RegisterButtonClick(object sender, EventArgs e)
        {
            var form = new RegistrationForm();
            form.Show();
            Hide();
        }
    }
}