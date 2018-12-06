using AutoMapper;
using Domain.Models;
using Dto;

namespace Bll.Settings
{
    public class AutoMapperConfiguration : Profile
    {
        public void Configure()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserRole, UserRoleDto>();
            CreateMap<Role, RoleDto>();
        }
    }
}
