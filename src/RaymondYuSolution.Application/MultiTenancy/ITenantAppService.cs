using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RaymondYuSolution.MultiTenancy.Dto;

namespace RaymondYuSolution.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

