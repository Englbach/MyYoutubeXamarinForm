using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Prism.Services;
using Youtube.Annotations;
using Youtube.Services.Interfaces;
using Youtube.ViewModels.Base;

namespace Youtube.ViewModels
{
    public abstract class ViewModelBase : ExtendedBindableObject
    {
        protected readonly INavigationService _navigationService;
        protected readonly IDialogService _dialogService;

        private bool _isBusy;

        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                RaiseProtertyChanged(() => _isBusy);
            }
        }

        public ViewModelBase()
        {
            _navigationService = ViewModelLocator.Instance.Resolve<INavigationService>();
            _dialogService = ViewModelLocator.Instance.Resolve<IDialogService>();
        }

        public virtual Task InitializeAsync(object navigationData)
        {
            return  Task.FromResult(false);
        }
    }
}
