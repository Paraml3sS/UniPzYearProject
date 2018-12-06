using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Bll.Interfaces;
using Dal.Interfaces;
using Domain.Models;
using Dto;

namespace Bll.Services
{
    public class AdminService<TEntity> : IAdminService<UserDto>
    {
        private readonly IGeneralRepository<User> _userRepo;
        private readonly IGeneralRepository<UserRole> _userRoleRepo;
        private readonly IMapper _mapper;

        public AdminService(IGeneralRepository<User> userRepository, IGeneralRepository<UserRole> userRoleRepository, IMapper mapper)
        {
            _userRepo = userRepository;
            _userRoleRepo = userRoleRepository;
            _mapper = mapper;
        }

        public IEnumerable<UserDto> Get() => _mapper.Map<IEnumerable<UserDto>>(_userRepo.GetAll());

        public void Create(UserDto user)
        {
            _userRepo.Create(_mapper.Map<User>(user));
            _userRoleRepo.Create(new UserRole { UserId = user.UserId, RoleId = 5 });
        } 

        public void Update(long id, UserDto user) => _userRepo.Update(id, _mapper.Map<User>(user));

        public void Delete(long id)
        {
            _userRoleRepo.Delete($"UserId={id}");
            _userRepo.Delete(id);
        }

        public void AddUserRole(long userId, long roleId)
        {
            if (_userRoleRepo.GetAll($"UserId={userId} AND RoleId={roleId}").FirstOrDefault() == null)
            {
                _userRoleRepo.Create(new UserRole { UserId = userId, RoleId = roleId });
            }
        }

        public void DeleteUserRole(long userId, long roleId)
        {
            if (_userRoleRepo.GetAll($"UserId={userId} AND RoleId={roleId}").FirstOrDefault() != null)
            {
                var userRoleId = _userRoleRepo.GetAll($"UserId={userId} and RoleId={roleId}").FirstOrDefault().UserRoleId;
                _userRoleRepo.Delete(userRoleId);
            }
        }
    }
}
