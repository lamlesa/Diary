using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Diary
{
    public partial class GroupCreator : Form
    {
        public GroupCreator()
        {
            InitializeComponent();
            var db = new DataBase();
            var table = new DataTable();
            var adapter = new MySqlDataAdapter();
            var command = new MySqlCommand("SELECT `ID`,`Name`,`Surname`,`Login` FROM `users` WHERE `Role` = @role", db.GetConnection());
            command.Parameters.Add("@role", MySqlDbType.VarChar).Value = "Student";
            adapter.SelectCommand = command;

            try
            {
                adapter.Fill(table);
            }
            catch
            {
                MessageBox.Show("Данных не обнаружено.");
            }
            allstudents.DataSource = table;
        }
    }
}