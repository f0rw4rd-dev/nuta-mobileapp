namespace Nuta.MobileApp.MAUI.Models;

public record ProductReview(
    Guid UserId,
    string? Author,
    Guid ProductId,
    double Rating,
    string? Comment,
    bool IsHidden,
    DateTime UpdatedAt);