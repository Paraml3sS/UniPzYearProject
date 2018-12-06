using System;
using System.Windows.Forms;
using AutoMapper;
using Bll.Interfaces;
using Bll.Services;
using Bll.Settings;
using Dal.Interfaces;
using Dal.Repositories;
using Unity;
using WindowsFormsApp.Views;

namespace WindowsFormsApp
{
    static class Program
    {
        public static UnityContainer UnityContainer { get; private set; }
      
        [STAThread]
        static void Main()
        {
            ConfigureUnity();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var loginForm = UnityContainer.Resolve<LoginForm>();
            if (loginForm.ShowDialog() == DialogResult.OK) {
                Application.Run(UnityContainer.Resolve<UserListForm>());
            }
        }

        private static void ConfigureUnity()
        {
            UnityContainer = new UnityContainer();
            UnityContainer.RegisterType(typeof(IGeneralRepository<>), typeof(GeneralRepository<>));
            UnityContainer.RegisterType(typeof(IAdminService<>), typeof(AdminService<>));
            UnityContainer.RegisterType(typeof(IAuthenticationService), typeof(AuthenticationService));
            UnityContainer.RegisterType(typeof(IAuthorizationService), typeof(AuthorizationService));
            UnityContainer.RegisterType(typeof(IUserRegistrationService), typeof(UserRegistrationService));

            var config = new MapperConfiguration(cfg => cfg.AddProfile(new AutoMapperConfiguration()));
            UnityContainer.RegisterInstance<IMapper>(config.CreateMapper());
        }
    }
}
