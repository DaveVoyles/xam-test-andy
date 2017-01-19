using System;
using Xamarin.Forms;

namespace _1to1Core.Views
{
	public partial class WebPageView : ContentPage
	{
        /// <summary>
        /// Working sample found here: https://github.com/xamarin/xamarin-forms-samples/blob/master/FormsGallery/FormsGallery/FormsGallery/WebViewDemoPage.cs
        /// </summary>
        public WebPageView ()
		{
            // PRoperties for the header label
            Label header = new Label
            {
                Text              = "WebView",
                FontSize          = 50,
                FontAttributes    = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            // Create a new webview and point it at URL.
            // MUST use FillAndExpand, otherwise page will not display
            WebView webView = new WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = "https://blog.xamarin.com/",
                },
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            // BACK BUTTON & HANDLER
            Button backButton = new Button()
            {
                Text = "Back",
                HorizontalOptions = LayoutOptions.Start
            };

            backButton.Clicked += delegate
		    {
                // Check to see if there is anywhere to go back to
                if (webView.CanGoBack)
                {
                    webView.GoBack();
                }
                else
                { // If not, leave the view
                    Navigation.PopAsync();
                }
            };


            // FORWARD BUTTON & HANDLER
            Button forwardButton = new Button()
            {
                Text = "Forwrad",
                HorizontalOptions = LayoutOptions.End
                // TODO: Figure out why button does not align with back button on UI
            };

            forwardButton.Clicked += delegate
            {
                if (webView.CanGoForward)
                {
                    webView.GoForward();
                }
            };

            // Build the page and add it to the XAML
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    webView,
                    backButton,
                    forwardButton
                }
            };
        }

    }
}
