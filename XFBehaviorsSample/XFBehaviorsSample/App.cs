using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XFBehaviorsSample.Views;

namespace XFBehaviorsSample
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            XFBehaviors.XFBehaviors.Init();
            MainPage = new NavigationPage(new MainPage());
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
