using System.Collections.Generic;
using HelloGitlab.Roles.Dto;

namespace HelloGitlab.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
