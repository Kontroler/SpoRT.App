using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace SpoRT.App.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public MainViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public MvxAsyncCommand NavigateToSportListCommand() => new MvxAsyncCommand(OnNavigateToSportListCommand);

        private async Task OnNavigateToSportListCommand()
        {
            await _navigationService.Navigate<SportsListViewModel>();
        }
    }
}