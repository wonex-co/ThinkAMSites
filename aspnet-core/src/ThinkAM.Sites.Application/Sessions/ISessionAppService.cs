using System.Threading.Tasks;
using Abp.Application.Services;
using ThinkAM.Sites.Sessions.Dto;

namespace ThinkAM.Sites.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
