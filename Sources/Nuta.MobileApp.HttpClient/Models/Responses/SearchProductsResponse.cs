using Nuta.MobileApp.HttpClient.Dtos;

namespace Nuta.MobileApp.HttpClient.Models.Responses;

public record SearchProductsResponse(IReadOnlyCollection<ProductPreviewDto> Products);