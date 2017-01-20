using VitalTrax.View_Models;
using Xamarin.Forms;

namespace VitalTrax
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            BindingContext = new MenuPageViewModel();
            Title = "Menu";
            InitializeComponent();
        }
    }
}
