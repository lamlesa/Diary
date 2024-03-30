using System;
using System.IO;
using System.Windows.Forms;

namespace Diary
{
    public partial class Marks : Form
    {
        // Создаем переменные для хранения оценок
        readonly int[] programmingScores = new int[3];
        readonly int[] mathScores = new int[3];
        readonly int[] physicalEducationScores = new int[3];
        public Marks()
        {
            InitializeComponent();
        }

        void ButtonSave_Click(object sender, EventArgs e)
        {
            string fileName = "grades.txt";

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var grade in programmingScores)
                {
                    writer.WriteLine(grade);
                }
            }
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var grade in mathScores)
                {
                    writer.WriteLine(grade);
                }
            }
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var grade in physicalEducationScores)
                {
                    writer.WriteLine(grade);
                }
            }
            MessageBox.Show("Оценки успешно сохранены в файле " + fileName);
        }

        void Dgw_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Создание столбцов для DataGridView
            dgw_student.Columns.Add("Предмет", "Предмет");
            dgw_student.Columns.Add("Балл", "Балл");

            // Добавление строк с предметами
            dgw_student.Rows.Add("Мат.анализ");
            dgw_student.Rows.Add("Программирование");
            dgw_student.Rows.Add("Физкультура");
        }

        void BtnAdd_Click(object sender, EventArgs e)
        {
            // Получаем оценки из TextBox'ов
            programmingScores[0] = Convert.ToInt32(txtProgrammingHomework.Text);
            programmingScores[1] = Convert.ToInt32(txtProgrammingControl.Text);
            programmingScores[2] = Convert.ToInt32(txtProgrammingQuiz.Text);
            programmingScores[3] = Convert.ToInt32(txtProgrammingExam.Text);

            mathScores[0] = Convert.ToInt32(txtMathHomework.Text);
            mathScores[1] = Convert.ToInt32(txtMathControl.Text);
            mathScores[2] = Convert.ToInt32(txtMathQuiz.Text);
            mathScores[3] = Convert.ToInt32(txtMathExam.Text);

            physicalEducationScores[0] = Convert.ToInt32(txtPhysicalEducationHomework.Text);
            physicalEducationScores[1] = Convert.ToInt32(txtPhysicalEducationControl.Text);
            physicalEducationScores[2] = Convert.ToInt32(txtPhysicalEducationQuiz.Text);
            physicalEducationScores[3] = Convert.ToInt32(txtPhysicalEducationExam.Text);
        }
    }
}