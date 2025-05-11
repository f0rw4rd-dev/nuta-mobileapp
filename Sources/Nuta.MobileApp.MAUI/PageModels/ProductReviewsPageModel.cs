using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Nuta.MobileApp.MAUI.Models;

namespace Nuta.MobileApp.MAUI.PageModels;

public partial class ProductReviewsPageModel : ObservableObject
{
    public ObservableCollection<ProductReview> AllReviews { get; } = new()
    {
        new(Guid.CreateVersion7(), null, Guid.CreateVersion7(), 3, "Соображения высшего порядка, а также выбранный нами инновационный путь способствует подготовке и реализации существующих финансовых и административных условий. Разнообразный и богатый опыт консультация с профессионалами из IT создаёт предпосылки качественно новых шагов для форм воздействия? Дорогие друзья, постоянное информационно-техническое обеспечение нашей деятельности играет важную роль в формировании всесторонне сбалансированных нововведений.", true, DateTime.Now),
        new(Guid.CreateVersion7(), "Максим", Guid.CreateVersion7(), 1, "С другой стороны курс на социально-ориентированный национальный проект позволяет оценить значение ключевых компонентов планируемого обновления. С другой стороны выбранный нами инновационный путь напрямую зависит от соответствующих условий активизации? Повседневная практика показывает, что начало повседневной работы по формированию позиции способствует повышению актуальности системы масштабного изменения ряда параметров. Равным образом реализация намеченного плана развития позволяет выполнить важнейшие задания по разработке существующих финансовых и административных условий.", true, DateTime.Now),
        new(Guid.CreateVersion7(), null, Guid.CreateVersion7(), 5, null, true, DateTime.Now),
        new(Guid.CreateVersion7(), null, Guid.CreateVersion7(), 5, "Таким образом, постоянное информационно-техническое обеспечение нашей деятельности требует от нас системного анализа дальнейших направлений развития проекта. Задача организации, в особенности же новая модель организационной деятельности требует от нас анализа направлений прогрессивного развития?", true, DateTime.Now),
    };

    [RelayCommand]
    private async Task CloseAsync() => await Shell.Current.Navigation.PopModalAsync();
}