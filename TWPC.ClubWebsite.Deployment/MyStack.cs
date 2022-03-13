using Microsoft.Extensions.DependencyInjection;
using Pulumi;
using System;
using TWPC.ClubWebsite.Resources.Managers;
using TWPC.ClubWebsite.Resources.Services;

class MyStack : Stack
{
    public MyStack()
    {
        var services = new ServiceCollection();
        services.AddSingleton<ResourceManager>();
        services.AddTransient<IResourceGroupService, ResourceGroupService>();

        IServiceProvider serviceProvider = services.BuildServiceProvider(true);
        IServiceScope scope = serviceProvider.CreateScope();
        scope.ServiceProvider.GetRequiredService<ResourceManager>().CreateResources();

        if (serviceProvider == null)
        {
            return;
        }
        if (serviceProvider is IDisposable)
        {
            ((IDisposable)serviceProvider).Dispose();
        }
    }

    
}
