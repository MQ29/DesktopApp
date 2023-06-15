using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Logindb.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        //Fields
        private string _username;
        private SecureString _password;
        private string _errorMessage;
        public bool _isViewVisible = true;

        //Properties

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        public SecureString Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }

        public bool IsViewVisible
        {
            get { return _isViewVisible; }
            set
            {
                _isViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
            }
        }

        //Commands
        public ICommand LoginCommand { get; }
        public ICommand RecoverPasswordCommand { get; }
        public ICommand RememberPasswordCommand { get; }
        public ICommand ShowPasswordCommand { get; }

        //constructor

        public LoginViewModel()
        {
            LoginCommand = new ViewModelCommand(ExecuteLoginCommand, CanExecuteLoginCommand);
            RecoverPasswordCommand = new ViewModelCommand(p=>ExecuteRecoverPassCommand("","")); //using 1 parameter ctor
        }

        private void ExecuteRecoverPassCommand(string username, string email)
        {
            throw new NotImplementedException();
        }

        private bool CanExecuteLoginCommand(object obj)
        {
            bool isValid;
            if (string.IsNullOrWhiteSpace(Username) || Username.Length < 3 ||
                Password == null || Password.Length < 3)
                isValid = false;
            else
                isValid = true;

            return isValid;
        }

        private void ExecuteLoginCommand(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
