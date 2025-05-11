namespace Nuta.MobileApp.MAUI.Constants;

public static class NutrientLevelConstants
{
    public const string NormalText = "В норме";
    public const string DeficiencyText = "Недостаток";
    public const string ExcessText = "Переизбыток";
    
    public static readonly SolidColorBrush NormalBrush = new(Colors.Green);
    public static readonly SolidColorBrush DeficiencyOrExcessBrush = new(Colors.Orange);
}