/* Dave Voyles, Microsoft Corp. 2016
 * www.Dave Voyles.com | Twitter.com/DaveVoyles
 */
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace _1to1Core
{
	public partial class DetailsPage : ContentPage
	{
		public DetailsPage(ObservableCollection<DeviceData> ocDeviceData)
		{
			InitializeComponent();

			// Set static device data from Landing Page to the listview 
			var lv 			   = this.FindByName<ListView>("listView");
			    lv.ItemsSource = ocDeviceData;
		}

		/// <summary>
		/// When we tap an item in the list do [INSERT SOMETHING AWESOME HERE]
		/// </summary>
		void OnItemTapped(object sender, ItemTappedEventArgs e)
		{
			if (e == null) return; 					// has been set to null, do not 'process' tapped event'
			((ListView)sender).SelectedItem = null; // de-select the row
		}

	}
}
