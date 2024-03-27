using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Diary
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            var db = new DataBase();

            db.OpenConnection();

            var command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @login", db.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = Student.Login;
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                name_textbox.Text = reader.GetString("Name");
                surname_textbox.Text = reader.GetString("Surname");
            }
            else
            {
                MessageBox.Show("Нет данных об этом пользователе.");
            }

            db.CloseConnection();
        }

        private void InfoButtonClick(object sender, EventArgs e)
        {
            var form = new StudentInfoForm();
            form.Show();
        }

        private void SubjectsInfo(object sender, EventArgs e)
        {
            var db = new DataBase();
            var table = new DataTable();
            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT `Name`,`Professor` FROM `subjects` WHERE `Name` = @sub_name AND `Status` = @status", db.GetConnection());
            command.Parameters.Add("@sub_name", MySqlDbType.VarChar).Value = (string)subject_combobox.SelectedItem;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = "Main";
            adapter.SelectCommand = command;

            try
            {
                adapter.Fill(table);
            }
            catch
            {
                MessageBox.Show("Необходимо выбрать дисциплину из списка.");
            }
            subject_data_grid.DataSource = table;
        }

        private void ShowSchedule(object sender, EventArgs e)
        {
            var db = new DataBase();
            var table = new DataTable();
            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT `Name`,`Professor`,`Time` FROM `subjects` WHERE `WeekDay` = @weekday", db.GetConnection());
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
            schedule_grid.DataSource = table;
        }

        private void WriteNoteButtonClick(object sender, EventArgs e)
        {
            var db = new DataBase();
            var table = new DataTable();
            var adapter = new MySqlDataAdapter();

            switch ((string)subjects_box.SelectedItem)
            {
                case "Матанализ":
                    var m_command = new MySqlCommand("UPDATE `users` SET `Math_Info` = @note_text WHERE `users`.`Login` = @cur_log", db.GetConnection());
                    m_command.Parameters.Add("@note_text", MySqlDbType.Text).Value = note_textbox.Text;
                    m_command.Parameters.Add("@cur_log", MySqlDbType.VarChar).Value = Student.Login;
                    adapter.SelectCommand = m_command;
                    break;
                case "Программирование":
                    var p_command = new MySqlCommand("UPDATE `users` SET `Prog_Info` = @note_text WHERE `users`.`Login` = @cur_log", db.GetConnection());
                    p_command.Parameters.Add("@note_text", MySqlDbType.Text).Value = note_textbox.Text;
                    p_command.Parameters.Add("@cur_log", MySqlDbType.VarChar).Value = Student.Login;
                    adapter.SelectCommand = p_command;
                    break;
                case "Физическая культура":
                    var f_command = new MySqlCommand("UPDATE `users` SET `Phys_Info` = @note_text WHERE `users`.`Login` = @cur_log", db.GetConnection());
                    f_command.Parameters.Add("@note_text", MySqlDbType.Text).Value = note_textbox.Text;
                    f_command.Parameters.Add("@cur_log", MySqlDbType.VarChar).Value = Student.Login;
                    adapter.SelectCommand = f_command;
                    break;
            }

            db.OpenConnection();

            if (adapter.SelectCommand.ExecuteNonQuery() == 1)
            {
                switch (subjects_box.SelectedItem)
                {
                    case "Матанализ":
                        var nm_command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @u_log AND `Math_Info` = @note_text", db.GetConnection());
                        nm_command.Parameters.Add("@note_text", MySqlDbType.Text).Value = note_textbox.Text;
                        nm_command.Parameters.Add("@u_log", MySqlDbType.VarChar).Value = Student.Login;
                        adapter.SelectCommand = nm_command;
                        break;
                    case "Программирование":
                        var np_command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @u_log AND `Prog_Info` = @note_text", db.GetConnection());
                        np_command.Parameters.Add("@note_text", MySqlDbType.Text).Value = note_textbox.Text;
                        np_command.Parameters.Add("@u_log", MySqlDbType.VarChar).Value = Student.Login;
                        adapter.SelectCommand = np_command;
                        break;
                    case "Физическая культура":
                        var nf_command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @u_log AND `Phys_Info` = @note_text", db.GetConnection());
                        nf_command.Parameters.Add("@note_text", MySqlDbType.Text).Value = note_textbox.Text;
                        nf_command.Parameters.Add("@u_log", MySqlDbType.VarChar).Value = Student.Login;
                        adapter.SelectCommand = nf_command;
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
                    MessageBox.Show("Заметка добавлена.");
                    note_textbox.Clear();
                }
                else
                {
                    MessageBox.Show("Не удалось добавить заметку.");
                }

                db.CloseConnection();
            }
            else
            {
                MessageBox.Show("Данные введены неверно.");
            }
        }
    }
}