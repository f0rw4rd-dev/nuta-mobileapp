using Nuta.MobileApp.HttpClient.Enums;
using Nuta.MobileApp.HttpClient.Structs;

namespace Nuta.MobileApp.HttpClient.Models.Other;

public record ProductFilter(Optional<ProductCategory> Category, Optional<ProductSubCategory> SubCategory);