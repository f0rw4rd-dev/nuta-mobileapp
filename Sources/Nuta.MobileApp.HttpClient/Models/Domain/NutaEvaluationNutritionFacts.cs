using Nuta.MobileApp.HttpClient.Enums;

namespace Nuta.MobileApp.HttpClient.Models.Domain;

public record NutaEvaluationNutritionFacts(
    NutrientLevel ProteinLevel,
    NutrientLevel FatLevel,
    NutrientLevel CarbohydratesLevel,
    CalorieLevel CalorieLevel);