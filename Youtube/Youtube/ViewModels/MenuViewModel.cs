using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Youtube.DataServices.Interfaces;
using Youtube.Models.Enums;
using Youtube.Models.Users;
using MenuItem = Youtube.Models.MenuItem;

namespace Youtube.ViewModels
{
    public class MenuViewModel : ViewModelBase
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IProfileService _profileService;

        public ICommand ItemSelectedCommand =>  new Command<MenuItem>(OnSelectedItem);
        public ICommand LogoutCommand => new Command(OnLogout);


        ObservableCollection<MenuItem> menuItems=new ObservableCollection<MenuItem>();

        public MenuViewModel(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }
        public ObservableCollection<MenuItem> MenuItems
        {
            get { return menuItems; }
            set
            {
                menuItems = value;
                RaiseProtertyChanged(()=>MenuItems);
            }
        }

        private UserProfile _profile;

        public UserProfile profile
        {
            get { return profile; }
            set
            {
                profile = value;
                RaiseProtertyChanged(()=>profile);
            }
        }

        public MenuViewModel(IProfileService profileService, IAuthenticationService authenticationService)
        {
            _profileService = profileService;
            _authenticationService = authenticationService;

            InitMenuItem();
        }

        private async void OnSelectedItem(MenuItem item)
        {
            if (item.IsEnabled)
            {
                object parameter = null;

                await _navigationService.NavigateToAsync(item.ViewModelType, parameter);
            }
        }

        private async void OnLogout()
        {
            await _authenticationService.LogoutAsync();
            await _navigationService.NavigateToAsync<LoginViewModel>();
        }

        private void InitMenuItem()
        {
            MenuItems.Add((new MenuItem
            {
                Title = "Home",
                MenuItemType = MenuItemType.Home,
                ViewModelType = typeof(HomeViewModel),
                IsEnabled = true
            }));

            if (_authenticationService.isAuthenticated)
            {
                MenuItems.Add((new MenuItem
                {
                    Title = "Playlist",
                    MenuItemType = MenuItemType.Playlist,
                    ViewModelType = typeof(HomeViewModel),
                    IsEnabled = true
                }));

                MenuItems.Add((new MenuItem
                {
                    Title = "Watch Later",
                    MenuItemType = MenuItemType.WatchLater,
                    ViewModelType = typeof(HomeViewModel),
                    IsEnabled = true
                }));

                MenuItems.Add((new MenuItem
                {
                    Title = "Upload",
                    MenuItemType = MenuItemType.Upload,
                    ViewModelType = typeof(HomeViewModel),
                    IsEnabled = true
                }));

                MenuItems.Add((new MenuItem
                {
                    Title = "History",
                    MenuItemType = MenuItemType.History,
                    ViewModelType = typeof(HomeViewModel),
                    IsEnabled = true
                }));
            }

            MenuItems.Add((new MenuItem
            {
                Title = "Music",
                MenuItemType = MenuItemType.Music,
                ViewModelType = typeof(HomeViewModel),
                IsEnabled = true
            }));

            MenuItems.Add((new MenuItem
            {
                Title = "Sport",
                MenuItemType = MenuItemType.Sport,
                ViewModelType = typeof(HomeViewModel),
                IsEnabled = true
            }));

            MenuItems.Add((new MenuItem
            {
                Title = "News",
                MenuItemType = MenuItemType.News,
                ViewModelType = typeof(HomeViewModel),
                IsEnabled = true
            }));

            MenuItems.Add((new MenuItem
            {
                Title = "Video 360",
                MenuItemType = MenuItemType.Video360,
                ViewModelType = typeof(HomeViewModel),
                IsEnabled = true
            }));


        }

        private async void OnProfileUpdated(UserProfile profile)
        {
            this.profile = null;

            if (Device.OS == TargetPlatform.Windows)
            {
                await Task.Delay(2000); // Give UWP enough time (for Photo reload)
            }

            this.profile = profile;
        }
    }

    
}
