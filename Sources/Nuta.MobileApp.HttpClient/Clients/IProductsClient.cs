using Nuta.MobileApp.HttpClient.Models.Requests;
using Nuta.MobileApp.HttpClient.Models.Responses;
using Refit;

namespace Nuta.MobileApp.HttpClient.Clients;

public interface IProductsClient
{
    [Get("/api/products/v1/products/{productId}")]
    Task<GetProductDetailByIdResponse> GetProductDetailByIdAsync(Guid productId, CancellationToken cancellationToken);

    [Get("/api/products/v1/products/{ean13}")]
    Task<GetProductDetailByEan13Response> GetProductDetailByEan13Async(
        string ean13,
        CancellationToken cancellationToken);

    [Post("/api/products/v1/products/search")]
    Task<SearchProductsResponse> SearchProductsAsync(
        [Body] SearchProductsRequest request,
        CancellationToken cancellationToken);
}