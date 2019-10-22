using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NativeInsideForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static void OpenPage()
        {
            //INativeNavigationService service = DependencyService.Get<INativeNavigationService>();
            //Device.BeginInvokeOnMainThread(() => service.Navigate());
        }
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
