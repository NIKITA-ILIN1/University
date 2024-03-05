using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class User
    {
        protected string surname;
        protected string name;
        protected string patronymic;
        protected int age;
        protected string login;
        protected string password;

        public string Surname { get { return surname; } set { surname = value; } }

        public string Name { get { return name; } set { name = value; } }

        public string Patronymic { get { return patronymic; } set { patronymic = value; } }

        public int Age { get { return age; } set { age = value; } }

        public string Login { get { return login; } set { login = value; } }

        public string Password { get { return password; } set { password = value; } }

        public User(string isurname, string iname, string ipatronymic, int iage, string ilogin, string ipassword)
        {
            this.surname = isurname;
            this.name = iname;
            this.patronymic = ipatronymic;
            this.age = iage;
            this.login = ilogin;
            this.password = ipassword;
        }
    }
}
