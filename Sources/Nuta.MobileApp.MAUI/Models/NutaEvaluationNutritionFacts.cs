using Nuta.MobileApp.MAUI.Enums;

namespace Nuta.MobileApp.MAUI.Models;

public record NutaEvaluationNutritionFacts(
    NutrientLevel ProteinLevel,
    NutrientLevel FatLevel,
    NutrientLevel CarbohydratesLevel,
    CalorieLevel CalorieLevel);