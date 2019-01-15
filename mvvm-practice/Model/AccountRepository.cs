using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm_practice.Model
{
    class AccountRepository
    {
        private ObservableCollection<Account> accounts;

        public ObservableCollection<Account> Accounts
        {
            get
            {
                if(accounts == null)
                    accounts = LoadAccounts();
                return accounts;
            }
        }

        private ObservableCollection<Account> LoadAccounts() // тут может быть загрузка аккаунтов с БД
        {
            ObservableCollection<Account> _accounts = new ObservableCollection<Account>();

            _accounts.Add(new Account(1, "devmaks", "12345"));
            _accounts.Add(new Account(2, "artem", "qwerty", "lol@lol.lol"));
            _accounts.Add(new Account(3, "nasya","xexex","cherry@cher.ry", new DateTime(1997, 8, 4)));

            return _accounts;
        }
    }
}
