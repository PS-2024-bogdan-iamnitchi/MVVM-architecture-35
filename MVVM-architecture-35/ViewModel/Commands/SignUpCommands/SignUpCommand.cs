using MVVM_architecture_35.Model;
using MVVM_architecture_35.Model.Repository;
using MVVM_architecture_35.View;
using System;
using System.Windows.Forms;

namespace MVVM_architecture_35.ViewModel.Commands.SignUpCommands
{
    public class SignUpCommand : IComand
    {
        private SignUpVM signUpVM;

        public SignUpCommand(SignUpVM signUpVM)
        {
            this.signUpVM = signUpVM;
        }

        //Implementing IComand -----------------------------------------------------------------------------------------------------
        public void Execute()
        {
            PlayerRepository playerRepository = new PlayerRepository();

            try
            {
                Player player = this.validInformation();
                if (player != null)
                {
                    bool result = playerRepository.SignUpPlayer(player);
                    if (result)
                    {
                        this.signUpVM.SetMessage("Success!", "New account was created successfully!");
                        this.toLoginGUI();
                    }
                    else
                        this.signUpVM.SetMessage("Failure!", "Adding was ended with failure!");

                }
            }
            catch (Exception ex)
            {
                this.signUpVM.SetMessage("Exeption - SignUp", ex.ToString());
            }
        }

        //Command specific----------------------------------------------------------------------------------------------------------------------
        private void toLoginGUI()
        {
            this.signUpVM.IsVisible = false;
            LoginGUI loginGUI = new LoginGUI();
            loginGUI.Show();
        }

        private Player validInformation()
        {
            string fullName = this.signUpVM.FullName;
            if (fullName == null || fullName.Length == 0)
            {
                this.signUpVM.SetMessage("Incomplete information!", "FullName field is empty!");
                return null;
            }

            string email = this.signUpVM.Email;
            if (email == null || email.Length == 0)
            {
                this.signUpVM.SetMessage("Incomplete information!", "Email field is empty!");
                return null;
            }

            uint age = (uint)this.signUpVM.Age;
            if (age <= 10)
            {
                this.signUpVM.SetMessage("Incomplete information!", "Player age must be greater or equal with 10!");
                return null;
            }

            string password = this.signUpVM.Password;
            if (password == null || password.Length == 0)
            {
                this.signUpVM.SetMessage("Incomplete information!", "Password field is empty!");
                return null;
            }
            return new Player(fullName, email, age, password);
        }
    }
}
