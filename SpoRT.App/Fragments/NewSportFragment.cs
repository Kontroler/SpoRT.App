using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Platforms.Android.Binding.BindingContext;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views.Fragments;
using SpoRT.App.ViewModels;

namespace SpoRT.App.Fragments
{
    [MvxFragmentPresentation(typeof(MainViewModel), Resource.Id.content_frame)]
    [Register(nameof(NewSportFragment))]
    public class NewSportFragment : MvxFragment<NewSportViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            return this.BindingInflate(Resource.Layout.fragment_new_sport, null);
        }

        public override void OnPause()
        {
            ViewModel.OnError -= ShowToast;
            base.OnPause();
        }

        public override void OnResume()
        {
            ViewModel.OnError += ShowToast;
            base.OnResume();
        }

        private void ShowToast(object sender, string error)
        {
            Toast.MakeText(RequireContext(), error, ToastLength.Long).Show();
        }
    }
}