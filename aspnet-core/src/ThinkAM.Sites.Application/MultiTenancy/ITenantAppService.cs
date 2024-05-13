using Abp.Application.Services;
using ThinkAM.Sites.MultiTenancy.Dto;

namespace ThinkAM.Sites.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

