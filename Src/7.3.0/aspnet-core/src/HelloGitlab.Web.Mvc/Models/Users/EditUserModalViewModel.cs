using System.Collections.Generic;
using System.Linq;
using HelloGitlab.Roles.Dto;
using HelloGitlab.Users.Dto;

namespace HelloGitlab.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}
