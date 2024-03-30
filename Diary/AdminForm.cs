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
                //name_textbox.Text = reader.GetString("Name");
                //surname_textbox.Text = reader.GetString("Surname");
            }
            else
            {
                MessageBox.Show("Нет данных об этом пользователе.");
            }

            db.CloseConnection();
        }



        private void textBoxGroupName_TextChanged(object sender, System.EventArgs e)
        {
            string groupName = textBoxGroupName.Text;
        }

        private void button_AddStudent_Click(object sender, System.EventArgs e)
        {
            // Добавление нового студента в DataGridView
            dataGridViewStudents.Rows.Add("Имя", "Фамилия", "Номер билета");

            // Дополнительная логика для сохранения информации о новом студенте
            // Например, можно добавить код для сохранения данных о студенте в базу данных

        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewStudents.SelectedRows[0];
                string selectedStudentName = selectedRow.Cells["Имя"].Value.ToString();
                string selectedStudentSurname = selectedRow.Cells["Фамилия"].Value.ToString();
            }
        }

        private void buttonCreateGroup_Click_Click(object sender, System.EventArgs e)
        {
            // Получение названия группы из TextBox
            string groupName = textBoxGroupName.Text;

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

        private void buttonEdit_Click_Click(object sender, System.EventArgs e)
        {

        }

        private void buttonDeleteStudent_Click_Click(object sender, System.EventArgs e)
        {
            // Удаление выбранного студента из DataGridView
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                dataGridViewStudents.Rows.Remove(dataGridViewStudents.SelectedRows[0]);
                // Дополнительная логика для удаления информации о студенте
                // Например, можно добавить код для удаления данных о студенте из базы данных
            }
            else
            {
                MessageBox.Show("Выберите студента для удаления.");
            }
        }

        private void AdminForm_Load(object sender, System.EventArgs e)
        {

        }

        private void raspisanie_button_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            RaspisanieForm raspisanieForm = new RaspisanieForm();
            raspisanieForm.Show();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            BallsForm ballsForm = new BallsForm();
            ballsForm.Show();
        }

    }
}