namespace Nuta.MobileApp.MAUI.Pages;

public partial class ProjectListPage : ContentPage
{
    public ProjectListPage(ProjectListPageModel model)
    {
        BindingContext = model;
        InitializeComponent();
    }
}