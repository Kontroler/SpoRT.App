using Android.OS;
using Android.Views;
using AndroidX.Fragment.App;

namespace SpoRT.App
{
    public class SportsListFragment : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            return inflater.Inflate(Resource.Layout.fragment_sports_list, container, false);
        }

        public static SportsListFragment NewInstance() => new SportsListFragment();
    }
}