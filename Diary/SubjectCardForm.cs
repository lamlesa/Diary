using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Diary
{
    public partial class SubjectCardForm : Form
    {
        public SubjectCardForm(string subject)
        {
            InitializeComponent();
            var db = new DataBase();

            db.OpenConnection();

            var command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @login", db.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = User.Login;
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                switch (subject)
                {
                    case "Матанализ":
                        note_textbox.Text = reader.GetString("Math_Info");
                        break;
                    case "Английский":
                        note_textbox.Text = reader.GetString("Eng_Info");
                        break;
                    case "Алгебра и геометрия":
                        note_textbox.Text = reader.GetString("Alg_Info");
                        break;
                    case "История":
                        note_textbox.Text = reader.GetString("His_Info");
                        break;
                    case "Русский":
                        note_textbox.Text = reader.GetString("Rus_Info");
                        break;
                    case "Программирование":
                        note_textbox.Text = reader.GetString("Prog_Info");
                        break;
                    case "Физическая культура":
                        note_textbox.Text = reader.GetString("Phys_Info");
                        break;
                    case "Правоведение":
                        note_textbox.Text = reader.GetString("Law_Info");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Нет заметок.");
            }

            db.CloseConnection();
        }
    }
}