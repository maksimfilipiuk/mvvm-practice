using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvvm_practice.Model;
using mvvm_practice.Infrastructure;
using System.Windows.Input;

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

        Account _currentAccount;
        public Account CurrentAccount
        {
            get
            {
                if (_currentAccount == null)
                    _currentAccount = new Account();
                return _currentAccount;
            }
            set
            {
                _currentAccount = value;
                OnPropertyChanged("CurrentAccount");
            }
        }

        RelayCommand createAccountCommand;
        public ICommand CreateAccount
        {
            get
            {
                if(createAccountCommand == null)
                {
                    createAccountCommand = new RelayCommand(ExecuteCreateAccountCommand, CanExecuteCreateAccountCommand);
                }

                return createAccountCommand;
            }
        }

        private bool CanExecuteCreateAccountCommand(object obj)
        {
            if(string.IsNullOrEmpty(CurrentAccount.Login) || 
                string.IsNullOrEmpty(CurrentAccount.Password))
            {
                return false;
            }

            return true;
        }

        private void ExecuteCreateAccountCommand(object obj)
        {
            CurrentAccount.Id = Accounts.Count + 1;
            Accounts.Add(CurrentAccount);
            CurrentAccount = null;
        }

        protected override void OnDispose()
        {
            this.Accounts.Clear();
        }
    }
}
