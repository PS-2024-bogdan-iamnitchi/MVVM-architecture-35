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
            this.emailTextBox.DataBindings.Add("Text", this.loginVM, "email", false, DataSourceUpdateMode.OnValidation);
            this.passwordTextBox.DataBindings.Add("Text", this.loginVM, "password", false, DataSourceUpdateMode.OnValidation);

            this.loginButton.Click += delegate { loginVM.LoginCommand.Execute(null); };
        }

    }
}
