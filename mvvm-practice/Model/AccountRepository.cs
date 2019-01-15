using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm_practice.Model
{
    static class AccountRepository
    {
        private static ObservableCollection<Account> accounts;

        public static ObservableCollection<Account> AllAccounts
        {
            get
            {
                if(accounts == null)
                    accounts = LoadAccounts();
                return accounts;
            }
        }

        private static ObservableCollection<Account> LoadAccounts() // тут может быть загрузка аккаунтов с БД
        {
            ObservableCollection<Account> _accounts = new ObservableCollection<Account>();

            _accounts.Add(new Account(1, "devmaks", "12345", "test@test.com", new DateTime(1999, 02, 21)));
            _accounts.Add(new Account(2, "artem", "qwerty", "lol@lol.lol"));
            _accounts.Add(new Account(3, "nasya","xexex","cherry@cher.ry", new DateTime(1997, 8, 4)));
            _accounts.Add(new Account(4, "Baba", "sdfsdf", "fdsdf@232.ew", new DateTime(1985, 3, 2)));
            _accounts.Add(new Account(5, "Dida", "2312dsdf", "23124d@dsd.tr", new DateTime(2008, 1, 1)));
            _accounts.Add(new Account(6, "Kurwa", "r4f43qg", "werewr@123.rt", new DateTime(2018, 5, 6)));

            return _accounts;
        }
    }
}
