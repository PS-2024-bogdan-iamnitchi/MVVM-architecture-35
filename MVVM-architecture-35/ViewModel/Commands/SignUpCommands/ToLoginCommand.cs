using MVVM_architecture_35.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_architecture_35.ViewModel.Commands.SignUpCommands
{
    public class ToLoginCommand : IComand
    {
        private SignUpVM signUpVM;

        public ToLoginCommand(SignUpVM signUpVM)
        {
            this.signUpVM = signUpVM;
        }

        public void Execute()
        {
            this.signUpVM.IsVisible = false;
            LoginGUI loginGUI = new LoginGUI();
            loginGUI.Show();
        }
    }
}
