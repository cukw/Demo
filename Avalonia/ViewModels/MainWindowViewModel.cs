using ReactiveUI;

namespace DemoAvalonia.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase _currentView;

    public ViewModelBase CurrentView
    {
        get => _currentView;
        set => this.RaiseAndSetIfChanged(ref _currentView, value);
    }

    public MainWindowViewModel()
    {
        CurrentView = new LoginViewModel(NavigateTo);
    }

    private void NavigateTo(ViewModelBase viewModel)
    {
        CurrentView = viewModel;
    }
}
