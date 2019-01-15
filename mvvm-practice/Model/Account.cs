using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm_practice.Model
{
    class Account
    {
        private static int accountsCount = 0;

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

        static Account()
        {
            accountsCount++;
        }

        public Account()
        {
        }

        public Account(string login, string password)
        {
            this.id = accountsCount;
            this.login = login;
            this.password = password;
        }

        public Account(string login, string password, string email)
            : this(login, password)
        {
            this.email = email;
        }

        public Account(string login, string password, string email, DateTime birthdayDate)
            : this(login, password, email)
        {
            this.birthdayDate = birthdayDate;
        }
    }
}
