using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Flying_Cow_TMS.Authorization.Users;
using Flying_Cow_TMS.Editions;

namespace Flying_Cow_TMS.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
