using Abp.MultiTenancy;
using RaymondYuSolution.Authorization.Users;

namespace RaymondYuSolution.MultiTenancy
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
