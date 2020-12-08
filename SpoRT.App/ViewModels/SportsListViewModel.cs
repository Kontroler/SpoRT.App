using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using SpoRT.Domain.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SpoRT.App.ViewModels
{
    public class SportsListViewModel : MvxViewModel
    {
        private readonly ISportDomainManager _sportDomainManager;
        private readonly IMvxNavigationService _navigationService;

        public SportsListViewModel(ISportDomainManager sportDomainManager, IMvxNavigationService navigationService)
        {
            _sportDomainManager = sportDomainManager;
            _navigationService = navigationService;

            GetSportsCommand = new MvxCommand(() => Sports = MvxNotifyTask.Create(() => OnGetSportsCommand(), onException: ex => OnException(ex)));
        }

        public override Task Initialize()
        {
            GetSportsCommand.Execute();
            return base.Initialize();
        }

        public ICommand NavigateToSportCommand => new MvxAsyncCommand(OnNavigateToSportCommand);

        private async Task OnNavigateToSportCommand()
        {
            await _navigationService.Navigate<NewSportViewModel>();
        }

        public IMvxCommand GetSportsCommand { get; private set; }

        private MvxNotifyTask<IEnumerable<ItemSportViewModel>> _sports;

        public MvxNotifyTask<IEnumerable<ItemSportViewModel>> Sports
        {
            get => _sports;
            private set => SetProperty(ref _sports, value);
        }

        private async Task<IEnumerable<ItemSportViewModel>> OnGetSportsCommand()
        {
            var sports = await _sportDomainManager.GetAll();
            return sports.Select(sport => new ItemSportViewModel(sport));
        }

        private void OnException(Exception exception)
        {
            // log the handled exception!
        }
    }
}