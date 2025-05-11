namespace Nuta.MobileApp.HttpClient.Models.Domain;

public record Ingredients(IReadOnlyCollection<Guid> AdditiveIds, IReadOnlyCollection<string> Names);