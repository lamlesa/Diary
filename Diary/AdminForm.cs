using MySql.Data.MySqlClient;
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

        private void textBoxGroupName_TextChanged(object sender, System.EventArgs e)
        {
            string groupName = group_textbox.Text;
        }

        private void AddStudentButtonClick(object sender, System.EventArgs e)
        {
            // Добавление нового студента в DataGridView
            datagrid_students.Rows.Add("Имя", "Фамилия", "Номер билета");

            // Дополнительная логика для сохранения информации о новом студенте
            // Например, можно добавить код для сохранения данных о студенте в базу данных
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagrid_students.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = datagrid_students.SelectedRows[0];
                string selectedStudentName = selectedRow.Cells["Имя"].Value.ToString();
                string selectedStudentSurname = selectedRow.Cells["Фамилия"].Value.ToString();
            }
        }

        private void CreateGroupButtonClick(object sender, System.EventArgs e)
        {
            // Получение названия группы из TextBox
            string groupName = group_textbox.Text;

            // Проверка наличия введенного названия группы
            if (!string.IsNullOrEmpty(groupName))
            {
                // Добавление кода для создания новой группы
                // Например, можно сохранить данные о новой группе в базу данных 
                MessageBox.Show("Группа '" + groupName + "' успешно создана!");
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите название группы.");
            }
        }

        private void DeleteStudentButtonClick(object sender, System.EventArgs e)
        {
            if (datagrid_students.SelectedRows.Count > 0)
            {
                datagrid_students.Rows.Remove(datagrid_students.SelectedRows[0]);
                // Дополнительная логика для удаления информации о студенте
                // Например, можно добавить код для удаления данных о студенте из базы данных
            }
            else
            {
                MessageBox.Show("Выберите студента для удаления.");
            }
        }
    }
}