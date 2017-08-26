using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Youtube.ViewModels.Base;

namespace Youtube.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            NavigationPage.SetHasNavigationBar(this,false);
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //var osVersionString = ViewModelLocator.Instance.Resolve<IOperatingSystemVersionProvider>()
            //    .GetOperatingSystemVersionString();

            //set theme for each device
        }
    }
}