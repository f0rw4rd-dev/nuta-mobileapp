using System.Globalization;
using Nuta.MobileApp.MAUI.Enums;
using Nuta.MobileApp.MAUI.Mappers;

namespace Nuta.MobileApp.MAUI.Converters;

public class CalorieLevelToTextConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is not CalorieLevel calorieLevel)
            return BindableProperty.UnsetValue;

        return CalorieLevelMapper.MapToText(calorieLevel);
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        => BindableProperty.UnsetValue;
}