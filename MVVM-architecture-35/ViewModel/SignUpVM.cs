﻿using MVVM_architecture_35.ViewModel.Commands.LoginCommands;
using MVVM_architecture_35.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_architecture_35.ViewModel.Commands.SignUpCommands;
using System.Windows.Forms;

namespace MVVM_architecture_35.ViewModel
{
    public class SignUpVM : INotifyPropertyChanged
    {
        private string fullName;
        private string email;
        private int age;
        private string password;
        private bool isVisible;
        public IComand SignUpCommand;
        public IComand ClearCommand;
        public IComand ToLoginCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        public SignUpVM()
        {
            this.fullName = "";
            this.email = "";
            this.age = 0;
            this.password = "";
            this.isVisible = true;
            this.SignUpCommand = new SignUpCommand(this);
            this.ClearCommand = new Commands.SignUpCommands.ClearCommand(this);
            this.ToLoginCommand = new ToLoginCommand(this);
        }

        public string FullName
        {
            get { return this.fullName; }
            set
            {
                this.fullName = value;
                OnPropertyChanged(nameof(FullName));
            }
        }
        public string Email
        {
            get { return this.email; }
            set
            {
                this.email = value;
                OnPropertyChanged(nameof(Email));
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                this.age = value;
                OnPropertyChanged(nameof(Age));
            }
        }
        public string Password
        {
            get { return this.password; }
            set
            {
                this.password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public bool IsVisible
        {
            get { return this.isVisible; }
            set
            {
                this.isVisible = value;
                OnPropertyChanged(nameof(IsVisible));
            }
        }

        public void SetMessage(string title, string message)
        {
            MessageBox.Show(message, title);
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
