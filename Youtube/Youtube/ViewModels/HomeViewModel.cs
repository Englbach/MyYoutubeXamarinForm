using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Youtube.DataServices.Interfaces;
using Youtube.Models;
using Youtube.Services;

namespace Youtube.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private ObservableCollection<TrendingModel.Root> _trendingRoots;
        private readonly ITrendingService _trendingService;


        public ObservableCollection<TrendingModel.Root> TrendingRoots
        {
            get { return _trendingRoots; }
            set
            {
                _trendingRoots = value;
                RaiseProtertyChanged(()=>TrendingRoots);
            }
        }
        public HomeViewModel(ITrendingService trendingService)
        {
            _trendingService = trendingService;
            _trendingRoots = new ObservableCollection<TrendingModel.Root>();
        }

        public async override Task InitializeAsync(object navigationData)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            IsBusy = true;

            try
            {
                var ridesResult = await _trendingService.GetTrending(0,null, "mostPopular");
                TrendingRoots = new ObservableCollection<TrendingModel.Root>(ridesResult);
            }
            catch (Exception ex) when (ex is WebException || ex is HttpRequestException)
            {
                await _dialogService.ShowAlertAsync(ex.Message, "Error", "Ok");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in: {ex}");
            }

            IsBusy = false;
        }
    }
}
