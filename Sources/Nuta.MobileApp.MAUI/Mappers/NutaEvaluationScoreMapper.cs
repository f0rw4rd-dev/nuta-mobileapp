using Nuta.MobileApp.MAUI.Constants;

namespace Nuta.MobileApp.MAUI.Mappers;

public static class NutaEvaluationScoreMapper
{
    public static SolidColorBrush MapToBrush(int score)
    {
        return score switch
        {
            < 25 => NutaEvaluationScoreConstants.BadBrush,
            < 50 => NutaEvaluationScoreConstants.SatisfactoryBrush,
            < 75 => NutaEvaluationScoreConstants.GoodBrush,
            <= 100 => NutaEvaluationScoreConstants.ExcellentBrush,
            _ => throw new ArgumentOutOfRangeException(nameof(score), score, null)
        };
    }
    
    public static string MapToText(int score)
    {
        return score switch
        {
            < 25 => NutaEvaluationScoreConstants.BadText,
            < 50 => NutaEvaluationScoreConstants.SatisfactoryText,
            < 75 => NutaEvaluationScoreConstants.GoodText,
            <= 100 => NutaEvaluationScoreConstants.ExcellentText,
            _ => throw new ArgumentOutOfRangeException(nameof(score), score, null)
        };
    }
}