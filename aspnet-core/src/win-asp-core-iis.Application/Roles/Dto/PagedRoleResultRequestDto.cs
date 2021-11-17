using Abp.Application.Services.Dto;

namespace win-asp-core-iis.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

