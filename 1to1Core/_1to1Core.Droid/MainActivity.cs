using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using HockeyApp.Android;
using HockeyApp.Android.Metrics;

namespace _1to1Core.Droid
{
	[Activity (Label = "Finaeos 1to1Core", Theme = "@style/MainTheme", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
		protected override void OnCreate (Bundle bundle)
		{
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate (bundle);

            CrashManager.Register(this, Settings.HockeyAppId);

            MetricsManager.Register(Application, Settings.HockeyAppId);
            // If HockeyApp is not reporting metrics for Android, please uncomment the following line
            //MetricsManager.EnableUserMetrics();  // Need to see if Paul is right and this is required

            global::Xamarin.Forms.Forms.Init (this, bundle);
			LoadApplication (new _1to1Core.App ());
		}
	}
}

