using System.Collections.Generic;
using Dto;

namespace Bll.Interfaces
{
    public interface IAuthorizationService
    {
        IEnumerable<UserRoleDto> GetUserRoles(string userName);
    }
}
