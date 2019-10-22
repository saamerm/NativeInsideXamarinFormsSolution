using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NativeInsideForms
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            var label = new Label();
#if __IOS__
            label.Text = "iOS";
#elif __DROID__
            label.Text = "Droid";
#endif
            var button = new Button()
            {
                Text = "Open Page"
            };
            button.Pressed += Button_Pressed;
            var stackLayout = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            stackLayout.Children.Add(label);
            stackLayout.Children.Add(button);
            Content = stackLayout;

        }

        private void Button_Pressed(object sender, EventArgs e)
        {
            App.OpenPage();
            // Open a page
        }
    }
}
