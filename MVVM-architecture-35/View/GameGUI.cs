using MVVM_architecture_35.ViewModel;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MVVM_architecture_35.View
{
    public partial class GameGUI : Form
    {
        private GameVM gameVM;
        public GameGUI(string email)
        {
            InitializeComponent();

            this.gameVM = new GameVM(email);
        }
    }
}
