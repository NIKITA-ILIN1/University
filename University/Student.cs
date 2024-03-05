using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class Student : User
    {
        public string Group { get; set; }

        private static int identificationNumber = 1000;
        public int IdentificationNumber { get; set; }
        public List<string> Subjects { get; set; }
        public List<int> Ratings { get; set; }

        public Student(string isurname, string iname, string ipatronymic, int iage, string ilogin, string ipassword, string igroup)
            : base(isurname, iname, ipatronymic, iage, ilogin, ipassword)
        {
            this.Group = igroup;
            Student.identificationNumber++;
            this.IdentificationNumber = Student.identificationNumber;
            this.Subjects = new List<string>();
            this.Ratings = new List<int>();
        }

        public Student(string isurname, string iname, string ipatronymic, int iage, string ilogin, string ipassword, string igroup,
            int iidentificationNumber) : base(isurname, iname, ipatronymic, iage, ilogin, ipassword)
        {
            this.Group = igroup;
            this.IdentificationNumber = iidentificationNumber;
            this.Subjects = new List<string>();
            this.Ratings = new List<int>();
        }

        public override string ToString()
        {
            return $"Фамилия: {this.Surname}\n" +
                   $"Имя:          {this.Name}\n" +
                   $"Отчество:  {this.Patronymic}\n" +
                   $"Возраст:    {this.Age}\n" +
                   $"Логин:        {this.Login}\n" +
                   $"Пароль:     {this.Password}\n" +
                   $"Группа:     {this.Group}\n" +
                   $"Идентификационный номер:     {this.IdentificationNumber}\n";
        }
    }
}
