namespace Nuta.MobileApp.HttpClient.Models.Domain;

public record NutritionFacts(
    double Calories,
    double Protein,
    double Fat,
    double Carbohydrates,
    double? SaturatedFat = null,
    double? TransFat = null,
    double? Sugars = null,
    double? Fiber = null,
    double? Cholesterol = null,
    double? Sodium = null,
    double? Alcohol = null,
    double? Water = null,
    double? ServingSize = null,
    double? NetWeight = null);