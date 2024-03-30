using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Diary
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        void AddStudentButtonClick(object sender, EventArgs e)
        {
            var user_login = login.Text;
            var user_pass = password.Text;

            var db = new DataBase();
            var table = new DataTable();
            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("INSERT INTO `users` (`Login`, `Password`, `Role`, `Name`, `Surname`, `Group`, `Math_Info`, `Prog_Info`, `Phys_Info`, `Eng_Info`, `Alg_Info`, `His_Info`, `Rus_Info`, `Law_Info`, `UPic`) VALUES (@u_login, @u_password, @u_role, @u_name, @u_surname, @u_group, '', '', '', '', '', '', '', '', '')", db.GetConnection());
            command.Parameters.Add("@u_login", MySqlDbType.VarChar).Value = user_login;
            command.Parameters.Add("@u_password", MySqlDbType.VarChar).Value = user_pass;
            command.Parameters.Add("@u_role", MySqlDbType.VarChar).Value = "Student";
            command.Parameters.Add("@u_name", MySqlDbType.VarChar).Value = name.Text;
            command.Parameters.Add("@u_surname", MySqlDbType.VarChar).Value = surname.Text;
            command.Parameters.Add("@u_group", MySqlDbType.VarChar).Value = group_box.SelectedItem;

            db.OpenConnection();

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    var new_command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @u_login AND `Password` = @u_password", db.GetConnection());
                    new_command.Parameters.Add("@u_login", MySqlDbType.VarChar).Value = user_login;
                    new_command.Parameters.Add("@u_password", MySqlDbType.VarChar).Value = user_pass;
                    adapter.SelectCommand = new_command;

                    try
                    {
                        adapter.Fill(table);
                        MessageBox.Show("Новый студент успешно добавлен.");
                        Hide();
                    }
                    catch
                    {
                        MessageBox.Show("Данные введены неверно.");
                    }
                }
                else
                {
                    MessageBox.Show("Не удалось добавить студента.");
                }
            }
            catch
            {
                MessageBox.Show("Студента не удалось добавить.");
            }

            db.CloseConnection();
        }
    }
}