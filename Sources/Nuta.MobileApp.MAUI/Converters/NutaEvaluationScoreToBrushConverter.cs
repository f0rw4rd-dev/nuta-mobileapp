using System.Globalization;
using Nuta.MobileApp.MAUI.Mappers;

namespace Nuta.MobileApp.MAUI.Converters;

public class NutaEvaluationScoreToBrushConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is not int score)
            return BindableProperty.UnsetValue;

        return NutaEvaluationScoreMapper.MapToBrush(score);
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        => BindableProperty.UnsetValue;
}