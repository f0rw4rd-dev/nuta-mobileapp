using Nuta.MobileApp.MAUI.Constants;
using Nuta.MobileApp.MAUI.Enums;

namespace Nuta.MobileApp.MAUI.Mappers;

public static class CalorieLevelMapper
{
    public static SolidColorBrush MapToBrush(CalorieLevel calorieLevel)
    {
        return calorieLevel switch
        {
            CalorieLevel.Low => CalorieLevelConstants.LowBrush,
            CalorieLevel.Medium => CalorieLevelConstants.MediumBrush,
            CalorieLevel.High => CalorieLevelConstants.HighBrush,
            CalorieLevel.Excessive => CalorieLevelConstants.ExcessiveBrush,
            _ => throw new ArgumentOutOfRangeException(nameof(calorieLevel), calorieLevel, null)
        };
    }
    
    public static string MapToText(CalorieLevel calorieLevel)
    {
        return calorieLevel switch
        {
            CalorieLevel.Low => CalorieLevelConstants.LowText,
            CalorieLevel.Medium => CalorieLevelConstants.MediumText,
            CalorieLevel.High => CalorieLevelConstants.HighText,
            CalorieLevel.Excessive => CalorieLevelConstants.ExcessiveText,
            _ => throw new ArgumentOutOfRangeException(nameof(calorieLevel), calorieLevel, null)
        };
    }
}