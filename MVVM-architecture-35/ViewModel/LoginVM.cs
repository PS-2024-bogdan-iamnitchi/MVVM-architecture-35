using MVVM_architecture_35.ViewModel.Commands;
using System.Data;
using System.Windows.Input;

namespace MVVM_architecture_35.ViewModel
{
    public class LoginVM
    {
        private string email;
        private string password;
        public ICommand LoginCommand;

        public LoginVM()
        {
            this.email = "";
            this.password = "";
            this.LoginCommand = new LoginCommand(this);
        }

        public string Email 
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

    }
}
