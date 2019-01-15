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

        public int Id
        {
            get
            {
                if (id == 0)
                {
                    return -1;
                }

                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Login
        {
            get
            {
                if (string.IsNullOrEmpty(login))
                {
                    return "";
                }

                return login;
            }
            set
            {
                login = value;
            }
        }

        public string Password
        {
            get
            {
                if (string.IsNullOrEmpty(password))
                {
                    return "";
                }
                    
                return password;
            }
            set
            {
                password = value;
            }
        }

        public string Email
        {
            get
            {
                if (string.IsNullOrEmpty(email))
                {
                    return "";
                }
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string BirthdayDate
        {
            get
            {
                if (birthdayDate < new DateTime(1900, 1, 1))
                {
                    return "";
                }

                return birthdayDate.ToLongDateString();
            }
            set
            {
                birthdayDate = DateTime.Parse(value);
            }
        }

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
