using CommunityToolkit.Mvvm.ComponentModel;
using Nuta.MobileApp.MAUI.Enums;
using Nuta.MobileApp.MAUI.Models;

namespace Nuta.MobileApp.MAUI.PageModels;

public partial class ProductDetailPageModel : ObservableObject
{
    [ObservableProperty] private ProductDetail _productDetail = new(
        Guid.CreateVersion7(),
        "Зефир Шармэль Ваниль 255г",
        "",
        "https://cdn-img.perekrestok.ru/i/800x800-fit/xdelivery/files/12/ba/65e3bba9654812f7cf8c9cfb87d2.jpg",
        ProductCategory.Confectionery,
        null,
        new Manufacturer(
            Guid.CreateVersion7(),
            "Шармэль",
            ""),
        new NutritionFacts(350, 7.45, 23.98, 46.12),
        new Ingredients([
            "сахар",
            "пюре яблочное (яблоки, консервант - диоксид серы)",
            "патока",
            "пудра сахарная",
            "белок яичный сухой",
            "желирующий агент - агар",
            "порошок яблочный",
            "регуляторы кислотности - кислота молочная, цитрат натрия 3-замещённый",
            "ароматизатор «Ваниль»"
        ]),
        new Scores(
            new NutaEvaluation(
                65,
                new NutaEvaluationNutritionFacts(
                    NutrientLevel.Deficiency,
                    NutrientLevel.Excess,
                    NutrientLevel.Normal,
                    CalorieLevel.High)),
            UserScore: 3.4),
        null,
        [
            new Additive(
                Guid.CreateVersion7(),
                "Сорбат калия",
                "Сорбат калия",
                "E202",
                "Текст",
                AdditiveRiskLevel.NoRisk),
            new Additive(
                Guid.CreateVersion7(),
                "Сорбат калия",
                "Сорбат калия",
                "E543",
                "Текст",
                AdditiveRiskLevel.HighRisk),
            new Additive(
                Guid.CreateVersion7(),
                "Сорбат калия",
                "Сорбат калия",
                "E432",
                "Текст",
                AdditiveRiskLevel.ModerateRisk)
        ],
        false);

    [ObservableProperty] private IReadOnlyCollection<ProductReview> _reviews =
    [
        new(Guid.CreateVersion7(), null, Guid.CreateVersion7(), 3,
            "Соображения высшего порядка, а также выбранный нами инновационный путь способствует подготовке и реализации существующих финансовых и административных условий. Разнообразный и богатый опыт консультация с профессионалами из IT создаёт предпосылки качественно новых шагов для форм воздействия? Дорогие друзья, постоянное информационно-техническое обеспечение нашей деятельности играет важную роль в формировании всесторонне сбалансированных нововведений.",
            false, DateTime.Now),
        new(Guid.CreateVersion7(), "Максим", Guid.CreateVersion7(), 1,
            "С другой стороны курс на социально-ориентированный национальный проект позволяет оценить значение ключевых компонентов планируемого обновления. С другой стороны выбранный нами инновационный путь напрямую зависит от соответствующих условий активизации? Повседневная практика показывает, что начало повседневной работы по формированию позиции способствует повышению актуальности системы масштабного изменения ряда параметров. Равным образом реализация намеченного плана развития позволяет выполнить важнейшие задания по разработке существующих финансовых и административных условий.",
            false, DateTime.Now),
        new(Guid.CreateVersion7(), null, Guid.CreateVersion7(), 5, null, true, DateTime.Now),
        new(Guid.CreateVersion7(), null, Guid.CreateVersion7(), 5,
            "Таким образом, постоянное информационно-техническое обеспечение нашей деятельности требует от нас системного анализа дальнейших направлений развития проекта. Задача организации, в особенности же новая модель организационной деятельности требует от нас анализа направлений прогрессивного развития?",
            true, DateTime.Now),
    ];

    [ObservableProperty] private IReadOnlyCollection<ProductPreviewInRecommendations> _recommendations =
    [
        new(Guid.CreateVersion7(), "Зефир 1 Зефир 2 Зефир 3 Зефир 4 Зефир 5 Зефир 6 Зефир 7 Зефир 8", 32,
            "https://cdn-img.perekrestok.ru/i/800x800-fit/xdelivery/files/12/ba/65e3bba9654812f7cf8c9cfb87d2.jpg"),
        new(Guid.CreateVersion7(), "Зефир 2", 12,
            "https://cdn-img.perekrestok.ru/i/800x800-fit/xdelivery/files/12/ba/65e3bba9654812f7cf8c9cfb87d2.jpg"),
        new(Guid.CreateVersion7(), "Зефир 3", 68,
            "https://cdn-img.perekrestok.ru/i/800x800-fit/xdelivery/files/12/ba/65e3bba9654812f7cf8c9cfb87d2.jpg"),
        new(Guid.CreateVersion7(), "Зефир 4", 99,
            "https://cdn-img.perekrestok.ru/i/800x800-fit/xdelivery/files/12/ba/65e3bba9654812f7cf8c9cfb87d2.jpg"),
        new(Guid.CreateVersion7(), "Зефир 5", 50,
            "https://cdn-img.perekrestok.ru/i/800x800-fit/xdelivery/files/12/ba/65e3bba9654812f7cf8c9cfb87d2.jpg"),
    ];

    public string Ingredients => string.Join(", ", ProductDetail.Ingredients.Names);
    
    public bool HasRecommendations => Recommendations.Count != 0;

    public bool HasVisibleReviews => Reviews.Any(x => !x.IsHidden);
    
    public IReadOnlyCollection<ProductReview> VisibleReviewsWithComments =>
        Reviews.Where(x => !string.IsNullOrWhiteSpace(x.Comment) && !x.IsHidden).ToList();
}