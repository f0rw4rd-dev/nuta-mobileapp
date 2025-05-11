namespace Nuta.MobileApp.HttpClient.Dtos;

public record ProductPreviewDto(
    Guid Id,
    string Name,
    string ManufacturerName,
    double? UserScore,
    int NutaScore,
    bool IsHidden);