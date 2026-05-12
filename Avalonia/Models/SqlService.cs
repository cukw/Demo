using System;
using System.Threading.Tasks;

namespace DemoAvalonia;

public class SqlService
{
    private readonly SqlInterface _sqlWorker;

    public SqlService(SqlInterface sqlWorker)
    {
        _sqlWorker = sqlWorker;
    }

    public async Task<bool> LoginAsync(string username, string password)
    {
        return await _sqlWorker.Login(username, password);
    }
}
