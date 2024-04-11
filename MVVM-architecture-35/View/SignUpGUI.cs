using MVVM_architecture_35.ViewModel;
using System;
using System.Windows.Forms;

namespace MVVM_architecture_35.View
{
    public partial class SignUpGUI : Form
    {
        private SignUpVM signUpVM;
        public SignUpGUI()
        {
            InitializeComponent();

            this.signUpVM = new SignUpVM();

            this.fullNameTextBox.DataBindings.Add("Text", this.signUpVM, "fullName", false, DataSourceUpdateMode.OnPropertyChanged);
            this.emailTextBox.DataBindings.Add("Text", this.signUpVM, "email", false, DataSourceUpdateMode.OnPropertyChanged);
            this.ageNumUpDown.DataBindings.Add("Value", this.signUpVM, "age", false, DataSourceUpdateMode.OnPropertyChanged);
            this.passwordTextBox.DataBindings.Add("Text", this.signUpVM, "password", false, DataSourceUpdateMode.OnPropertyChanged);

            this.DataBindings.Add("Visible", this.signUpVM, "isVisible", false, DataSourceUpdateMode.OnPropertyChanged);
            
            this.signUpButton.Click += delegate { signUpVM.SignUpCommand.Execute(); };
            this.clearButton.Click += delegate { signUpVM.ClearCommand.Execute(); };
            this.loginLinkedLabel.Click += delegate { signUpVM.ToLoginCommand.Execute(); };

        }
    }
}
