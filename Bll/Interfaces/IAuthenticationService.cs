namespace Bll.Interfaces
{
    public interface IAuthenticationService
    {
        bool Login(string userName, string password);
    }
}
