using MVVM_architecture_35.Model.Repository;
using MVVM_architecture_35.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MVVM_architecture_35.ViewModel.Commands
{
    public class LoginCommand : IComand
    {
        private LoginVM loginVM;
        
        public LoginCommand(LoginVM loginVM)
        {
            this.loginVM = loginVM;
        }

        //Implementing IComand -----------------------------------------------------------------------------------------------------
        public void Execute()
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
                        //this.loginVM.SetMessage("Success!", "New account was created successfully!");
                        this.toHomeGUI(email);
                    }
                    else
                        this.loginVM.SetMessage("Failure!", "Login was ended with failure!");

                }
            }
            catch (Exception ex)
            {
                this.loginVM.SetMessage("Exeption - Login", ex.ToString());
            }
        }

        //Command specific----------------------------------------------------------------------------------------------------------------------
        private void toHomeGUI(string email)
        {
            this.loginVM.IsVisible = false;
            HomeGUI homeGUI = new HomeGUI(email);
            homeGUI.Show();
        }

        private bool validInformation(string email, string password)
        {
            if (email == null || email.Length == 0)
            {
                this.loginVM.SetMessage("Incomplete information!", "Email field is empty!");
                return false;
            }

            if (password == null || password.Length == 0)
            {
                this.loginVM.SetMessage("Incomplete information!", "Password field is empty!");
                return false;
            }
            return true;
        }
    }
}
