using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prism.Unity;
using Xamarin.Forms;

namespace Youtube
{
    public partial class App : PrismApplication
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Youtube.MainPage();
        }

       

        protected override void OnInitialized()
        {
            throw new NotImplementedException();
        }

        protected override void RegisterTypes()
        {
            throw new NotImplementedException();
        }

  
    }
}
