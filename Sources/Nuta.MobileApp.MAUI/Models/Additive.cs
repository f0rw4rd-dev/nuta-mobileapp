using Nuta.MobileApp.MAUI.Enums;

namespace Nuta.MobileApp.MAUI.Models;

public record Additive(
    Guid Id,
    string Name,
    string ChemicalName,
    string? ENumber,
    string Description,
    AdditiveRiskLevel RiskLevel);