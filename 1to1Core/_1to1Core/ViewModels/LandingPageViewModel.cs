using System;
using System.Diagnostics;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using _1to1Core.Views;

namespace _1to1Core
{
	public class LandingPageViewModel
	{
	    public ICommand GoSelectionPageCommand { get; set; }
	    public ObservableCollection<DeviceData> Objects { get; set; }
		public LandingPageViewModel()
		{
            // TODO: Can probably get rid of this - DV		
			this.Objects = new ObservableCollection<DeviceData>();

		    GoSelectionPageCommand = new Command(GoSelectionPage);
		}

	    private void GoSelectionPage(object obj)
	    {
	        App.NavigationPage.Navigation.PushAsync(new SelectionPage());

	    }

	}
}
