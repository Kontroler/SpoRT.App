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
    }
}