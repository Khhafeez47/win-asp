using System.Threading.Tasks;
using Abp.Application.Services;
using win-asp-core-iis.Authorization.Accounts.Dto;

namespace win-asp-core-iis.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
