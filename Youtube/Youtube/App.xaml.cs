using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Unity;
using Xamarin.Forms;
using Youtube.Helpers;
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
        private void AdaptColorsToHexString()
        {
            for (var i = 0; i < this.Resources.Count; i++)
            {
                var key = this.Resources.Keys.ElementAt(i);
                var resource = this.Resources[key];

                if (resource is Color)
                {
                    var color = (System.Drawing.Color)resource;
                    this.Resources.Add(key + "HexString",  color.ToHexString());
                }
            }
        }
    }
}
