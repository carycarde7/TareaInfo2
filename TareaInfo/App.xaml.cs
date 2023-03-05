using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaInfo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new VIews.PageInfo());
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
