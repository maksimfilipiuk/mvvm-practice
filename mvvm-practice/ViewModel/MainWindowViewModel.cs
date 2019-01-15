using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvvm_practice.Model;

namespace mvvm_practice.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        ObservableCollection<Account> _accounts;

        public ObservableCollection<Account> Accounts
        {
            get
            {
                if (_accounts == null)
                {
                    _accounts = AccountRepository.AllAccounts;
                }

                return _accounts;
            }
        }
    }
}
