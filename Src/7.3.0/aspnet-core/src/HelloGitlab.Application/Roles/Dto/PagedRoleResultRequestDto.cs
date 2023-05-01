using Abp.Application.Services.Dto;

namespace HelloGitlab.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

