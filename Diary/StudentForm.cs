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
        }

        private void InfoButtonClick(object sender, EventArgs e)
        {
            var form = new StudentInfo();
            form.Show();
        }

        private void SubjectsInfo(object sender, EventArgs e)
        { 
            var db = new DataBase();
            var table = new DataTable();
            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT * FROM `subjects` WHERE `Name` = @sub_name", db.GetConnection());
            
            command.Parameters.Add("@sub_name", MySqlDbType.VarChar).Value = (string)subjects_box.SelectedItem;
            adapter.SelectCommand = command;
            try
            {
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SubjectDataGrid.DataSource = table;
            
        }
        private void ShowSchedule(object sender, EventArgs e)
        {
            var db = new DataBase();
            var table = new DataTable();
            var adapter = new MySqlDataAdapter();
           
            var command = new MySqlCommand("SELECT * FROM `subjects` WHERE `WeekDay` = @weekday", db.GetConnection());

            command.Parameters.Add("@weekday", MySqlDbType.VarChar).Value = (string)weekday_box.SelectedItem;
            adapter.SelectCommand = command;
            try
            {
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ScheduleGrid.DataSource = table;
        }
    }
}