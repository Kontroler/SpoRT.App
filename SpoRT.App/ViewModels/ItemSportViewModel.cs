using MvvmCross.ViewModels;
using SpoRT.Domain.Models;

namespace SpoRT.App.ViewModels
{
    public class ItemSportViewModel : MvxViewModel
    {
        private Sport _sport;

        public Sport Sport
        {
            get => _sport;
            set => SetProperty(ref _sport, value);
        }

        public ItemSportViewModel(Sport sport)
        {
            Sport = sport;
        }
    }
}