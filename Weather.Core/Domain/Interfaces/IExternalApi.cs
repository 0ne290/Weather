namespace Weather.Core.Domain.Interfaces;

public interface IExternalApi : IDisposable
{
    Task<string> SendGetAsync(string parameters);
}