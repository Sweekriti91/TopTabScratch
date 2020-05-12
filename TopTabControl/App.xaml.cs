using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TopTabControl
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var page = new MainPage();

            MainPage = new NavigationPage(page);
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
