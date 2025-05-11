namespace Nuta.MobileApp.MAUI.Models;

public record ProductPreviewInHistory(
    string Name,
    int NutaEvaluationScore,
    string ViewedAt,
    string? ImageKey);