using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class Administrator : User
    {
        public Administrator(string isurname, string iname, string ipatronymic, int iage, string ilogin, string ipassword)
           : base(isurname, iname, ipatronymic, iage, ilogin, ipassword)
        {
        }

        public override string ToString()
        {
            return $"Фамилия: {this.Surname} \n" +
                   $"Имя:          {this.Name} \n" +
                   $"Отчество:  {this.Patronymic} \n" +
                   $"Возраст:    {this.Age} \n" +
                   $"Логин:        {this.Login} \n" +
                   $"Пароль:     {this.Password} \n";
        }
    }
}
