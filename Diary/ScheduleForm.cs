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
            // Создаем таблицу
            
       

            // Добавляем столбцы
            schedule.Columns.Add("Day", "День недели");
            schedule.Columns.Add("Time", "Время пар");
            schedule.Columns.Add("Teacher", "Преподаватель");
            schedule.Columns.Add("Subject", "Предмет");
            schedule.Columns.Add("Classroom", "Аудитория");

            // Добавляем данные в таблицу
            List<string[]> scheduleData = new List<string[]>
            {
                new string[] { "Понедельник", "8.30 - 10.00", "Фадеева Е.В.", "Программирование", "101" },
                new string[] { "Понедельник", "10.10 - 11.40", "Сидоров А.М.", "Мат. Анализ", "203" },
                new string[] { "Понедельник", "12.10 - 13.40", "Данилов В.А.", "Физкультура", "Зал СК" },
                new string[] { "Понедельник", "13.50 - 15.20", "Фадеева Е.В.", "Программирование", "101" },
                new string[] { "Вторник", "8.30 - 10.00", "Фадеева Е.В.", "Программирование", "101" },
                new string[] { "Вторник", "10.10 - 11.40", "Сидоров А.М.", "Мат. Анализ", "203" },
                new string[] { "Вторник", "12.10 - 13.40", "Данилов В.А.", "Физкультура", "Зал СК" },
                new string[] { "Вторни", "13.50 - 15.20", "Фадеева Е.В.", "Программирование", "101" },
                new string[] { "Среда", "8.30 - 10.00", "Фадеева Е.В.", "Программирование", "101" },
                new string[] { "Среда", "10.10 - 11.40", "Сидоров А.М.", "Мат. Анализ", "203" },
                new string[] { "Четверг", "12.10 - 13.40", "Данилов В.А.", "Физкультура", "Зал СК" },
                new string[] { "Четверг", "13.50 - 15.20", "Фадеева Е.В.", "Программирование", "101" },
                new string[] { "Пятница", "10.10 - 11.40", "Сидоров А.М.", "Мат. Анализ", "203" },
                new string[] { "Пятница", "12.10 - 13.40", "Данилов В.А.", "Физкультура", "Зал СК" },
                new string[] { "Пятница", "13.50 - 15.20", "Фадеева Е.В.", "Программирование", "101" }

            };

            foreach (string[] row in scheduleData)
            {
                schedule.Rows.Add(row);
            }

        }

        void AddButton_Click(object sender, EventArgs e)
        {
            // Добавление новой строки в DataGridView
            schedule.Rows.Add(weekday.Text, timer.Value.ToLongTimeString(), professor.Text, name.Text, aud.Text);

            var db = new DataBase();
            var table = new DataTable();
            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("INSERT INTO `subjects` (`Name`, `Professor`, `WeekDay`, `Time`, `Status`, `Aud`) VALUES (@u_name, @u_prof, @u_wday, @u_time, @u_status, @u_aud)", db.GetConnection());
            command.Parameters.Add("@u_name", MySqlDbType.VarChar).Value = name.Text;
            command.Parameters.Add("@u_prof", MySqlDbType.VarChar).Value = professor.Text;
            command.Parameters.Add("@u_wday", MySqlDbType.VarChar).Value = weekday.Text;
            command.Parameters.Add("@u_time", MySqlDbType.VarChar).Value = null;
            //command.Parameters.Add("@u_time", MySqlDbType.Time).Value = timer.Value.ToLongTimeString();
            command.Parameters.Add("@u_status", MySqlDbType.VarChar).Value = "None";
            command.Parameters.Add("@u_aud", MySqlDbType.VarChar).Value = aud.Text;

            db.OpenConnection();
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    var new_command = new MySqlCommand("SELECT * FROM `subjects` WHERE `Name` = @u_name AND `Status` = @u_status AND `Aud` = @u_aud", db.GetConnection());
                    new_command.Parameters.Add("@u_name", MySqlDbType.VarChar).Value = name.Text;
                    new_command.Parameters.Add("@u_status", MySqlDbType.VarChar).Value = "None";
                    new_command.Parameters.Add("@u_aud", MySqlDbType.VarChar).Value = aud.Text;
                  
                    adapter.SelectCommand = new_command;

                    try
                    {
                        adapter.Fill(table);
                    }
                    catch
                    {
                        MessageBox.Show("Данные введены неверно.");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Не удалось добавить занятие.");
                }
            }
            catch
            {
                MessageBox.Show("Не удалось добавить занятие.");
            }

            db.CloseConnection();

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
                schedule.Rows.Remove(schedule.SelectedRows[0]);
                if (schedule.SelectedRows.Count > 0)
                {
                    var id = int.Parse(schedule.CurrentRow.Cells[0].Value.ToString());
                    schedule.Rows.Remove(schedule.SelectedRows[0]);
                    var db = new DataBase();
                    var table = new DataTable();
                    var adapter = new MySqlDataAdapter();
                    var command = new MySqlCommand("DELETE FROM users WHERE `subjects`.`ID` = @u_ID", db.GetConnection());
                    command.Parameters.Add("@u_ID", MySqlDbType.Int32).Value = id;

                    db.OpenConnection();

                    try
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            var new_command = new MySqlCommand("SELECT * FROM `users` WHERE `ID` = @u_ID", db.GetConnection());
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
                        MessageBox.Show("Не удалось удалить занятие из расписания.");
                    }

                    db.CloseConnection();
                }
                else
                {
                    MessageBox.Show("Выберите занятие для удаления.");
                }
            }
        }

    }
}