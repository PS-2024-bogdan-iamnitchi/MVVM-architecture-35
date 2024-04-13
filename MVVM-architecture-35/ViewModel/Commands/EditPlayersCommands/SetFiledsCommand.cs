using MVVM_architecture_35.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVVM_architecture_35.ViewModel.Commands.EditPlayersCommands
{
    public class SetFiledsCommand : IComand
    {
        private EditPlayersVM editPlayersVM;

        public SetFiledsCommand(EditPlayersVM editPlayersVM)
        {
            this.editPlayersVM = editPlayersVM;
        }

        //Implementing IComand -----------------------------------------------------------------------------------------------------
        public void Execute()
        {
            try
            {
                DataGridViewRow drvr = this.editPlayersVM.SelectedRow;
                uint playerID = Convert.ToUInt32(drvr.Cells[0].Value);
                this.editPlayersVM.PlayerID = playerID;
                string fullName = drvr.Cells[1].Value.ToString();
                this.editPlayersVM.FullName = fullName;
                string email = drvr.Cells[2].Value.ToString();
                this.editPlayersVM.Email = email;
                uint age = Convert.ToUInt32(drvr.Cells[3].Value);
                this.editPlayersVM.Age = age;
                string password = drvr.Cells[4].Value.ToString();
                this.editPlayersVM.Password = password;
                uint score = Convert.ToUInt32(drvr.Cells[5].Value);
                this.editPlayersVM.Score = score;
            }
            catch (Exception)
            {
                MessageBox.Show("Error at row selection!");
            }
        }
    }
}
