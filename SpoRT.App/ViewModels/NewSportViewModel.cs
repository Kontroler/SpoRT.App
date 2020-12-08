using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using SpoRT.Domain.Managers;
using SpoRT.Domain.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SpoRT.App.ViewModels
{
    public class NewSportViewModel : MvxViewModel
    {
        private readonly ISportDomainManager _sportDomainManager;
        private readonly IMvxNavigationService _navigationService;

        public NewSportViewModel(ISportDomainManager sportDomainManager, IMvxNavigationService navigationService)
        {
            _sportDomainManager = sportDomainManager;
            _navigationService = navigationService;
        }

        private string _sportName;

        public string SportName
        {
            get => _sportName;
            set
            {
                _sportName = value;
                RaisePropertyChanged(() => SportName);
            }
        }

        public ICommand SaveCommand => new MvxAsyncCommand(OnSaveCommand);

        public async Task OnSaveCommand()
        {
            if (string.IsNullOrWhiteSpace(_sportName))
            {
                OnError?.Invoke(this, "Sport name is empty.");
                return;
            }

            await SaveSport();
            await CloseViewModel();
        }

        private async Task SaveSport()
        {
            try
            {
                {
                    var sport = new Sport(_sportName);
                    await _sportDomainManager.Save(sport);
                }
            }
            catch (Exception ex)
            {
                OnError?.Invoke(this, ex.ToString());
            }
        }

        public event EventHandler<string> OnError;

        private async Task CloseViewModel()
        {
            await _navigationService.Close(this);
        }
    }
}