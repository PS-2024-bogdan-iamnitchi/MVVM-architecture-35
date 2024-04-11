using MVVM_architecture_35.ViewModel.Commands;
using MVVM_architecture_35.ViewModel.Commands.LoginCommands;
using System.ComponentModel;
using System.Windows.Forms;

namespace MVVM_architecture_35.ViewModel
{
    public class LoginVM : INotifyPropertyChanged
    {
        private string email;
        private string password;
        private bool isVisible;
        public IComand LoginCommand;
        public IComand ClearCommand;
        public IComand ToSignUpCommand;
        public IComand ToGameCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        public LoginVM()
        {
            this.email = "";
            this.password = "";
            this.isVisible = true;
            this.LoginCommand = new LoginCommand(this);
            this.ClearCommand = new ClearCommand(this);
            this.ToSignUpCommand = new ToSignUpCommand(this);
            this.ToGameCommand = new ToGameCommand(this);
        }

        public string Email 
        {
            get { return this.email; }
            set { 
                this.email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public string Password
        {
            get { return this.password; }
            set 
            { 
                this.password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public bool IsVisible
        {
            get { return this.isVisible; }
            set 
            {
                this.isVisible = value;
                OnPropertyChanged(nameof(IsVisible));
            }
        }

        public void SetMessage(string title, string message)
        {
            MessageBox.Show(message, title);
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
