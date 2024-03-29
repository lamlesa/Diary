using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Diary
{
    public partial class ChangeInfoForm : Form
    {
        public byte which;
        public ChangeInfoForm(byte n)
        {
            InitializeComponent();
            which = n;
        }

        private void AcceptButtonClick(object sender, EventArgs e)
        {
            var text = new_field.Text;
            var db = new DataBase();
            var table = new DataTable();
            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand();
            if(which == 1)
            {
                command = new MySqlCommand("UPDATE `users` SET `Login` = @u_log WHERE `users`.`Login` = @cur_log", db.GetConnection());
                command.Parameters.Add("@u_log", MySqlDbType.VarChar).Value = text;
                command.Parameters.Add("@cur_log", MySqlDbType.VarChar).Value = User.Login;
            }
            else
            {
                command = new MySqlCommand("UPDATE `users` SET `Password` = @u_pass WHERE `users`.`Login` = @u_log", db.GetConnection());
                command.Parameters.Add("@u_pass", MySqlDbType.VarChar).Value = text;
                command.Parameters.Add("@u_log", MySqlDbType.VarChar).Value = User.Login;
            }
            
            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                if (which == 1)
                {
                    var new_command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @u_log", db.GetConnection());
                    new_command.Parameters.Add("@u_log", MySqlDbType.VarChar).Value = text;
                    adapter.SelectCommand = new_command;
                }
                else
                {
                    var new_command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @u_log AND `Password` = @u_pass", db.GetConnection());
                    new_command.Parameters.Add("@u_pass", MySqlDbType.VarChar).Value = text;
                    new_command.Parameters.Add("@u_log", MySqlDbType.VarChar).Value = User.Login;
                    adapter.SelectCommand = new_command;
                }

                try
                {
                    adapter.Fill(table);
                }
                catch
                {
                    MessageBox.Show("Данные введены неверно.");
                }

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Информация успешно изменена.");
                    if (which == 1)
                    {
                        User.Login = text;
                    }
                    var form = new StudentInfoForm();
                    form.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Информацию не удалось изменить.");
                }

                db.CloseConnection();
            }
        }
    }
}