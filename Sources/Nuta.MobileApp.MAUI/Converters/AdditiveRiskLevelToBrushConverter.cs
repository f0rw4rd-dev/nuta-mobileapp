using System.Globalization;
using Nuta.MobileApp.MAUI.Enums;
using Nuta.MobileApp.MAUI.Mappers;

namespace Nuta.MobileApp.MAUI.Converters;

public class AdditiveRiskLevelToBrushConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is not AdditiveRiskLevel additiveRiskLevel)
            return BindableProperty.UnsetValue;

        return AdditiveRiskLevelMapper.MapToBrush(additiveRiskLevel);
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        => BindableProperty.UnsetValue;
}