using System.Threading.Tasks;
using Abp.Application.Services;
using RaymondYuSolution.Authorization.Accounts.Dto;

namespace RaymondYuSolution.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
