using Nuta.MobileApp.MAUI.Constants;
using Nuta.MobileApp.MAUI.Enums;

namespace Nuta.MobileApp.MAUI.Mappers;

public static class AdditiveRiskLevelMapper
{
    public static SolidColorBrush MapToBrush(AdditiveRiskLevel additiveRiskLevel)
    {
        return additiveRiskLevel switch
        {
            AdditiveRiskLevel.NoRisk => AdditiveRiskLevelConstants.NoRiskBrush,
            AdditiveRiskLevel.LimitedRisk => AdditiveRiskLevelConstants.LimitedRiskBrush,
            AdditiveRiskLevel.ModerateRisk => AdditiveRiskLevelConstants.ModerateRiskBrush,
            AdditiveRiskLevel.HighRisk => AdditiveRiskLevelConstants.HighRiskBrush,
            _ => throw new ArgumentOutOfRangeException(nameof(additiveRiskLevel), additiveRiskLevel, null)
        };
    }
    
    public static string MapToText(AdditiveRiskLevel additiveRiskLevel)
    {
        return additiveRiskLevel switch
        {
            AdditiveRiskLevel.NoRisk => AdditiveRiskLevelConstants.NoRiskText,
            AdditiveRiskLevel.LimitedRisk => AdditiveRiskLevelConstants.LimitedRiskText,
            AdditiveRiskLevel.ModerateRisk => AdditiveRiskLevelConstants.ModerateRiskText,
            AdditiveRiskLevel.HighRisk => AdditiveRiskLevelConstants.HighRiskText,
            _ => throw new ArgumentOutOfRangeException(nameof(additiveRiskLevel), additiveRiskLevel, null)
        };
    }
}