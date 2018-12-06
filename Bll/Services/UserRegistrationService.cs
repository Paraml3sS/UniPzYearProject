using System;
using System.Linq;
using System.Security.Cryptography;
using AutoMapper;
using Bll.Interfaces;
using Dal.Interfaces;
using Domain.Models;
using Dto;

namespace Bll.Services
{
    public class UserRegistrationService : IUserRegistrationService
    {
        private readonly IGeneralRepository<User> _userRepository;
        private readonly IGeneralRepository<UserRole> _userRoleRepo;
        private readonly IMapper _mapper;

        public UserRegistrationService(IGeneralRepository<User> userRepository, IGeneralRepository<UserRole> userRoleRepo, IMapper mapper)
        {
            _userRepository = userRepository;
            _userRoleRepo = userRoleRepo;
            _mapper = mapper;
        }

        public void Register(UserDto user)
        {
            User domainUser = _mapper.Map<User>(user);
            domainUser.Password = GetHash(domainUser.Password);
            domainUser.AccountRegistered = DateTime.Now;
            

            _userRepository.Create(domainUser);

            var domainUserId = _userRepository.GetAll($"UserName='{domainUser.UserName}'").FirstOrDefault().UserId;
            _userRoleRepo.Create(new UserRole { UserId = domainUserId, RoleId = 4 });
        }

        public bool UserNameExist(string userName)
        {
            return _userRepository.GetAll($"UserName='{userName}'").FirstOrDefault() == null ? false : true;
        }

        public bool EmailExist(string emailAddress)
        {
            return _userRepository.GetAll($"EmailAddress='{emailAddress}'").FirstOrDefault() == null ? false : true;
        }

        public string GetHash(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            return Convert.ToBase64String(hashBytes);
        }
    }
}
