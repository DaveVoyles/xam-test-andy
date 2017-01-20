using System.Windows.Input;
using VitalTrax.Views;
using Xamarin.Forms;

namespace VitalTrax.View_Models
{
    public class MenuPageViewModel
    {
        public ICommand GoHomeCommand { get; set; }
        public ICommand GoSecondCommand { get; set; }
        
        public MenuPageViewModel()
        {
            GoHomeCommand   = new Command(GoHome);
            GoSecondCommand = new Command(GoSecond);
        }

        void GoHome(object obj)
        {
            App.NavigationPage.Navigation.PopToRootAsync();
            App.MenuIsPresented = false;
        }

        void GoSecond(object obj)
        {
            App.NavigationPage.Navigation.PushAsync(new SecondPage());
            App.MenuIsPresented = false;
        }
    }
}



