using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

using HockeyApp;

[assembly: Xamarin.Forms.Dependency(typeof(_1to1Core.iOS.MetricsManagerService))]
namespace _1to1Core.iOS
{
    class MetricsManagerService : IMetricsManagerService
    {
        public void TrackEvent(string eventName)
        {
            MetricsManager.TrackEvent(eventName);
        }
    }
}