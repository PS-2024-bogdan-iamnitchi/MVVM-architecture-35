using MVVM_architecture_35.Model.Repository;
using MVVM_architecture_35.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MVVM_architecture_35.ViewModel.Commands.LoginCommands
{
    public class ToSignUpCommand : IComand
    {
        private LoginVM loginVM;

        public ToSignUpCommand(LoginVM loginVM)
        {
            this.loginVM = loginVM;
        }

        //Implementing IComand -----------------------------------------------------------------------------------------------------
        public void Execute()
        {
            this.loginVM.IsVisible = false;
            SignUpGUI signUpGUI = new SignUpGUI();
            signUpGUI.Show();
        } 
    }
}
