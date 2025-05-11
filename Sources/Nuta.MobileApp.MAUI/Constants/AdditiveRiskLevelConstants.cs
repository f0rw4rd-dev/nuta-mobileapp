namespace Nuta.MobileApp.MAUI.Constants;

public static class AdditiveRiskLevelConstants
{
    public const string HighRiskText = "Высокий риск";
    public const string ModerateRiskText = "Умеренный риск";
    public const string LimitedRiskText = "Ограниченный риск";
    public const string NoRiskText = "Нет риска";
    
    public static readonly SolidColorBrush HighRiskBrush = new(Colors.Red);
    public static readonly SolidColorBrush ModerateRiskBrush = new(Colors.Orange);
    public static readonly SolidColorBrush LimitedRiskBrush = new(Colors.Lime);
    public static readonly SolidColorBrush NoRiskBrush = new(Colors.Green);
}