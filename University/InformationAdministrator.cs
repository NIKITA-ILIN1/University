using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class InformationAdministrator : Form
    {
        internal University University { get; set; }

        public InformationAdministrator()
        {
            InitializeComponent();
        }

        internal InformationAdministrator(University univer, Administrator admin)
        {
            InitializeComponent();
            University = univer;
            InfAdmin.Text = admin.ToString();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {

        }

        private void CreateStudent_Click(object sender, EventArgs e)
        {
            this.Close();
            CreateStudent createStudent = new CreateStudent(University);
            createStudent.ShowDialog();
            University = createStudent.University;
        }

        private void CreateTeacher_Click(object sender, EventArgs e)
        {
            this.Close();
            CreateTeacher createTeacher = new CreateTeacher(University);
            createTeacher.ShowDialog();
            University = createTeacher.University;
        }

        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            if (University.Students.Count > 0)
            {
                this.Close();
                DeleteStudent deleteStudent = new DeleteStudent(University);
                deleteStudent.ShowDialog();
                University = deleteStudent.University;
            }
        }

        private void ExitOnInitialForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
