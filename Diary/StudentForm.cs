using System;
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
    }
}