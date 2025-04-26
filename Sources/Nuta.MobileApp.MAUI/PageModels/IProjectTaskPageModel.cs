using CommunityToolkit.Mvvm.Input;
using Nuta.MobileApp.MAUI.Models;

namespace Nuta.MobileApp.MAUI.PageModels;

public interface IProjectTaskPageModel
{
    IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
    bool IsBusy { get; }
}