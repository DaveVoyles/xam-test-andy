using Xamarin.Forms;

namespace _1to1Core
{
	public partial class App : Application
	{

		/// <summary>
		/// Default name given by the framework
		/// </summary>
		/// <value>First page loaded when app starts</value>
        public static NavigationPage NavigationPage { get; private set; }
		/// <summary>
		/// Master container to hold nav + pages
		/// </summary>
        private static RootPage RootPage;
        public static bool MenuIsPresented
        {
            get
            {
                return RootPage.IsPresented;
            }
            set
            {
                RootPage.IsPresented = value;
            }
        }

        public App()
        {
            InitializeComponent();

            var menuPage 	= new MenuPage();

			// This page is the first thing loaded
            NavigationPage 	= new NavigationPage(new LandingPage());

			// Master container to hold everything
            RootPage 		= new RootPage();
            RootPage.Master = menuPage;

			// Load landing page as soon as app starts
            RootPage.Detail = NavigationPage;
            MainPage 	    = RootPage;

            // Hockeyapp
            DependencyService.Get<IMetricsManagerService>().TrackEvent("AppStarted");
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
