using Abp.AutoMapper;
using win-asp-core-iis.Authentication.External;

namespace win-asp-core-iis.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
