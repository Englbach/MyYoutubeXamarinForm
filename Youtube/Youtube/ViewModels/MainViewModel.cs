using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Youtube.Services;

namespace Youtube.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private MenuViewModel _menuViewModel;

        public MenuViewModel MenuViewModel
        {
            get { return _menuViewModel; }
            set
            {
                _menuViewModel = value;
                RaiseProtertyChanged(()=>MenuViewModel);
            }
        }

        public MainViewModel(MenuViewModel menuViewModel)
        {
            _menuViewModel = menuViewModel;
        }

        public override Task InitializeAsync(object navigationData)
        {
            return Task.WhenAll
            (
                _menuViewModel.InitializeAsync(navigationData),
                _navigationService.NavigateToAsync<HomeViewModel>()
            );
        }


    }
}
