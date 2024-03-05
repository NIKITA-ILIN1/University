using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class Teacher : User
    {
        public string Subject { get; set; }
        public int Salary { get; set; }

        public Teacher(string isurname, string iname, string ipatronymic, int iage, string ilogin, string ipassword, string isubject,
            int isalary) : base(isurname, iname, ipatronymic, iage, ilogin, ipassword)
        {
            this.Subject = isubject;
            this.Salary = isalary;
        }

        public override string ToString()
        {
            return $"Фамилия: {this.Surname}\n" +
                   $"Имя:          {this.Name}\n" +
                   $"Отчество:  {this.Patronymic}\n" +
                   $"Возраст:    {this.Age}\n" +
                   $"Логин:        {this.Login}\n" +
                   $"Пароль:     {this.Password}\n" +
                   $"Предмет:     {this.Subject}\n" +
                   $"Зарплата:     {this.Salary}\n";
        }
    }
}
