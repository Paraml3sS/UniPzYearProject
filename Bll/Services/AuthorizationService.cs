using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Bll.Interfaces;
using Dal.Interfaces;
using Domain.Models;
using Dto;

namespace Bll.Services
{
    public class AuthorizationService : IAuthorizationService
    {
        private readonly IGeneralRepository<UserRole> _userRoleRepo;
        private readonly IGeneralRepository<User> _userRepo;
        private readonly IMapper _mapper;

        public AuthorizationService(IGeneralRepository<UserRole> userRoleRepo, IGeneralRepository<User> userRepo, IMapper mapper)
        {
            _userRoleRepo = userRoleRepo;
            _userRepo = userRepo;
            _mapper = mapper;
        }

        public IEnumerable<UserRoleDto> GetUserRoles(string userName)
        {
            var user = _userRepo.GetAll($"UserName='{userName}'");
            return _mapper.Map<IEnumerable<UserRoleDto>>(_userRoleRepo.GetAll($"UserId={user.FirstOrDefault().UserId}"));
        }
    }
}
