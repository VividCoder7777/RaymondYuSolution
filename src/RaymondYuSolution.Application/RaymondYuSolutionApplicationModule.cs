using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RaymondYuSolution.Authorization;

namespace RaymondYuSolution
{
    [DependsOn(
        typeof(RaymondYuSolutionCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class RaymondYuSolutionApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<RaymondYuSolutionAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(RaymondYuSolutionApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
