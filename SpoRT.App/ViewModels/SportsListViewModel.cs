using MvvmCross.ViewModels;
using SpoRT.Domain.Managers;

namespace SpoRT.App.ViewModels
{
    public class SportsListViewModel : MvxViewModel
    {
        private readonly ISportDomainManager _sportDomainManager;

        public SportsListViewModel(ISportDomainManager sportDomainManager)
        {
            _sportDomainManager = sportDomainManager;
        }

        //public async Task<IEnumerable<Sport>> GetAll() => await _sportDomainManager.GetAll();

        private string _text = "Test";

        public string Text
        {
            get => _text;
            set
            {
                SetProperty(ref _text, value);
                RaisePropertyChanged(() => Text);
            }
        }
    }
}