using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileProgrammingA2_3
{
    public partial class App : Application
    {
        public static List<List<String>> list = new List<List<String>>();
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            
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
