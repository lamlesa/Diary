using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Diary
{
    public partial class ScheduleForm : Form
    {
        public ScheduleForm()
        {
            InitializeComponent();
        }

        void Add(object sender, EventArgs e)
        {
            
            var Name = name.Text;
            var Prof = professor.Text;
            var Day = weekday.Text;
            var Aud = aud.Text;
            var db = new DataBase();
            var table = new DataTable();
            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("INSERT INTO `subjects` (`Name`, `Professor`, `WeekDay`, `Time`, `Status`, `Aud`) VALUES (@u_name, @u_prof, @u_wday, NULL, @u_status, @u_aud);", db.GetConnection());
            command.Parameters.Add("@u_name", MySqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@u_prof", MySqlDbType.VarChar).Value = Prof;
            command.Parameters.Add("@u_wday", MySqlDbType.VarChar).Value = Day;
            //command.Parameters.Add("@u_time", MySqlDbType.VarChar).Value = null;
            //command.Parameters.Add("@u_time", MySqlDbType.Time).Value = timer.Value.ToLongTimeString();
            command.Parameters.Add("@u_status", MySqlDbType.VarChar).Value = "None";
            command.Parameters.Add("@u_aud", MySqlDbType.VarChar).Value = Aud;

            db.OpenConnection();
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    var new_command = new MySqlCommand("SELECT * FROM `subjects` WHERE `Name` = @u_name", db.GetConnection());
                    new_command.Parameters.Add("@u_name", MySqlDbType.VarChar).Value = Name;
                    //new_command.Parameters.Add("@u_status", MySqlDbType.VarChar).Value = "None";
                    //new_command.Parameters.Add("@u_aud", MySqlDbType.VarChar).Value = aud.Text;
                  
                    adapter.SelectCommand = new_command;

                    try
                    {
                        adapter.Fill(table);
                    }
                    catch
                    {
                        //MessageBox.Show("Данные введены неверно.");
                    }
                    
                }
                else
                {
                    //MessageBox.Show("Не удалось добавить занятие.");
                }
            }
            catch
            {
                //MessageBox.Show("Не удалось добавить занятие.");
            }

            db.CloseConnection();
            // Добавление новой строки в DataGridView
            schedule.Rows.Add(weekday.Text, timer.Value.ToLongTimeString(), professor.Text, name.Text, aud.Text);

        }

        void Save(object sender, EventArgs e)
        {
            // Сохранение данных из DataGridView в файл
            StringBuilder sb = new StringBuilder();

            foreach (DataGridViewRow row in schedule.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    sb.Append(cell.Value + ",");
                }
                sb.AppendLine();
            }
        }

        void DeleteButton_Click(object sender, EventArgs e)
        {

            // Удаление выбранной строки из DataGridView
            if (schedule.SelectedRows.Count > 0)
            {
                schedule.Rows.Remove(schedule.CurrentRow);
                if (schedule.SelectedRows.Count > 0)
                {
                    var id = int.Parse(schedule.CurrentRow.Cells[0].Value.ToString());
                    schedule.Rows.Remove(schedule.SelectedRows[0]);
                    var db = new DataBase();
                    var table = new DataTable();
                    var adapter = new MySqlDataAdapter();
                    var command = new MySqlCommand("DELETE FROM `subjects` WHERE `subjects`.`ID` = @u_ID", db.GetConnection());
                    command.Parameters.Add("@u_ID", MySqlDbType.Int32).Value = id;

                    db.OpenConnection();

                    try
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            var new_command = new MySqlCommand("SELECT * FROM `subjects` WHERE `ID` = @u_ID", db.GetConnection());
                            new_command.Parameters.Add("@u_ID", MySqlDbType.Int32).Value = id;
                            adapter.SelectCommand = new_command;

                            try
                            {
                                adapter.Fill(table);
                                
                                MessageBox.Show("Занятие успешно удалено.");
                            }
                            catch
                            {
                                MessageBox.Show("Данные отсутствуют.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Не удалось удалить занятие.");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Не удалось удалить занятие.");
                    }

                    db.CloseConnection();
                   
                }
                else
                {
                    MessageBox.Show("Выберите занятие для удаления.");
                }
            }
        }

        private void ShowButtonClick(object sender, EventArgs e)
        {
            var db = new DataBase();
            var table = new DataTable();
            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT `ID`,`Name`,`Professor`,`Time` FROM `subjects` WHERE `WeekDay` = @weekday", db.GetConnection());
            command.Parameters.Add("@weekday", MySqlDbType.VarChar).Value = (string)weekday_box.SelectedItem;
            adapter.SelectCommand = command;

            try
            {
                adapter.Fill(table);
            }
            catch
            {
                MessageBox.Show("Необходимо выбрать день из списка.");
            }
            schedule.DataSource = table;
        }
    }
}