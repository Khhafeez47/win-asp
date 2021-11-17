using System.Threading.Tasks;
using Abp.Application.Services;
using win-asp-core-iis.Sessions.Dto;

namespace win-asp-core-iis.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
