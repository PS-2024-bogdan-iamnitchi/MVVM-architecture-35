﻿using MVVM_architecture_35.Model;
using MVVM_architecture_35.Model.Repository;
using MVVM_architecture_35.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_architecture_35.ViewModel.Commands.EditPlayersCommands
{
    public class AddCommand : IComand
    {
        private EditPlayersVM editPlayersVM;

        public AddCommand(EditPlayersVM editPlayersVM)
        {
            this.editPlayersVM = editPlayersVM;
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
                    bool result = playerRepository.AddPlayer(player);
                    if (result)
                    {
                        this.editPlayersVM.SetMessage("Success!", "Adding was completed successfully!");
                        this.editPlayersVM.LoadCommand.Execute();
                        //this.resetPlayerFields();
                        //this.iEditPlayersGUI.ResetPlayersDataGridView();
                    }
                    else
                        this.editPlayersVM.SetMessage("Failure!", "Adding was ended with failure!");
                }
            }
            catch (Exception exception)
            {
                this.editPlayersVM.SetMessage("Exception - Add", exception.ToString());
            }
        }

         //Command specific----------------------------------------------------------------------------------------------------------------------
        private Player validInformation()
        {
            string fullName = this.editPlayersVM.FullName;
            if (fullName == null || fullName.Length == 0)
            {
                this.editPlayersVM.SetMessage("Incomplete information!", "FullName field is empty!");
                return null;
            }

            string email = this.editPlayersVM.Email;
            if (email == null || email.Length == 0)
            {
                this.editPlayersVM.SetMessage("Incomplete information!", "Email field is empty!");
                return null;
            }

            uint age = (uint)this.editPlayersVM.Age;
            if (age <= 10)
            {
                this.editPlayersVM.SetMessage("Incomplete information!", "Player age must be greater or equal with 10!");
                return null;
            }

            string password = this.editPlayersVM.Password;
            if (password == null || password.Length == 0)
            {
                this.editPlayersVM.SetMessage("Incomplete information!", "Password field is empty!");
                return null;
            }
            return new Player(fullName, email, age, password);
        }
    }
}
