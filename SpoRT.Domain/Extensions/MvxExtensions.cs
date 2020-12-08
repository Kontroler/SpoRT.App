using AutoMapper;
using MvvmCross.IoC;
using SpoRT.Domain.Managers;
using SpoRT.Domain.Mapper;
using SpoRT.Persistence.Extensions;

namespace SpoRT.Domain.Extensions
{
    public static class MvxExtensions
    {
        public static void RegisterDomain(this IMvxIoCProvider mvxIocProvider)
        {
            mvxIocProvider.RegisterPerstistence();

            mvxIocProvider.RegisterType<ISportDomainManager, SportDomainManager>();

            mvxIocProvider.RegisterSingleton<IMapper>(GetMapper());
        }

        private static AutoMapper.Mapper GetMapper()
        {
            var config = new AutoMapper.MapperConfiguration(cfg => cfg.AddProfile(new AutoMapperProfile()));
            return new AutoMapper.Mapper(config);
        }
    }
}