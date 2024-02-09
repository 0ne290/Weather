using Weather.Core.Domain.Interfaces;

namespace Weather.Core.Application.Interfaces;

public interface IExternalApiFactory
{
    IExternalApi FactoryMethod();
}