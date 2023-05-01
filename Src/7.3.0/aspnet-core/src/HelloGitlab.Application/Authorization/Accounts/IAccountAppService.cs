using System.Threading.Tasks;
using Abp.Application.Services;
using HelloGitlab.Authorization.Accounts.Dto;

namespace HelloGitlab.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
