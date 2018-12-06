using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Input;
using Bll.Interfaces;
using Dto;
using WpfApp.Infrastructure;
using WpfApp.Infrastructure.Mediators;
using WpfApp.Models;
using WpfApp.ViewModels.Abstract;

namespace WpfApp.ViewModels
{
    public class UserListViewModel : NotifyPropertyChangedHelper
    {
        #region Fields

        private readonly IAdminService<UserDto> _adminService;
        private readonly IAttrValidationService _attrValidationService;
        private readonly IUserRegistrationService _userRegistrationService;
        private readonly ICollectionView _userView;

        private ObservableCollection<User> _usersCollection;
        private string _searchTextBoxValue;
        private User _selectedUser;
   
        private ICommand _refreshCommand;
        private ICommand _deleteCommand;
        private ICommand _updateCommand;

        #endregion

        #region Properties

        public ICollectionView UserView => _userView;
        #endregion

        #region Binding members

        public string SearchTextboxValue {
            get => _searchTextBoxValue;
            set {
                SetField(ref _searchTextBoxValue, value);
                UserView.Refresh();
            } 
        }

        public User SelectedUser {
            get => _selectedUser;
            set => SetField(ref _selectedUser, value);
        }

        public ObservableCollection<User> UsersCollection {
            get => _usersCollection;
            set => SetField(ref _usersCollection, value);
        }

        #endregion

        public UserListViewModel(IAdminService<UserDto> adminService, IAttrValidationService attrValidationService, IUserRegistrationService userRegistrationService)
        {
            _adminService = adminService;
            _attrValidationService = attrValidationService;
            _userRegistrationService = userRegistrationService;

            var users = Mapper.Map(_adminService.Get());
            UsersCollection = new ObservableCollection<User>(users);
            _userView = CollectionViewSource.GetDefaultView(UsersCollection);

            _userView.Filter += UserViewFilter;
        }

        private bool UserViewFilter(object entity)
        {
            var user = entity as User;
            return String.IsNullOrEmpty(SearchTextboxValue) ? true :
                $"{user.FirstName}{user.LastName}".ToLower().Contains(SearchTextboxValue.ToLower());
        }


        #region Commands

        public ICommand RefreshCommand {
            get => _refreshCommand ?? (_refreshCommand = new RelayCommand(obj => {

                var users = Mapper.Map(_adminService.Get());
                UsersCollection.Clear();

                foreach (var user in users)
                {
                    UsersCollection.Add(user);
                }
            }));
        }

        public ICommand DeleteCommand {
            get => _deleteCommand ?? (_deleteCommand = new RelayCommand(obj => {
                var chosenUser = obj as User;
                _adminService.Delete(chosenUser.UserId);
                UsersCollection.Remove(chosenUser);
            }));
        }

        public ICommand UpdateCommand {
            get => _updateCommand ?? (_updateCommand = new RelayCommand(obj => {

                var dlg = new EditUserDialogDirector(SelectedUser.Clone() as User);
                var indexOfUser = UsersCollection.IndexOf(SelectedUser);

                if (dlg.ShowDialog() == true)
                {
                    var editedUser = dlg.Result.User;

                    if (new UserValidation(_attrValidationService).IsValidUser(editedUser, true))
                    {
                        UsersCollection[indexOfUser] = editedUser;
                        _adminService.Update(editedUser.UserId, Mapper.Map(editedUser));
                    }
                }
            }));
        }

        #endregion
    }
}
