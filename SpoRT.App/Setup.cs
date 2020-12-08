using Android.App;
using Android.Runtime;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Views;
using System;

namespace SpoRT.App
{
    [Application]
    public class Setup : MvxAndroidApplication<MvxAndroidSetup<App>, App>
    {
        public Setup(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {          
        }


        //protected override IEnumerable<Assembly> AndroidViewAssemblies
        //{
        //    get
        //    {
        //        var assemblies = base.AndroidViewAssemblies.ToList();
        //        assemblies.Add(typeof(FloatingActionButton).Assembly);
        //        assemblies.Add(typeof(TextInputEditText).Assembly);
        //        return assemblies;
        //    }
        //}
    }
}