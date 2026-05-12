using System;
using AvaloniaUI;
using ReactiveUI;

namespace DemoAvalonia.ViewModels;

public class ShopWindowViewModel : ViewModelBase
{
    private readonly Action<ViewModelBase> _currView;

    public ShopWindowViewModel(Action<ViewModelBase> currView)
    {
        _currView = currView;
    }

    public ShopWindowViewModel() { }
}
