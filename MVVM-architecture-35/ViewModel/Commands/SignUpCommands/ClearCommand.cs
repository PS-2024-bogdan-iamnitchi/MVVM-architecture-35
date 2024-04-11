using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_architecture_35.ViewModel.Commands.SignUpCommands
{
    public class ClearCommand : IComand
    {
        private SignUpVM signUpVM;

        public ClearCommand(SignUpVM signUpVM)
        {
            this.signUpVM = signUpVM;
        }

        //Implementing IComand ----------------------------------------------------------------------------------------------------------------
        public void Execute()
        {
            this.signUpVM.FullName = "";
            this.signUpVM.Email = "";
            this.signUpVM.Age = 0;
            this.signUpVM.Password = "";
        }
    }
}
