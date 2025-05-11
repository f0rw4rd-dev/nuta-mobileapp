using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Nuta.MobileApp.MAUI.Models;

namespace Nuta.MobileApp.MAUI.PageModels;

public partial class ProductHistoryPageModel : ObservableObject
{
    [ObservableProperty] private List<ProductPreviewInHistory> _products = [];

    [RelayCommand]
    private Task Appearing()
    {
        Products =
        [
            new ProductPreviewInHistory(
                "Кофе растворимый Nescafe",
                100,
                "1 января 2025",
                "https://cdn-img.perekrestok.ru/i/800x800-fit/xdelivery/files/12/ba/65e3bba9654812f7cf8c9cfb87d2.jpg"),
            new ProductPreviewInHistory(
                "Зефир в шоколаде",
                100,
                "2 января 2025",
                "https://cdn-img.perekrestok.ru/i/800x800-fit/xdelivery/files/12/ba/65e3bba9654812f7cf8c9cfb87d2.jpg"),
            new ProductPreviewInHistory(
                "Шоколад темный Ritter Sport \"Марципан\"",
                100,
                "3 января 2025",
                "https://cdn-img.perekrestok.ru/i/800x800-fit/xdelivery/files/12/ba/65e3bba9654812f7cf8c9cfb87d2.jpg"),
            new ProductPreviewInHistory(
                "Шоколад темный Ritter Sport \"Марципан\"",
                100,
                "4 января 2025",
                "https://cdn-img.perekrestok.ru/i/800x800-fit/xdelivery/files/12/ba/65e3bba9654812f7cf8c9cfb87d2.jpg"),
            new ProductPreviewInHistory(
                "Шоколад темный Ritter Sport \"Марципан\"",
                100,
                "5 января 2025",
                "https://cdn-img.perekrestok.ru/i/800x800-fit/xdelivery/files/12/ba/65e3bba9654812f7cf8c9cfb87d2.jpg"),
            new ProductPreviewInHistory(
                "Шоколад темный Ritter Sport \"Марципан\"",
                100,
                "6 января 2025",
                "https://cdn-img.perekrestok.ru/i/800x800-fit/xdelivery/files/12/ba/65e3bba9654812f7cf8c9cfb87d2.jpg"),
            new ProductPreviewInHistory(
                "Шоколад темный Ritter Sport \"Марципан\"",
                100,
                "7 января 2025",
                "https://cdn-img.perekrestok.ru/i/800x800-fit/xdelivery/files/12/ba/65e3bba9654812f7cf8c9cfb87d2.jpg"),
            new ProductPreviewInHistory(
                "Шоколад темный Ritter Sport \"Марципан\"",
                100,
                "8 января 2025",
                "https://cdn-img.perekrestok.ru/i/800x800-fit/xdelivery/files/12/ba/65e3bba9654812f7cf8c9cfb87d2.jpg"),
            new ProductPreviewInHistory(
                "Шоколад темный Ritter Sport \"Марципан\"",
                100,
                "9 января 2025",
                "https://cdn-img.perekrestok.ru/i/800x800-fit/xdelivery/files/12/ba/65e3bba9654812f7cf8c9cfb87d2.jpg"),
            new ProductPreviewInHistory(
                "Шоколад темный Ritter Sport \"Марципан\"",
                100,
                "10 января 2025",
                "https://cdn-img.perekrestok.ru/i/800x800-fit/xdelivery/files/12/ba/65e3bba9654812f7cf8c9cfb87d2.jpg"),
            new ProductPreviewInHistory(
                "Шоколад темный Ritter Sport \"Марципан\"",
               100,
                "11 января 2025",
                "https://cdn-img.perekrestok.ru/i/800x800-fit/xdelivery/files/12/ba/65e3bba9654812f7cf8c9cfb87d2.jpg"),
            new ProductPreviewInHistory(
                "Шоколад темный Ritter Sport \"Марципан\"",
                100,
                "12 января 2025",
                "https://cdn-img.perekrestok.ru/i/800x800-fit/xdelivery/files/12/ba/65e3bba9654812f7cf8c9cfb87d2.jpg"),
        ];
            
        return Task.CompletedTask;
    }
}