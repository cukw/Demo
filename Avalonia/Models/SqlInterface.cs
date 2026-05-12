using System;
using System.Threading.Tasks;

namespace DemoAvalonia;

public interface SqlInterface
{
    Task<bool> Login(string username, string password);
}
