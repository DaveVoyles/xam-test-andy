using System;
using System.Windows.Input;
using Xamarin.Forms;
using _1to1Core.Views;

namespace _1to1Core
{
	public class MenuPageViewModel {

		public ICommand GoHomeCommand { get; set; }
		public ICommand GoWebViewCommand { get; set; }

		public MenuPageViewModel() {
			GoHomeCommand     = new Command(GoHome);
			GoWebViewCommand  = new Command(GoWebView);
		}

		void GoHome(object obj) {
			App.NavigationPage.Navigation.PopToRootAsync();
			App.MenuIsPresented = false;
		}

		void GoWebView(object obj) {
            App.NavigationPage.Navigation.PushAsync(new WebPageView());
            App.MenuIsPresented = false;
		}
	}
}

