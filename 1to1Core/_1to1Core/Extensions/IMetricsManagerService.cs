using System;
using System.Collections.Generic;
using System.Text;

namespace _1to1Core
{
    public interface IMetricsManagerService
    {
        void TrackEvent(string eventName);
    }
}
