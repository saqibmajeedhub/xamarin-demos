#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
namespace SampleBrowser.SfAvatarView
{
    [Preserve(AllMembers = true)]
    public class App : Application
    {
        public App()
        {
            var page = SampleBrowser.Core.SampleBrowser.GetMainPage("SfAvatarView", "SampleBrowser.SfAvatarView");
            MainPage = page;
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
    public enum Platforms
    {
        UWP,
        Android,
        iOS
    }
}