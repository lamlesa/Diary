using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace Diary
{
    public partial class StudentInfoForm : Form
    {
        public StudentInfoForm()
        {
            InitializeComponent();
            var db = new DataBase();

            db.OpenConnection();

            var command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @login", db.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = User.Login;
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                id_textbox.Text = reader.GetInt32("ID").ToString();
                name_textbox.Text = reader.GetString("Name");
                surname_textbox.Text = reader.GetString("Surname");
                login_textbox.Text = reader.GetString("Login");
                pass_textbox.Text = reader.GetString("Password");
                group_textbox.Text = reader.GetString("Group");
            }
            else
            {
                MessageBox.Show("Нет данных об этом пользователе.");
            }

            db.CloseConnection();
        }

        private void ChangeIconButtonClick(object sender, EventArgs e)
        {
            open_file_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_file_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picture_box.Image = new Bitmap(open_file_dialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Не удаётся открыть файл.");
                }
            }
        }

        // если в конструктор формы передаём 1 - меняем логин, если 2 - пароль
        private void ChangeLoginButtonClick(object sender, EventArgs e)
        {
            var form = new ChangeInfoForm(1);
            form.Show();
            Hide();
        }

        private void ChangePassButtonClick(object sender, EventArgs e)
        {
            var form = new ChangeInfoForm(2);
            form.Show();
            Hide();
        }
    }
}