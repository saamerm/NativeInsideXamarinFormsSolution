using System;
using NativeInsideForms.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(NativeNavigateService))]
namespace NativeInsideForms.Droid
{
    public class NativeNavigateService : INativeNavigationService
    {
        public NativeNavigateService()
        {
        }

        public void Navigate()
        {
            var activity = MainActivity.Instance;
            activity.StartActivity(typeof(TestActivity));
        }
    }
}
