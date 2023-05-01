using Abp.Application.Services;
using HelloGitlab.MultiTenancy.Dto;

namespace HelloGitlab.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

