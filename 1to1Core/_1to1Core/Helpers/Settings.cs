using System;
using System.Collections.Generic;
using System.Text;

namespace _1to1Core
{
    public static class Settings
    {
        // HockeyApp App IDs, we have one for each supported platform
#if WINDOWS_UWP
        public static string HockeyAppId = "1c52884e1fdf4977ba1e2ca004c0b59c";
#elif __ANDROID__
        public static string HockeyAppId = "3768986591c5474b935eba71cc2957ca";
#elif __IOS__
        public static string HockeyAppId = "368f3b4462bb4126b95d3444fee9d72b";
#endif

    }
}
