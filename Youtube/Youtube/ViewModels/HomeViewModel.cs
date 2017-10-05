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
        private ObservableCollection<TrendingModel.RootObject> _trendingRoots;
        private readonly ITrendingService _trendingService;


        public ObservableCollection<TrendingModel.RootObject> TrendingRoots
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
            //TrendingRoots = new ObservableCollection<TrendingModel.RootObject>();
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
                TrendingRoots = new ObservableCollection<TrendingModel.RootObject>(ridesResult);
               
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

        private TrendingModel.Item _selectedItem;

        public TrendingModel.Item SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                NavigateToVideoDetail(_selectedItem.id);
                RaiseProtertyChanged(()=>SelectedItem);
            }
        }

        private async void NavigateToVideoDetail(string parameter)
        {
            if (parameter != null)
            {
                await _navigationService.NavigateToAsync(typeof(VideoViewModel), parameter);
            }
        }
    }
}
