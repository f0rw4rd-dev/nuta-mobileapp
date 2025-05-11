using System.Globalization;

namespace Nuta.MobileApp.MAUI.Converters;

public class ProductReviewAuthorToDisplayConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return value is not string ? "Аноним" : value;
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        => BindableProperty.UnsetValue;
}