using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm_practice.Model
{
    class Account
    {
        private int id;
        private string login;
        private string password;
        private string email;
        private DateTime birthdayDate;

        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public DateTime BirthdayDate { get => birthdayDate; set => birthdayDate = value; }

        public Account()
        {
        }

        public Account(int id, string login, string password)
        {
            this.id = id;
            this.login = login;
            this.password = password;
        }

        public Account(int id, string login, string password, string email)
            : this(id, login, password)
        {
            this.email = email;
        }

        public Account(int id, string login, string password, string email, DateTime birthdayDate)
            : this(id, login, password, email)
        {
            this.birthdayDate = birthdayDate;
        }
    }
}
