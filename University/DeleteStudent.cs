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
    public partial class DeleteStudent : Form
    {
        private string fileStudents = "students.db";
        private string fileUsers = "users.db";

        internal University University { get; set; }

        public DeleteStudent()
        {
            InitializeComponent();
        }

        internal DeleteStudent(University univer)
        {
            InitializeComponent();
            University = univer;
            InitializeListStudents();
        }

        private void InitializeListStudents()
        {
            listStudents.Columns.Clear();

            DataGridViewTextBoxColumn columnStudentNumber = new DataGridViewTextBoxColumn();
            columnStudentNumber.HeaderText = "Номер студента";
            columnStudentNumber.Width = 55;
            listStudents.Columns.Add(columnStudentNumber);

            DataGridViewTextBoxColumn columnSurnameStudent = new DataGridViewTextBoxColumn();
            columnSurnameStudent.HeaderText = "Фамилия студента";
            columnSurnameStudent.Width = 100;
            listStudents.Columns.Add(columnSurnameStudent);

            DataGridViewTextBoxColumn columnNameStudent = new DataGridViewTextBoxColumn();
            columnNameStudent.HeaderText = "Имя студента";
            columnNameStudent.Width = 100;
            listStudents.Columns.Add(columnNameStudent);

            DataGridViewTextBoxColumn columnPatronymicStudent = new DataGridViewTextBoxColumn();
            columnPatronymicStudent.HeaderText = "Отчество студента";
            columnPatronymicStudent.Width = 100;
            listStudents.Columns.Add(columnPatronymicStudent);

            DataGridViewTextBoxColumn columnAgeStudent = new DataGridViewTextBoxColumn();
            columnAgeStudent.HeaderText = "Возраст студента";
            columnAgeStudent.Width = 55;
            listStudents.Columns.Add(columnAgeStudent);

            DataGridViewTextBoxColumn columnLoginStudent = new DataGridViewTextBoxColumn();
            columnLoginStudent.HeaderText = "Логин студента";
            columnLoginStudent.Width = 100;
            listStudents.Columns.Add(columnLoginStudent);

            DataGridViewTextBoxColumn columnPasswordStudent = new DataGridViewTextBoxColumn();
            columnPasswordStudent.HeaderText = "Пароль студента";
            columnPasswordStudent.Width = 100;
            listStudents.Columns.Add(columnPasswordStudent);

            DataGridViewTextBoxColumn columnGroupStudent = new DataGridViewTextBoxColumn();
            columnGroupStudent.HeaderText = "Группа студента";
            columnGroupStudent.Width = 50;
            listStudents.Columns.Add(columnGroupStudent);

            DataGridViewTextBoxColumn columnIdentificationNumberStudent = new DataGridViewTextBoxColumn();
            columnIdentificationNumberStudent.HeaderText = "Уник. номер студента";
            columnIdentificationNumberStudent.Width = 50;
            listStudents.Columns.Add(columnIdentificationNumberStudent);

            int temp = 0;

            foreach (Student student in University.Students)
            {
                temp++;
                listStudents.Rows.Add(temp, student.Surname, student.Name, student.Patronymic, student.Age, student.Login, student.Password,
                    student.Group, student.IdentificationNumber);
            }
        }

        private void DeleteStudent_Load(object sender, EventArgs e)
        {

        }

        private void DelStd_Click(object sender, EventArgs e)
        {
            int rowIndex = listStudents.CurrentCell.RowIndex;
            listStudents.Rows.RemoveAt(rowIndex);
            University.Students.RemoveAt(rowIndex);
            University.Users.RemoveAt(rowIndex);
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            ReWriteStudentsToFileStudents(University.Students);
            ReWriteStudentsToFileUsers(University.Users);
        }

        private void ReWriteStudentsToFileStudents(List<Student> students)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileStudents))
                {
                    foreach (Student student in students)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при записи в файл: {ex.Message}");
            }
        }

        private void ReWriteStudentsToFileUsers(List<User> users)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileUsers))
                {
                    foreach (User user in University.Users)
                    {
                        if (user is Student student)
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
                        else if (user is Teacher teacher)
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
