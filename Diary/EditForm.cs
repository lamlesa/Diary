using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Data;

namespace Diary
{
    public partial class EditForm : Form
    {
        int ID {  get; set; }
        DataGridViewRow Row { get; set; }
        public EditForm(DataGridViewRow row)
        {
            InitializeComponent();
            var db = new DataBase();
            ID = int.Parse(row.Cells[0].Value.ToString());
            Row = row;

            db.OpenConnection();

            var command = new MySqlCommand("SELECT * FROM `users` WHERE `ID` = @u_id", db.GetConnection());
            command.Parameters.Add("@u_id", MySqlDbType.VarChar).Value = ID;
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                id_textbox.Text = reader.GetInt32("ID").ToString();
                name_textbox.Text = reader.GetString("Name");
                surname_textbox.Text = reader.GetString("Surname");
                login_textbox.Text = reader.GetString("Login");
                pass_textbox.Text = reader.GetString("Password");
                group_textbox.Text = reader.GetString("Group");
                picture_box.ImageLocation = reader.GetString("UPic");
            }
            else
            {
                MessageBox.Show("Нет данных об этом пользователе.");
            }

            db.CloseConnection();
        }

        void ChangeIconButtonClick(object sender, EventArgs e)
        {
            open_file_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_file_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picture_box.Image = new Bitmap(open_file_dialog.FileName);
                    var db = new DataBase();
                    var table = new DataTable();
                    var adapter = new MySqlDataAdapter();
                    var command = new MySqlCommand("UPDATE `users` SET `UPic` = @u_pic WHERE `users`.`ID` = @u_id", db.GetConnection());
                    command.Parameters.Add("@u_pic", MySqlDbType.VarChar).Value = Path.GetFullPath(open_file_dialog.FileName);
                    command.Parameters.Add("@u_id", MySqlDbType.VarChar).Value = ID;
                    db.OpenConnection();
                    try
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            var new_command = new MySqlCommand("SELECT * FROM `users` WHERE `ID` = @u_id AND `Upic` = @u_pic", db.GetConnection());
                            new_command.Parameters.Add("@u_id", MySqlDbType.VarChar).Value = ID;
                            new_command.Parameters.Add("@u_pic", MySqlDbType.VarChar).Value = Path.GetFullPath(open_file_dialog.FileName);
                            adapter.SelectCommand = new_command;

                            try
                            {
                                adapter.Fill(table);
                                User.Table = table;
                            }
                            catch
                            {
                                MessageBox.Show("Данные введены неверно.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Не удалось изменить картинку профиля.");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Не удалось изменить картинку профиля.");
                    }

                    db.CloseConnection();
                }
                catch
                {
                    MessageBox.Show("Не удаётся открыть файл.");
                }
            }
        }

        // если в конструктор формы передаём 1 - меняем логин, если 2 - пароль, 3 - имя, 4 - фамилию, 5 - группу
        void ChangeLoginButtonClick(object sender, EventArgs e)
        {
            var form = new ChangeInfoForm(1, Row.Cells[3].Value.ToString());
            form.Show();
            Hide();
        }

        void ChangePassButtonClick(object sender, EventArgs e)
        {
            var form = new ChangeInfoForm(2, Row.Cells[3].Value.ToString());
            form.Show();
            Hide();
        }

        void ChangeNameButtonClick(object sender, EventArgs e)
        {
            var form = new ChangeInfoForm(3, Row.Cells[3].Value.ToString());
            form.Show();
            Hide();
        }

        void ChangeSurnameButtonClick(object sender, EventArgs e)
        {
            var form = new ChangeInfoForm(4, Row.Cells[3].Value.ToString());
            form.Show();
            Hide();
        }

        void ChangeGroupButtonClick(object sender, EventArgs e)
        {
            var form = new ChangeInfoForm(5, Row.Cells[3].Value.ToString());
            form.Show();
            Hide();
        }
    }
}