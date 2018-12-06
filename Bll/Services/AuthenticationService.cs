using System;
using System.Linq;
using System.Security.Cryptography;
using Bll.Interfaces;
using Dal.Interfaces;
using Domain.Models;

namespace Bll.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IGeneralRepository<User> _userRepo;

        public AuthenticationService(IGeneralRepository<User> userRepository)
        {
            _userRepo = userRepository;
        }

        public bool Login(string userName, string password)
        {

            string savedPasswordHash = _userRepo.GetAll($"UserName='{userName}'").FirstOrDefault()?.Password;
            if (savedPasswordHash == null) return false;

            byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);

            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                    return false;
            }
            return true;
        }
    }
}
