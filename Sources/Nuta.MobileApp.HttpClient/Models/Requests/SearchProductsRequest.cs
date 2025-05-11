using Nuta.MobileApp.HttpClient.Enums;
using Nuta.MobileApp.HttpClient.Models.Other;
using Nuta.MobileApp.HttpClient.Structs;

namespace Nuta.MobileApp.HttpClient.Models.Requests;

public record SearchProductsRequest(
    Optional<IReadOnlyCollection<Guid>> ProductIds,
    Optional<string> Term,
    Optional<ProductSortBy> SortBy,
    Optional<ProductFilter> Filter,
    Pagination Pagination);