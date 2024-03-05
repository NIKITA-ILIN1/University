using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class University
    {
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<User> Users { get; set; }

        public University()
        {
            this.Students = new List<Student>();
            this.Teachers = new List<Teacher>();
            this.Users = new List<User>();
        }
    }
}
