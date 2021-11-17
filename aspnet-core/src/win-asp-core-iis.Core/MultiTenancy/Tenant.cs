using Abp.MultiTenancy;
using win-asp-core-iis.Authorization.Users;

namespace win-asp-core-iis.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
