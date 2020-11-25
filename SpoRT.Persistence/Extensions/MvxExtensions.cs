using MvvmCross.IoC;
using SpoRT.Persistence.Managers;

namespace SpoRT.Persistence.Extensions
{
    public static class MvxExtensions
    {
        public static void RegisterPerstistence(this IMvxIoCProvider mvxIocProvider)
        {
            mvxIocProvider.RegisterType<ApplicationDbContext>();
            mvxIocProvider.RegisterType<ISportPersistenceManager, SportPersistenceManager>();
        }
    }
}