using Dto;

namespace Bll.Interfaces
{
    public interface IUserRegistrationService
    {
        void Register(UserDto userDto);
        string GetHash(string password);
        bool UserNameExist(string userName);
        bool EmailExist(string emailAdress);
    }
}
