namespace Nuta.MobileApp.MAUI.Constants;

public static class CalorieLevelConstants
{
    public const string LowText = "Низкий";
    public const string MediumText = "Средний";
    public const string HighText = "Высокий";
    public const string ExcessiveText = "Чрезмерный";
    
    public static readonly SolidColorBrush LowBrush = new(Colors.Green);
    public static readonly SolidColorBrush MediumBrush = new(Colors.Lime);
    public static readonly SolidColorBrush HighBrush = new(Colors.Orange);
    public static readonly SolidColorBrush ExcessiveBrush = new(Colors.Red);
}