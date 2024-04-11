using MVVM_architecture_35.ViewModel;
using System;
using System.Windows.Forms;

namespace MVVM_architecture_35.View
{
    public partial class LoginGUI : Form
    {
        private LoginVM loginVM;
        public LoginGUI()
        {
            InitializeComponent();

            this.loginVM = new LoginVM();
            
            this.emailTextBox.DataBindings.Add("Text", this.loginVM, "email", false, DataSourceUpdateMode.OnPropertyChanged);
            this.passwordTextBox.DataBindings.Add("Text", this.loginVM, "password", false, DataSourceUpdateMode.OnPropertyChanged);
            
            this.DataBindings.Add("Visible", this.loginVM, "isVisible", false, DataSourceUpdateMode.OnPropertyChanged);

            this.loginButton.Click += delegate { loginVM.LoginCommand.Execute(); };
            this.clearButton.Click += delegate { loginVM.ClearCommand.Execute(); };
            this.signUpLinkLabel.Click += delegate { loginVM.ToSignUpCommand.Execute(); };
            this.playGameLinkedLabel.Click += delegate { loginVM.ToGameCommand.Execute(); };

        }

    }
}
