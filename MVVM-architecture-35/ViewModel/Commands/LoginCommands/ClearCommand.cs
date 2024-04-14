using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_architecture_35.ViewModel.Commands.LoginCommands
{
    public class ClearCommand : IComand
    {
        private LoginVM loginVM;

        public ClearCommand(LoginVM loginVM)
        {
            this.loginVM = loginVM;
        }

        //Implementing IComand ----------------------------------------------------------------------------------------------------------------
        public void Execute()
        {
            this.loginVM.Email = "";
            this.loginVM.Password = "";
        }
    }
}
