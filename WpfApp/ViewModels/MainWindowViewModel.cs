using System.Collections.ObjectModel;
using Bll.Interfaces;
using Dto;
using WpfApp.Models;
using WpfApp.ViewModels.Abstract;
using WpfApp.Views;

namespace WpfApp.ViewModels
{
    public class MainWindowViewModel : NotifyPropertyChangedHelper
    {
        private readonly IAdminService<UserDto> _adminService;
        private readonly IUserRegistrationService _userRegistrationService;
        private readonly IAttrValidationService _attrValidationService;

        private TabItem _selectedTab;

        public ObservableCollection<TabItem> TabItems { get; set; }


        public TabItem SelectedTab {
            get => _selectedTab;
            set => SetField(ref _selectedTab, value);
        }


        public MainWindowViewModel(IAdminService<UserDto> adminService, IUserRegistrationService userRegistrationService, IAttrValidationService attrValidationService)
        {
            _adminService = adminService;
            _userRegistrationService = userRegistrationService;
            _attrValidationService = attrValidationService;

            TabItems = new ObservableCollection<TabItem>()
            {
                new TabItem() {
                    Header = "User List",
                    Content = new UserListControl() { DataContext = new UserListViewModel(_adminService, attrValidationService, _userRegistrationService)} },
                new TabItem() {
                    Header = "Register",
                    Content = new RegistartionControl() { DataContext = new RegistrationViewModel(_userRegistrationService, _attrValidationService)} }
            };

            SelectedTab = TabItems[0];
        }
    }
}
