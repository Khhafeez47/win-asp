using Abp.Application.Services;
using win-asp-core-iis.MultiTenancy.Dto;

namespace win-asp-core-iis.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

