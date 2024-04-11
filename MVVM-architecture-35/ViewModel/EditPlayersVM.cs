using MVVM_architecture_35.ViewModel.Commands.SignUpCommands;
using MVVM_architecture_35.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVVM_architecture_35.ViewModel.Commands.EditPlayersCommands;

namespace MVVM_architecture_35.ViewModel
{
    public class EditPlayersVM : INotifyPropertyChanged
    {
        private int playerID;
        private string fullName;
        private string email;
        private int age;
        private string password;

        public string loggedPlayerEmail;
        private bool isVisible;
        public IComand LoadCommand;
        public IComand AddCommand;
        public IComand UpdateCommand;
        public IComand DeleteCommand;
        public IComand SearchCommand;
        public IComand ToHomeCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        public EditPlayersVM(string loggedPlayerEmail)
        {
            this.playerID = 0;
            this.fullName = "";
            this.email = "";
            this.age = 0;
            this.password = "";
            this.loggedPlayerEmail = loggedPlayerEmail;
            this.isVisible = true;
            this.LoadCommand = new LoadCommand(this);
            this.AddCommand = new AddCommand(this);
            this.UpdateCommand = new UpdateCommand(this);
            this.DeleteCommand = new DeleteCommand(this);
            this.SearchCommand = new SearchCommand(this);
            this.ToHomeCommand = new ToHomeCommand(this);
        }
        public int PlayerID
        {
            get { return this.playerID; }
            set
            {
                this.playerID = value;
                OnPropertyChanged(nameof(PlayerID));
            }
        }
        public string FullName
        {
            get { return this.fullName; }
            set
            {
                this.fullName = value;
                OnPropertyChanged(nameof(FullName));
            }
        }
        public string Email
        {
            get { return this.email; }
            set
            {
                this.email = value;
                OnPropertyChanged(nameof(Email));
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                this.age = value;
                OnPropertyChanged(nameof(Age));
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
