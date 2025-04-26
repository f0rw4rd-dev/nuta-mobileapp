namespace Nuta.MobileApp.MAUI.Pages;

public partial class ManageMetaPage : ContentPage
{
    public ManageMetaPage(ManageMetaPageModel model)
    {
        InitializeComponent();
        BindingContext = model;
    }
}