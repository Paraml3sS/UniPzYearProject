using System.Collections.Generic;
using System.Linq;
using Dto;
using WpfApp.Models;

namespace WpfApp.Infrastructure
{
    internal static class Mapper
    {
        public static User Map(UserDto source)
        {
            return new User
            {
                UserId = source.UserId,
                FirstName = source.FirstName,
                LastName = source.LastName,
                UserName = source.UserName,
                Password = source.Password,
                AccountRegistered = source.AccountRegistered,
                EmailAddress = source.EmailAddress
            };
        }

        public static UserDto Map(User source)
        {
            return new UserDto
            {
                UserId = source.UserId,
                FirstName = source.FirstName,
                LastName = source.LastName,
                UserName = source.UserName,
                Password = source.Password,
                AccountRegistered = source.AccountRegistered,
                EmailAddress = source.EmailAddress
            };
        }

        public static List<User> Map(IEnumerable<UserDto> source)
        {
            return source.Select(src => Map(src)).ToList();
        }

        public static List<UserDto> Map(IEnumerable<User> source)
        {
            return source.Select(src => Map(src)).ToList();
        }

    }
}
