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
    public partial class InitialForm : Form
    {
        private string fileStudents = "students.db";
        private string fileTeachers = "teachers .db";
        private string fileUsers = "users.db";
        private University university = new University();
        private Administrator administrator = new Administrator("Иванов", "Иван", "Иванович", 35, "админ", "админ");

        public InitialForm()
        {
            InitializeComponent();

            if (File.Exists(fileStudents))
            {
                UploadStudentsFromFileStudents();
            }

            if (File.Exists(fileTeachers))
            {
                UploadTeachersFromFileTeachers();
            }

            if (File.Exists(fileUsers))
            {
                UploadUsersFromFileUsers();
            }
        }

        private void InitialForm_Load(object sender, EventArgs e)
        {

        }

        private void Authorization_Click(object sender, EventArgs e)
        {
            bool userFound = false;

            if (Login.Text == administrator.Login && Password.Text == administrator.Password)
            {
                userFound = true;
                GoToTheAdministrator();
            }

            foreach (User user in university.Users)
            {
                if (Login.Text == user.Login && Password.Text == user.Password)
                {
                    userFound = true;

                    if (user is Student student)
                    {
                        Login.Text = "";
                        Password.Text = "";
                        this.Hide();
                        Form informationStudent = new InformationStudent(student);
                        informationStudent.ShowDialog();
                        this.Show();
                        return;
                    }
                    else if (user is Teacher teacher)
                    {
                        Login.Text = "";
                        Password.Text = "";
                        this.Hide();
                        Form informationTeacher = new InformationTeacher(teacher);
                        informationTeacher.ShowDialog();
                        this.Show();
                        return;
                    }
                }
            }
            if (!userFound)
            {
                MessageBox.Show("Пользователь не найден!");
            }
        }

        private void GoToTheAdministrator()
        {
            Login.Text = "";
            Password.Text = "";
            this.Hide();
            InformationAdministrator informationAdministrator = new InformationAdministrator(university, administrator);
            informationAdministrator.ShowDialog();
            university = informationAdministrator.University;
            this.Show();
            return;
        }

        private void UploadStudentsFromFileStudents()
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileStudents))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] studentData = line.Split(';');

                        Student student = new Student(studentData[0], studentData[1], studentData[2], Convert.ToInt32(studentData[3]),
                            studentData[4], studentData[5], studentData[6], Convert.ToInt32(studentData[7]));

                        university.Students.Add(student);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при чтении из файла: {ex.Message}");
            }
        }

        private void UploadTeachersFromFileTeachers()
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileTeachers))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] teacherData = line.Split(';');

                        Teacher teacher = new Teacher(teacherData[0], teacherData[1], teacherData[2], Convert.ToInt32(teacherData[3]), 
                            teacherData[4], teacherData[5], teacherData[6], Convert.ToInt32(teacherData[7]));

                        university.Teachers.Add(teacher);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при чтении из файла: {ex.Message}");
            }
        }

        private void UploadUsersFromFileUsers()
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileUsers))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] Data = line.Split(';');

                        if (Data[8] == "Student")
                        {
                            Student student = new Student(Data[0], Data[1], Data[2], Convert.ToInt32(Data[3]), Data[4],
                                Data[5], Data[6], Convert.ToInt32(Data[7]));

                            university.Users.Add(student);
                        }
                        else if (Data[8] == "Teacher")
                        {
                            Teacher teacher = new Teacher(Data[0], Data[1], Data[2], Convert.ToInt32(Data[3]), Data[4],
                                Data[5], Data[6], Convert.ToInt32(Data[7]));

                            university.Users.Add(teacher);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при чтении из файла: {ex.Message}");
            }
        }

        private void ExitTheApplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
