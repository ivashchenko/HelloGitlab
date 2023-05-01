using System.Threading.Tasks;
using Abp.Application.Services;
using HelloGitlab.Sessions.Dto;

namespace HelloGitlab.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
