using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Services;
using Xamarin.Forms;
using Youtube.DataServices.Base;
using Youtube.DataServices.Interfaces;
using Youtube.Services;
using Youtube.Services.Interfaces;

namespace Youtube.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IDialogService _dialogService;

        
        public LoginViewModel(IAuthenticationService authenticationService, IDialogService dialogService)
        {
            _authenticationService = authenticationService;
            _dialogService = dialogService;
        }

        public ICommand SignInCommand => new Command(SignInAsync);

        private async void SignInAsync()
        {
            IsBusy = true;
            bool isAuthentication = false;

            try
            {
                isAuthentication = await _authenticationService.LoginAsync();
            }
            catch (ServiceAuthenticationException)
            {
                await _dialogService.ShowAlertAsync("Login failure", "Invalid credentials", "OK");
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }

            if (isAuthentication)
            {
                await _navigationService.NavigateToAsync<MainViewModel>();
            }

            IsBusy = false;
        }


    }
}
