using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VoorbeeldGit
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // Dit is mijn mainpage
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
