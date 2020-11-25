using MvvmCross;
using MvvmCross.ViewModels;
using SpoRT.App.ViewModels;
using SpoRT.Domain.Extensions;

namespace SpoRT.App
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterDomain();
            RegisterAppStart<MainViewModel>();
        }
    }
}