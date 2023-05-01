using System.Collections.Generic;
using HelloGitlab.Roles.Dto;

namespace HelloGitlab.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}