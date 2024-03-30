using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Diary
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            var db = new DataBase();

            db.OpenConnection();

            var command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @login", db.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = User.Login;
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

        void ShowStudents(object sender, System.EventArgs e)
        {
            var db = new DataBase();
            var table = new DataTable();
            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT `ID`,`Name`,`Surname`,`Login` FROM `users` WHERE `Group` = @group", db.GetConnection());
            command.Parameters.Add("@group", MySqlDbType.VarChar).Value = (string)group_box.SelectedItem;
            adapter.SelectCommand = command;

            try
            {
                adapter.Fill(table);
            }
            catch
            {
                MessageBox.Show("Необходимо выбрать группу из списка.");
            }
            datagrid_students.DataSource = table;
        }

        void CreateGroup(object sender, System.EventArgs e)
        {
            var form = new GroupCreator();
            form.Show();
        }

        void Edit(object sender, System.EventArgs e)
        {
            if (datagrid_students.CurrentRow == null)
            {
                MessageBox.Show("Сначала выберите студента.");
            }
            else
            {
                var form = new EditForm(datagrid_students.CurrentRow);
                form.Show();
            }   
        }

        void AddStudentClick(object sender, System.EventArgs e)
        {
            var form = new AddStudentForm();
            form.Show();
        }

        void DeleteStudent(object sender, System.EventArgs e)
        {
            // Удаление выбранного студента из DataGridView

            if (datagrid_students.SelectedRows.Count > 0)
            {
                var id = int.Parse(datagrid_students.CurrentRow.Cells[0].Value.ToString());
                datagrid_students.Rows.Remove(datagrid_students.SelectedRows[0]);
                var db = new DataBase();
                var table = new DataTable();
                var adapter = new MySqlDataAdapter();
                var command = new MySqlCommand("DELETE FROM users WHERE `users`.`ID` = @u_ID", db.GetConnection());
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
                            MessageBox.Show("Студент успешно удалён.");
                        }
                        catch
                        {
                            MessageBox.Show("Такого студента не существует.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Не удалось удалить студента.");
                    }
                }
                catch
                {
                    MessageBox.Show("Не удалось удалить студента.");
                }

                db.CloseConnection();
            }
            else
            {
                MessageBox.Show("Выберите студента для удаления.");
            }
        }

        void ShowScheduleForm(object sender, System.EventArgs e)
        {
            ScheduleForm raspisanieForm = new ScheduleForm();
            raspisanieForm.Show();
        }

        void ShowMarksForm(object sender, System.EventArgs e)
        {
            Marks ballsForm = new Marks();
            ballsForm.Show();
        }
    }
}