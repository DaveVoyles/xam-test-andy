using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace _1to1Core
{
	public class MenuPageViewModel {

		public ICommand GoHomeCommand { get; set; }
		public ICommand GoSettingsCommand { get; set; }

		public MenuPageViewModel() {
			GoHomeCommand     = new Command(GoHome);
			GoSettingsCommand = new Command(GoSettings);
		}

		void GoHome(object obj) {
			App.NavigationPage.Navigation.PopToRootAsync();
			App.MenuIsPresented = false;
		}

		void GoSettings(object obj) {
			App.NavigationPage.Navigation.PushAsync(new SettingsPage());
			App.MenuIsPresented = false;
		}
	}
}

