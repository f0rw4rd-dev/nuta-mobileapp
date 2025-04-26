using Nuta.MobileApp.MAUI.Models;
using Nuta.MobileApp.MAUI.PageModels;

namespace Nuta.MobileApp.MAUI.Pages;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageModel model)
    {
        InitializeComponent();
        BindingContext = model;
    }
}