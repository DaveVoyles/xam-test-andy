/*
 * To push a new page onto the stack (from your MenuPage):
 *      App.NavigationPage.Navigation.PushAsync(PAGE);
 *      
 * Or pop a page off the stack (from your MenuPage):
 *      App.NavigationPage.Navigation.PopAsync();
 *      
 *  Docs: https://wolfprogrammer.com/2016/09/02/creating-a-hamburger-menu-in-xamarin-forms/
 *  
 */

using System.Diagnostics;
using Xamarin.Forms;

namespace VitalTrax
{
    public partial class App : Application
    {
        private static RootPage RootPage;
        public static NavigationPage NavigationPage { get; private set; }
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
            Debug.WriteLine("CREATING APP PAGE" +
                            "/n " +
                            "/n " +
                            "/n" +
                            "/n" +
                            "/n" +
                            "--------------------");
            InitializeComponent();

            //MainPage        = new TodoList();

            // The root page of your application
            var menuPage = new MenuPage();

            // The NavigationPage becomes your navigation stack. 
            //NavigationPage = new NavigationPage(new TodoList());
            NavigationPage = new NavigationPage(new HomePage());

            var RootPage        = new RootPage();
                RootPage.Master = menuPage;
                RootPage.Detail = NavigationPage;

            MainPage = RootPage;
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

