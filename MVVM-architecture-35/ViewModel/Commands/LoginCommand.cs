using MVVM_architecture_35.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace MVVM_architecture_35.ViewModel.Commands
{
    public class LoginCommand : ICommand
    {
        private LoginVM loginVM;
        
        public LoginCommand(LoginVM loginVM)
        {
            this.loginVM = loginVM;
        }

        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            PlayerRepository playerRepository = new PlayerRepository();

            try
            {
                string email = this.loginVM.Email;
                string password = this.loginVM.Password;

                if (this.validInformation(email, password))
                {
                    bool result = playerRepository.LoginPlayer(email, password);
                    if (result)
                    {
                        //this.iLoginGUI.SetMessage("Success!", "Login successfully!");
                        //this.homeView();
                    }
                    else
                        MessageBox.Show("Failure!", "Login was ended with failure!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exeption - Login", ex.ToString());
            }
        }

        private bool validInformation(string email, string password)
        {
            if (email == null || email.Length == 0)
            {
                MessageBox.Show("Incomplete information!", "Email field is empty!");
                return false;
            }

            if (password == null || password.Length == 0)
            {
                MessageBox.Show("Incomplete information!", "Password field is empty!");
                return false;
            }
            return true;
        }
    }
}
