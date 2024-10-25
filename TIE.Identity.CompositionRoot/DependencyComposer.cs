using Microsoft.Extensions.DependencyInjection;

namespace TIE.Identity.CompositionRoot;

public sealed class DependencyComposer(IServiceCollection serviceCollection)
{
    public void Compose(Action<IServiceCollection>? serviceConfiguration = null)
    {
        if (serviceConfiguration is null)
        {
            return;
        }

        serviceConfiguration.Invoke(serviceCollection);
    }
}