using MVVM_architecture_35.ViewModel;
using System;
using System.Windows.Forms;

namespace MVVM_architecture_35.View
{
    public partial class EditPlayersGUI : Form
    {
        private EditPlayersVM editPlayersVM;
        public EditPlayersGUI(string loggedInPlayerEmail)
        {
            InitializeComponent();
            this.playersDataGridView.AllowUserToAddRows = false;
            for (int i = 0; i < playersDataGridView.ColumnCount; i++)
                this.playersDataGridView.Columns[i].ReadOnly = true;

            this.editPlayersVM = new EditPlayersVM(loggedInPlayerEmail);

            this.nudPlayerID.DataBindings.Add("Value", this.editPlayersVM, "playerID", false, DataSourceUpdateMode.OnPropertyChanged);
            this.fullNameTextBox.DataBindings.Add("Text", this.editPlayersVM, "fullName", false, DataSourceUpdateMode.OnPropertyChanged);
            this.emailTextBox.DataBindings.Add("Text", this.editPlayersVM, "email", false, DataSourceUpdateMode.OnPropertyChanged);
            this.nudAge.DataBindings.Add("Value", this.editPlayersVM, "age", false, DataSourceUpdateMode.OnPropertyChanged);
            this.passwordTextBox.DataBindings.Add("Text", this.editPlayersVM, "password", false, DataSourceUpdateMode.OnPropertyChanged);
            this.DataBindings.Add("Visible", this.editPlayersVM, "isVisible", false, DataSourceUpdateMode.OnPropertyChanged);

            this.playersDataGridView.DataSource = this.editPlayersVM.PlayersTable;

            this.addButton.Click += delegate { editPlayersVM.AddCommand.Execute(); };
            this.updateButton.Click += delegate { editPlayersVM.UpdateCommand.Execute(); };
            this.deleteButton.Click += delegate { editPlayersVM.DeleteCommand.Execute(); };

            this.loadButton.Click += delegate { editPlayersVM.LoadCommand.Execute(); };
            this.searchButton.Click += delegate { editPlayersVM.SearchCommand.Execute(); };
            this.backButton.Click += delegate { editPlayersVM.ToHomeCommand.Execute(); };

        }
    }
}
