using AppControles.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppControles
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DynamicControlsView();
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
