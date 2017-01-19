/**
 * I typically use this page for handling navigation. The LandingPageView.xaml can access all 
 * of the public properties / methods from here as well. 
 * @DaveVoyles - Microsoft Corp, 2017
 */
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using RestSharp;
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
		    GoSelectionPageCommand = new Command(GoSelectionPage);

            // TODO: Uncomment this when we have the VitalTrax endpoint
            //var webRequest = new WebRequest();
            //    webRequest.makeWebRequest(webRequest._endPoint, webRequest._requestUrl);

            // DEBUG: Test to illustrate that we can make web requests
            makeStarWarsWebRequest();
		}


        // ----------------------------------------------------------------------------
        // DUMMY DATA FOR TESTING WEB REQUESTS 

	    private  StarWarsObject _starWarsObject;

        /// <summary>
        /// Retrieve JSON data from http request
        /// </summary>
        public void makeStarWarsWebRequest()
        {
            var client  = new RestClient("http://swapi.co/api/");
            var request = new RestRequest("people/1", Method.GET);

            // Automatically deserialize result
            IRestResponse<StarWarsObject> response = client.Execute<StarWarsObject>(request);
            _starWarsObject                        = response.Data;

            Debug.WriteLine(_starWarsObject);
        }






        // Navigate to the selection page
        private void GoSelectionPage(object obj)
	    {
	        App.NavigationPage.Navigation.PushAsync(new SelectionPage());

	    }

	}
}
