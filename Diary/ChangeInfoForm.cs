using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Diary
{
    public partial class ChangeInfoForm : Form
    {
        public byte n;
        public ChangeInfoForm(byte n)
        {
            InitializeComponent();
            this.n = n;
        }

        private void AcceptButtonClick(object sender, EventArgs e)
        {
            var text = new_field.Text;
            var db = new DataBase();
            var table = new DataTable();
            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand();
            if(n == 1)
            {
                command = new MySqlCommand("UPDATE `users` SET `Login` = @u_log WHERE `users`.`Login` = @cur_log", db.GetConnection());
                command.Parameters.Add("@u_log", MySqlDbType.VarChar).Value = text;
                command.Parameters.Add("@cur_log", MySqlDbType.VarChar).Value = Student.Login;
                
            }
            else
            {
                command = new MySqlCommand("UPDATE `users` SET `Password` = @u_pass WHERE `users`.`Login` = @u_log", db.GetConnection());
                command.Parameters.Add("@u_pass", MySqlDbType.VarChar).Value = text;
                command.Parameters.Add("@u_log", MySqlDbType.VarChar).Value = Student.Login;
            }
            
            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                if (n == 1)
                {
                    var new_command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @u_login", db.GetConnection());
                    new_command.Parameters.Add("@u_login", MySqlDbType.VarChar).Value = text;
                    adapter.SelectCommand = new_command;
                    Student.Login = text;

                }
                else
                {
                    var new_command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @u_login AND `Password` = @u_pass", db.GetConnection());
                    new_command.Parameters.Add("@u_pass", MySqlDbType.VarChar).Value = text;
                    new_command.Parameters.Add("@u_login", MySqlDbType.VarChar).Value = Student.Login;
                    adapter.SelectCommand = new_command;
                }
                

                try
                {
                    adapter.Fill(table);
                    MessageBox.Show("Информация успешно изменена.");
                    var form = new StudentInfoForm();
                    form.Show();
                    Hide();
                }
                catch
                {
                    MessageBox.Show("Данные введены неверно.");
                }

                

            }
            else
            {
                MessageBox.Show("не удалось .");
            }

         
            db.CloseConnection();
        }
    }
}
