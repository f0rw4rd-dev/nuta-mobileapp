using Nuta.MobileApp.MAUI.Constants;
using Nuta.MobileApp.MAUI.Enums;

namespace Nuta.MobileApp.MAUI.Mappers;

public static class NutrientLevelMapper
{
    public static SolidColorBrush MapToBrush(NutrientLevel nutrientLevel)
    {
        return nutrientLevel switch
        {
            NutrientLevel.Deficiency or NutrientLevel.Excess
                => NutrientLevelConstants.DeficiencyOrExcessBrush,
            
            NutrientLevel.Normal => NutrientLevelConstants.NormalBrush,
            
            _ => throw new ArgumentOutOfRangeException(nameof(nutrientLevel), nutrientLevel, null)
        };
    }
    
    public static string MapToText(NutrientLevel nutrientLevel)
    {
        return nutrientLevel switch
        {
            NutrientLevel.Deficiency => NutrientLevelConstants.DeficiencyText,
            NutrientLevel.Excess => NutrientLevelConstants.ExcessText,
            NutrientLevel.Normal => NutrientLevelConstants.NormalText,
            _ => throw new ArgumentOutOfRangeException(nameof(nutrientLevel), nutrientLevel, null)
        };
    }
}