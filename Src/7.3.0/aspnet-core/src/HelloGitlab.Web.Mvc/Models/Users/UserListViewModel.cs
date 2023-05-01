using System.Collections.Generic;
using HelloGitlab.Roles.Dto;

namespace HelloGitlab.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
