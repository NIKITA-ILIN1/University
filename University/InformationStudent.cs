using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class InformationStudent : Form
    {
        public InformationStudent()
        {
            InitializeComponent();
        }

        internal InformationStudent(Student student)
        {
            InitializeComponent();
            InfStd.Text = student.ToString();
        }

        private void InformationStudent_Load(object sender, EventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
