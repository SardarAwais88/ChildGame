using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChildGame
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

             MainPage = new MainPage();
            //MainPage = new EnterPage();
            //  MainPage = new ButtonAlphabet();
           // MainPage = new CurrentWeatherPage();
            //  MainPage = new Games();
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
