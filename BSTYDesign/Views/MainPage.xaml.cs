using System.Collections.Generic;
using BSTYDesign.Models;
using BSTYDesign.Services;
using Xamarin.Forms;

namespace BSTYDesign.Views
{
    public partial class MainPage : ContentPage
    {
        public List<CategoryItem> CategoryList { get; set; } = new List<CategoryItem>();

        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            InitializeComponent();

            CategoryList = DataService.GetItems("Interior");

            BindingContext = this;
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (CategoryListView.SelectedItem != null)
            {
                DetailPage detailPage = new DetailPage();
                detailPage.CategoryItem = (CategoryItem)CategoryListView.SelectedItem;
                CategoryListView.SelectedItem = null;
                await Navigation.PushAsync(detailPage);
            }
        }
    }
}
