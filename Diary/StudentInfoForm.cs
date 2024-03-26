using System;
using System.Windows.Forms;

namespace Diary
{
    public partial class StudentInfo : Form
    {
        public StudentInfo()
        {
            InitializeComponent();
        }

        private void RedactButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Нет возможности редактирования.");
        }

        private void ViewInfoButtonClick(object sender, EventArgs e)
        {
            DataGrid.DataSource = Student.Table;
        }
    }
}
