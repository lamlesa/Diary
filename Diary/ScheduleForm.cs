using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Diary
{
    public partial class ScheduleForm : Form
    {
        public ScheduleForm()
        {
            InitializeComponent();
        }

        void DataGridView1_CellEndEdit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Создаем таблицу
            var scheduleGridView = new DataGridView();
            scheduleGridView.Dock = DockStyle.Fill;

            // Добавляем столбцы
            scheduleGridView.Columns.Add("Day", "День недели");
            scheduleGridView.Columns.Add("Time", "Время пар");
            scheduleGridView.Columns.Add("Teacher", "Преподаватель");
            scheduleGridView.Columns.Add("Subject", "Предмет");
            scheduleGridView.Columns.Add("Classroom", "Аудитория");

            // Добавляем данные в таблицу
            List<string[]> scheduleData = new List<string[]>
        {
            new string[] { "Понедельник", "8.30 - 10.00", "Фадеева Е.В.", "Программирование", "101" },
            new string[] { "Понедельник", "10.10 - 11.40", "Сидоров А.М.", "Мат. Анализ", "203" },
            new string[] { "Понедельник", "12.10 - 13.40", "Данилов В.А.", "Физкультура", "Зал СК" },
            new string[] { "Понедельник", "13.50 - 15.20", "Фадеева Е.В.", "Программирование", "101" },
            new string[] { "Вторник", "8.30 - 10.00", "Фадеева Е.В.", "Программирование", "101" },
            new string[] { "Вторник", "10.10 - 11.40", "Сидоров А.М.", "Мат. Анализ", "203" },
            new string[] { "Вторник", "12.10 - 13.40", "Данилов В.А.", "Физкультура", "Зал СК" },
            new string[] { "Вторни", "13.50 - 15.20", "Фадеева Е.В.", "Программирование", "101" },
            new string[] { "Среда", "8.30 - 10.00", "Фадеева Е.В.", "Программирование", "101" },
            new string[] { "Среда", "10.10 - 11.40", "Сидоров А.М.", "Мат. Анализ", "203" },
            new string[] { "Четверг", "12.10 - 13.40", "Данилов В.А.", "Физкультура", "Зал СК" },
            new string[] { "Четверг", "13.50 - 15.20", "Фадеева Е.В.", "Программирование", "101" },
            new string[] { "Пятница", "10.10 - 11.40", "Сидоров А.М.", "Мат. Анализ", "203" },
            new string[] { "Пятница", "12.10 - 13.40", "Данилов В.А.", "Физкультура", "Зал СК" },
            new string[] { "Пятница", "13.50 - 15.20", "Фадеева Е.В.", "Программирование", "101" }

        };

            foreach (string[] row in scheduleData)
            {
                scheduleGridView.Rows.Add(row);
            }

            // Добавляем таблицу на форму
            Controls.Add(scheduleGridView);

        }
        void AddButton_Click(object sender, EventArgs e)
        {
            // Добавление новой строки в DataGridView
            dataGridView1_CellEndEdit.Rows.Add("Новые данные 1", "Новые данные 2", "Новые данные 3");
        }

        void SaveButton_Click(object sender, EventArgs e)
        {
            // Сохранение данных из DataGridView в файл
            StringBuilder sb = new StringBuilder();

            foreach (DataGridViewRow row in dataGridView1_CellEndEdit.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    sb.Append(cell.Value + ",");
                }
                sb.AppendLine();
            }


        }

        void DeleteButton_Click(object sender, EventArgs e)
        {
            // Удаление выбранной строки из DataGridView
            if (dataGridView1_CellEndEdit.SelectedRows.Count > 0)
            {
                dataGridView1_CellEndEdit.Rows.Remove(dataGridView1_CellEndEdit.SelectedRows[0]);
            }
        }
    }
}