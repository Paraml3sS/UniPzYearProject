using System.Windows;
using AutoMapper;
using Bll.Interfaces;
using Bll.Services;
using Bll.Settings;
using Dal.Interfaces;
using Dal.Repositories;
using Unity;
using WpfApp.Views;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static UnityContainer UnityContainer { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ConfigureUnity();
            Current.MainWindow = UnityContainer.Resolve<MainWindow>();
            Current.MainWindow.Show();
        }

        private static void ConfigureUnity()
        {
            UnityContainer = new UnityContainer();
            UnityContainer.RegisterType(typeof(IGeneralRepository<>), typeof(GeneralRepository<>));
            UnityContainer.RegisterType(typeof(IAdminService<>), typeof(AdminService<>));
            UnityContainer.RegisterType(typeof(IAuthenticationService), typeof(AuthenticationService));
            UnityContainer.RegisterType(typeof(IAuthorizationService), typeof(AuthorizationService));
            UnityContainer.RegisterType(typeof(IUserRegistrationService), typeof(UserRegistrationService));
            UnityContainer.RegisterType(typeof(IAttrValidationService), typeof(AttrValidationService));

            var config = new MapperConfiguration(cfg => cfg.AddProfile(new AutoMapperConfiguration()));
            UnityContainer.RegisterInstance<IMapper>(config.CreateMapper());
        }
    }
}
