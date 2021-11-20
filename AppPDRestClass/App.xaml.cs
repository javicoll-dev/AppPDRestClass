using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPDRestClass
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new VistaDatos());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
