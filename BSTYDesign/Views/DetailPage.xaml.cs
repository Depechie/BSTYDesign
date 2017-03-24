
using BSTYDesign.Models;
using Xamarin.Forms;

namespace BSTYDesign.Views
{
    public partial class DetailPage : ContentPage
    {
        public CategoryItem CategoryItem { get; set; }

        public DetailPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            
            InitializeComponent();
        }

        private async void OnCloseClicked(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
