using System;
using System.Windows.Forms;

namespace Diary
{
    public partial class CheckAdminForm : Form
    {
        public CheckAdminForm()
        {
            InitializeComponent();
        }

        void CheckButtonClick(object sender, EventArgs e)
        {
            // админом может зарегистрироваться только человек, знающий пароль
            if (password.Text == "KLEVO971")
            {
                MessageBox.Show("Вы успешно зарегистрированы.");
                User.Role = "Admin";
                var form = new AdminForm();
                form.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Неверный пароль администратора.");
            }
        }
    }
}