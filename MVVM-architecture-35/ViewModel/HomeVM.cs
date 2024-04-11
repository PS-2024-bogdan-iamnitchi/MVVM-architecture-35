using MVVM_architecture_35.ViewModel.Commands;
using System.ComponentModel;
using System.Windows.Forms;
using MVVM_architecture_35.ViewModel.Commands.HomeCommands;

namespace MVVM_architecture_35.ViewModel
{
    public class HomeVM : INotifyPropertyChanged
    {
        public string loggedPlayerEmail;
        public bool isVisible;
        public IComand ToGameCommand;
        public IComand ToEditPlayersCommand;
        public IComand SignOutCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        public HomeVM(string loggedPlayerEmail)
        {
            this.loggedPlayerEmail = loggedPlayerEmail;
            isVisible = true;
            this.ToGameCommand = new ToGameCommand(this);
            this.ToEditPlayersCommand = new ToEditPlayersCommand(this);
            this.SignOutCommand = new SignOutCommand(this);
        }

        public string LoggedPlayerEmail
        {
            get { return this.loggedPlayerEmail; }
            set
            {
                this.loggedPlayerEmail = value;
                OnPropertyChanged(nameof(IsVisible));
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
