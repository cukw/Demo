using System;
using ReactiveUI;
using System.Reactive;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DemoAvalonia.ViewModels;

public class LoginViewModel : ViewModelBase
{
    private readonly Action<ViewModelBase> _currView;
    private readonly SqlService _sqlService;
    private string _login;
    private string _password;
    public ICommand LoginAction { get; }

    public string Login
    {
        get => _login;
        set => this.RaiseAndSetIfChanged(ref _login, value);
    }

    public string Password
    {
        get => _password;
        set => this.RaiseAndSetIfChanged(ref _password, value);
    }

    public LoginViewModel(Action<ViewModelBase> currView)
    {
        _currView = currView;
        var conf = new Config();
        SqlInterface sqlWorker = new SqlWorker(conf);
        _sqlService = new SqlService(sqlWorker);

        LoginAction = ReactiveCommand.CreateFromTask(OnClick);
    }

    public async Task OnClick()
    {
        var result = await _sqlService.LoginAsync(Login, Password);

        if (result)
            _currView(new ShopWindowViewModel());
    }
}
