using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using win-asp-core-iis.Roles.Dto;
using win-asp-core-iis.Users.Dto;

namespace win-asp-core-iis.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
