using MvvmCross.IoC;
using SpoRT.Domain.Managers;
using SpoRT.Persistence.Extensions;

namespace SpoRT.Domain.Extensions
{
    public static class MvxExtensions
    {
        public static void RegisterDomain(this IMvxIoCProvider mvxIocProvider)
        {
            mvxIocProvider.RegisterPerstistence();
            mvxIocProvider.RegisterType<ISportDomainManager, SportDomainManager>();
        }
    }
}