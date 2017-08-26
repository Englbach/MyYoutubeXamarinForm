using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Unity;
using Xamarin.Forms;
using Youtube.Services;
using Youtube.Services.Interfaces;
using Youtube.ViewModels.Base;

namespace Youtube
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (Device.OS == TargetPlatform.Windows)
            {
                InitNavigation();
            }
        }

        protected override async void OnStart()
        {
            base.OnStart();

            if (Device.OS != TargetPlatform.Windows)
            {
                await InitNavigation();
            }
        }

        private Task InitNavigation()
        {
            var navigationService = ViewModelLocator.Instance.Resolve<INavigationService>();
            return navigationService.InitializeAsync();
        }
    }
}
