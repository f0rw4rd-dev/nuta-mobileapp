namespace Nuta.MobileApp.MAUI.Constants;

public class NutaEvaluationScoreConstants
{
    public const string BadText = "Плохо";
    public const string SatisfactoryText = "Приемлемо";
    public const string GoodText = "Хорошо";
    public const string ExcellentText = "Отлично";

    public static readonly SolidColorBrush BadBrush = new(Colors.Red);
    public static readonly SolidColorBrush SatisfactoryBrush = new(Colors.Orange);
    public static readonly SolidColorBrush GoodBrush = new(Colors.Lime);
    public static readonly SolidColorBrush ExcellentBrush = new(Colors.Green);
}