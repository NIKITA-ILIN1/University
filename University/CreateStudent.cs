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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace University
{
    public partial class CreateStudent : Form
    {
        private string fileStudents = "students.db";
        private string fileTeachers = "teachers .db";
        private string fileUsers = "users.db";

        internal University University { get; set; }

        public CreateStudent()
        {
            InitializeComponent();
        }

        internal CreateStudent(University univer)
        {
            InitializeComponent();
            University = univer;
        }

        private void CreateStudent_Load(object sender, EventArgs e)
        {

        }

        private void CreateStd_Click(object sender, EventArgs e)
        {
            Student student = new Student(SurnameStudent.Text, NameStudent.Text, PatronymicStudent.Text, Convert.ToInt32(AgeStudent.Text),
            LoginStudent.Text, PasswordStudent.Text, GroupStudent.Text);
            if (CheckEmpty(student))
            {
                MessageBox.Show("Пустые поля");
                return;
            }

            if (NotUnique(student))
            {
                MessageBox.Show("Такой студент уже есть");
                return;
            }

            foreach (Student student1 in University.Students)
            {
                if (student.IdentificationNumber == student1.IdentificationNumber)
                {
                    student.IdentificationNumber++;
                }
            }

            University.Students.Add(student);
            University.Users.Add(student);

            WriteStudentToFileStudents(student);
            WriteStudentToFileUsers(student);

            MessageBox.Show("Студент записан в файл");
            this.Close();
            InformationStudent informationStudent = new InformationStudent(student);
            informationStudent.ShowDialog();
        }

        private bool CheckEmpty(Student student)
        {
            return string.IsNullOrEmpty(student.Surname) ||
                   string.IsNullOrEmpty(student.Name) ||
                   string.IsNullOrEmpty(student.Patronymic) ||
                   string.IsNullOrEmpty(student.Age.ToString()) ||
                   string.IsNullOrEmpty(student.Login) ||
                   string.IsNullOrEmpty(student.Password) ||
                   string.IsNullOrEmpty(student.Group);
        }

        private bool NotUnique(Student student)
        {
            return University.Students.Any(s => s.Login == student.Login && s.Password == student.Password);
        }

        private void WriteStudentToFileStudents(Student student)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileStudents, true))
                {
                    writer.Write($"{student.Surname};");
                    writer.Write($"{student.Name};");
                    writer.Write($"{student.Patronymic};");
                    writer.Write($"{student.Age};");
                    writer.Write($"{student.Login};");
                    writer.Write($"{student.Password};");
                    writer.Write($"{student.Group};");
                    writer.Write($"{student.IdentificationNumber};");
                    writer.WriteLine("Student;");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при записи в файл: {ex.Message}");
            }
        }

        private void WriteStudentToFileUsers(Student student)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileUsers, true))
                {
                    writer.Write($"{student.Surname};");
                    writer.Write($"{student.Name};");
                    writer.Write($"{student.Patronymic};");
                    writer.Write($"{student.Age};");
                    writer.Write($"{student.Login};");
                    writer.Write($"{student.Password};");
                    writer.Write($"{student.Group};");
                    writer.Write($"{student.IdentificationNumber};");
                    writer.WriteLine("Student;");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при записи в файл: {ex.Message}");
            }
        }

        private void ExitOnInitialForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
