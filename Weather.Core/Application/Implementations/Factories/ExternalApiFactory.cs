using Weather.Core.Application.Interfaces;
using Weather.Core.Domain.Implementations;
using Weather.Core.Domain.Interfaces;

namespace Weather.Core.Application.Implementations;

public class ExternalApiFactory : IExternalApiFactory
{
    public ExternalApiFactory(Uri rootUrl, IDictionary<string, string> headers, IHttpClientFactory httpClientFactory)
    {
        _rootUrl = rootUrl;
        _headers = headers;
        _httpClientFactory = httpClientFactory;
    }
    
    public IExternalApi FactoryMethod()
    {
        var httpClient = _httpClientFactory.CreateClient();

        httpClient.BaseAddress = _rootUrl;

        foreach (var header in _headers)
            httpClient.DefaultRequestHeaders.Add(header.Key, header.Value);

        return new ExternalApi(httpClient);
    }

    private readonly Uri _rootUrl;

    private readonly IDictionary<string, string> _headers;

    private readonly IHttpClientFactory _httpClientFactory;
}