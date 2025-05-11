using System.Globalization;
using Nuta.MobileApp.MAUI.Enums;
using Nuta.MobileApp.MAUI.Mappers;

namespace Nuta.MobileApp.MAUI.Converters;

public class NutrientLevelToTextConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is not NutrientLevel nutrientLevel)
            return BindableProperty.UnsetValue;

        return NutrientLevelMapper.MapToText(nutrientLevel);
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        => BindableProperty.UnsetValue;
}