using System;
using System.Threading.Tasks;

namespace DemoAvalonia;

public class SqlWorker : SqlInterface
{
    private readonly Config _config;
    public SqlWorker(Config config)
    {
        _config = config;
    }
    public async Task<bool> Login(string username, string password)
    {
        return await Task.FromResult(username == "admin" && password == "123");
    }
}
