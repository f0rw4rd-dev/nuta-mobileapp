using Nuta.MobileApp.MAUI.Enums;

namespace Nuta.MobileApp.MAUI.Models;

public record ProductDetail(
    Guid ProductId,
    string Name,
    string? Ean13,
    string? ImageKey,
    ProductCategory Category,
    ProductSubCategory? SubCategory,
    Manufacturer Manufacturer,
    NutritionFacts NutritionFacts,
    Ingredients Ingredients,
    Scores Scores,
    Labels? Labels,
    IReadOnlyCollection<Additive> Additives,
    bool IsHidden);