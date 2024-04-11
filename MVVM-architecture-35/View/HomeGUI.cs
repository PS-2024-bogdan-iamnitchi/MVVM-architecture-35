using MVVM_architecture_35.ViewModel;
using System;
using System.Windows.Forms;

namespace MVVM_architecture_35.View
{
    public partial class HomeGUI : Form
    {
        private HomeVM homeVM;
        public HomeGUI(string email)
        {
            InitializeComponent();

            this.homeVM = new HomeVM(email);

            this.DataBindings.Add("Visible", this.homeVM, "isVisible", false, DataSourceUpdateMode.OnPropertyChanged);

            this.playGameButton.Click += delegate { homeVM.ToGameCommand.Execute(); };
            this.adminButton.Click += delegate { homeVM.ToEditPlayersCommand.Execute(); };
            this.signOutButton.Click += delegate { homeVM.SignOutCommand.Execute(); };

        }
    }
}
