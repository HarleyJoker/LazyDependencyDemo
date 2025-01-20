using LazyDependencyDemo.Helpers;
using LazyDependencyDemo.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

class Program
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection();

        // Register services with Lazy<T>
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<INotificationService, NotificationService>();

        // Add support for Lazy<T>
        services.AddLazySupport();

        var serviceProvider = services.BuildServiceProvider();

        // Resolve the UserService and start the process
        var userService = serviceProvider.GetRequiredService<IUserService>();
        userService.GetUserAndNotify(1);
    }
}
