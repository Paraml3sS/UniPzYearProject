using System;
using System.Windows.Input;
using WpfApp.Infrastructure;
using WpfApp.Infrastructure.Mediators.Interfaces;
using WpfApp.Models;
using WpfApp.ViewModels.Abstract;

namespace WpfApp.ViewModels
{
    public class EditDialogViewModel : NotifyPropertyChangedHelper, IDialogViewModel
    {
        private User _user;
        private bool _isEditComplete;

        private ICommand _saveCommand;
        private ICommand _closeCommand;

        public User User {
            get => _user;
            set => SetField(ref _user, value);
        }

        public bool IsEditComplete {
            get => _isEditComplete;
            set => SetField(ref _isEditComplete, value);
        }


        public EditDialogViewModel()
        {

        }

        public ICommand SaveCommand {
            get => _saveCommand ?? (_saveCommand = new RelayCommand(obj => {
                _isEditComplete = true;
                OnRequestClose();
            }));
        }

        public ICommand CloseCommand {
            get => _closeCommand ?? (_closeCommand = new RelayCommand(obj => {
                OnRequestClose();
            }));
        }

        public event EventHandler RequestClose;

        private void OnRequestClose()
        {
            this.RequestClose?.Invoke(this, EventArgs.Empty);
        }

    }
}
