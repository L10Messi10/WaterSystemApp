using System;
using WaterSystemApp.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WaterSystemApp
{
    public partial class App
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
