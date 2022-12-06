using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UACM
{
    public partial class App : Application
    {
        public App()
        {
           // InitializeComponent();

            MainPage = new NavigationPage ( new MainPage());
        }
        public static readonly Xamarin.Forms.BindableProperty BarBackgroundColorProperty;
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
