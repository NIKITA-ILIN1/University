using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class CreateTeacher : Form
    {
        private string fileStudents = "students.db";
        private string fileTeachers = "teachers .db";
        private string fileUsers = "users.db";

        internal University University { get; set; }

        public CreateTeacher()
        {
            InitializeComponent();
        }

        internal CreateTeacher(University univer)
        {
            InitializeComponent();
            University = univer;
        }

        private void CreateTeacher_Load(object sender, EventArgs e)
        {

        }

        private void CreateTchr_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text),
                textBox5.Text, textBox6.Text, textBox7.Text, Convert.ToInt32(textBox8.Text));

            foreach (User user in University.Users)
            {
                if (teacher.Login == user.Login && teacher.Password == user.Password)
                {
                    MessageBox.Show("Такой преподаватель уже есть");
                    return;
                }
            }

            University.Teachers.Add(teacher);
            University.Users.Add(teacher);

            WriteTeacherToFileTeachers(teacher);
            WriteTeacherToFileUsers(teacher);

            MessageBox.Show("Преподаватель записан в файл");
            this.Close();
            InformationTeacher informationTeacher = new InformationTeacher(teacher);
            informationTeacher.ShowDialog();
        }

        private void WriteTeacherToFileTeachers(Teacher teacher)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileTeachers, true))
                {
                    writer.Write($"{teacher.Surname};");
                    writer.Write($"{teacher.Name};");
                    writer.Write($"{teacher.Patronymic};");
                    writer.Write($"{teacher.Age};");
                    writer.Write($"{teacher.Login};");
                    writer.Write($"{teacher.Password};");
                    writer.Write($"{teacher.Subject};");
                    writer.Write($"{teacher.Salary};");
                    writer.WriteLine("Teacher;");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при записи в файл: {ex.Message}");
            }
        }

        private void WriteTeacherToFileUsers(Teacher teacher)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileUsers, true))
                {
                    writer.Write($"{teacher.Surname};");
                    writer.Write($"{teacher.Name};");
                    writer.Write($"{teacher.Patronymic};");
                    writer.Write($"{teacher.Age};");
                    writer.Write($"{teacher.Login};");
                    writer.Write($"{teacher.Password};");
                    writer.Write($"{teacher.Subject};");
                    writer.Write($"{teacher.Salary};");
                    writer.WriteLine("Teacher;");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при записи в файл: {ex.Message}");
            }
        }

        private void ReturnOnInitialForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
