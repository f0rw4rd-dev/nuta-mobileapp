using Nuta.MobileApp.HttpClient.Enums;
using Nuta.MobileApp.HttpClient.Models.Domain;

namespace Nuta.MobileApp.HttpClient.Dtos;

public record ProductDetailDto(
    Guid Id,
    string Name,
    string? Ean13,
    ProductCategory Category,
    ProductSubCategory? SubCategory,
    Guid ManufacturerId,
    NutritionFacts NutritionFacts,
    Ingredients Ingredients,
    Labels? Labels,
    Scores? Scores,
    bool IsHidden);