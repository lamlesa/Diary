using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Diary
{
    public partial class GroupCreator : Form
    {
        public GroupCreator()
        {
            InitializeComponent();
            var db = new DataBase();
            var table = new DataTable();
            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT `ID`,`Name`,`Surname`,`Group` FROM `users` WHERE `Role` = @role", db.GetConnection());
            command.Parameters.Add("@role", MySqlDbType.VarChar).Value = "Student";
            adapter.SelectCommand = command;

            try
            {
                adapter.Fill(table);
            }
            catch
            {
                MessageBox.Show("Данных не обнаружено.");
            }
            allstudents.DataSource = table;
        }

        void Update(object sender, EventArgs e)
        {
            var db = new DataBase();
            var table = new DataTable();
            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT `ID`,`Name`,`Surname`,`Group` FROM `users` WHERE `Role` = @role", db.GetConnection());
            command.Parameters.Add("@role", MySqlDbType.VarChar).Value = "Student";
            adapter.SelectCommand = command;

            try
            {
                adapter.Fill(table);
            }
            catch
            {
                MessageBox.Show("Данных не обнаружено.");
            }
            allstudents.DataSource = table;
        }

        private void CreateGroup(object sender, EventArgs e)
        {
            if (allstudents.SelectedRows != null)
            {
                var n = 0;
                var text = number.Text;
                var db = new DataBase();
                var table = new DataTable();
                var adapter = new MySqlDataAdapter();
                var command = new MySqlCommand();
                foreach (DataGridViewRow row in allstudents.SelectedRows)
                {
                    command = new MySqlCommand("UPDATE `users` SET `Group` = @u_group WHERE `users`.`Role` = @u_role AND `users`.`ID` = @u_ID", db.GetConnection());
                    command.Parameters.Add("@u_group", MySqlDbType.VarChar).Value = text;
                    command.Parameters.Add("@u_role", MySqlDbType.VarChar).Value = "Student";
                    command.Parameters.Add("@u_ID", MySqlDbType.Int32).Value = int.Parse(row.Cells[0].Value.ToString());
                    db.OpenConnection();
                    try
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            var new_command = new MySqlCommand("SELECT * FROM `users` WHERE `Group` = @u_group AND `Role` = @u_role", db.GetConnection());
                            new_command.Parameters.Add("@u_group", MySqlDbType.VarChar).Value = text;
                            new_command.Parameters.Add("@u_role", MySqlDbType.VarChar).Value = "Student";
                            adapter.SelectCommand = new_command;

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
                                n++;
                            }

                            db.CloseConnection();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Не удалось соединиться с базой данных.");
                    }
                }
                if (n != 0)
                {
                    MessageBox.Show("Группа успешно создана.");
                }
            }
            else
            {
                MessageBox.Show("Сначала выберите студентов, из которых хотите сформировать группу.");
            }
        }
    }
}