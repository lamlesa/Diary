using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Diary
{
    public partial class ChangeInfoForm : Form
    {
        byte Which {  get; set; }
        string Login { get; set; }

        public ChangeInfoForm(byte n, string login)
        {
            InitializeComponent();
            Which = n;
            Login = login;
        }

        void AcceptButtonClick(object sender, EventArgs e)
        {
            var text = new_field.Text;
            var db = new DataBase();
            var table = new DataTable();
            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand();
            switch (Which)
            {
                case 1:
                    command = new MySqlCommand("UPDATE `users` SET `Login` = @u_log WHERE `users`.`Login` = @cur_log", db.GetConnection());
                    command.Parameters.Add("@u_log", MySqlDbType.VarChar).Value = text;
                    command.Parameters.Add("@cur_log", MySqlDbType.VarChar).Value = Login;
                    break;
                case 2:
                    command = new MySqlCommand("UPDATE `users` SET `Password` = @u_pass WHERE `users`.`Login` = @u_log", db.GetConnection());
                    command.Parameters.Add("@u_pass", MySqlDbType.VarChar).Value = text;
                    command.Parameters.Add("@u_log", MySqlDbType.VarChar).Value = Login;
                    break;
                case 3:
                    command = new MySqlCommand("UPDATE `users` SET `Name` = @u_name WHERE `users`.`Login` = @u_log", db.GetConnection());
                    command.Parameters.Add("@u_name", MySqlDbType.VarChar).Value = text;
                    command.Parameters.Add("@u_log", MySqlDbType.VarChar).Value = Login;
                    break;
                case 4:
                    command = new MySqlCommand("UPDATE `users` SET `Surname` = @u_sname WHERE `users`.`Login` = @u_log", db.GetConnection());
                    command.Parameters.Add("@u_sname", MySqlDbType.VarChar).Value = text;
                    command.Parameters.Add("@u_log", MySqlDbType.VarChar).Value = Login;
                    break;
                case 5:
                    command = new MySqlCommand("UPDATE `users` SET `Group` = @u_group WHERE `users`.`Login` = @u_log", db.GetConnection());
                    command.Parameters.Add("@u_group", MySqlDbType.VarChar).Value = text;
                    command.Parameters.Add("@u_log", MySqlDbType.VarChar).Value = Login;
                    break;
            }
            
            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                switch (Which)
                {
                    case 1:
                        var log_command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @u_log", db.GetConnection());
                        log_command.Parameters.Add("@u_log", MySqlDbType.VarChar).Value = text;
                        adapter.SelectCommand = log_command;
                        if (User.Role != "Admin")
                        {
                            User.Login = text;
                        }
                        break;
                    case 2:
                        var pass_command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @u_log AND `Password` = @u_pass", db.GetConnection());
                        pass_command.Parameters.Add("@u_pass", MySqlDbType.VarChar).Value = text;
                        pass_command.Parameters.Add("@u_log", MySqlDbType.VarChar).Value = Login;
                        adapter.SelectCommand = pass_command;
                        break;
                    case 3:
                        var name_command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @u_log AND `Name` = @u_name", db.GetConnection());
                        name_command.Parameters.Add("@u_name", MySqlDbType.VarChar).Value = text;
                        name_command.Parameters.Add("@u_log", MySqlDbType.VarChar).Value = Login;
                        adapter.SelectCommand = name_command;
                        break;
                    case 4:
                        var sname_command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @u_log AND `Surname` = @u_sname", db.GetConnection());
                        sname_command.Parameters.Add("@u_sname", MySqlDbType.VarChar).Value = text;
                        sname_command.Parameters.Add("@u_log", MySqlDbType.VarChar).Value = Login;
                        adapter.SelectCommand = sname_command;
                        break;
                    case 5:
                        var gr_command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @u_log AND `Group` = @u_group", db.GetConnection());
                        gr_command.Parameters.Add("@u_group", MySqlDbType.VarChar).Value = text;
                        gr_command.Parameters.Add("@u_log", MySqlDbType.VarChar).Value = Login;
                        adapter.SelectCommand = gr_command;
                        break;
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