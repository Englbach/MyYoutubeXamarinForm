using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Youtube.ViewModels;

namespace Youtube.Services.Interfaces
{
    public interface INavigationService
    {
        Task InitializeAsync();
        Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase;
        Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : ViewModelBase;
        Task NavigateToAsync(Type viewModelType);
        Task NavigateToAsync(Type viewModelType, object parameter);
        Task NavigateBackAsync();
        Task RemoveLastFromBackStackAsync();
    }
}
