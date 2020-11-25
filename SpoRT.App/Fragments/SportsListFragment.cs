using Android.OS;
using Android.Runtime;
using Android.Views;
using Google.Android.Material.TextView;
using MvvmCross.Platforms.Android.Binding.BindingContext;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views.Fragments;
using SpoRT.App.ViewModels;

namespace SpoRT.App
{
    [MvxFragmentPresentation(typeof(MainViewModel), Resource.Id.content_frame)]
    [Register(nameof(SportsListFragment))]
    public class SportsListFragment : MvxFragment<SportsListViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            return this.BindingInflate(Resource.Layout.fragment_sports_list, null);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);           
        }

        public static SportsListFragment NewInstance() => new SportsListFragment();
    }
}