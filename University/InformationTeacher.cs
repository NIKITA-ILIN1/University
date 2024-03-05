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
    public partial class InformationTeacher : Form
    {
        public InformationTeacher()
        {
            InitializeComponent();
        }

        internal InformationTeacher(Teacher teacher)
        {
            InitializeComponent();
            InfTchr.Text = teacher.ToString();
        }

        private void InformationTeacher_Load(object sender, EventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
