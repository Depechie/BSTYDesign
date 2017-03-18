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
            InitializeComponent();

            CategoryList = DataService.GetItems("Interior");

            BindingContext = this;
        }
    }
}
