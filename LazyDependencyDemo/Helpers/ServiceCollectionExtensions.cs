using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyDependencyDemo.Helpers
{
    public  static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddLazySupport(this IServiceCollection services)
        {
            services.AddTransient(typeof(Lazy<>), typeof(LazyFactory<>));
            return services;
        }

        private class LazyFactory<T> : Lazy<T>
        {
            public LazyFactory(IServiceProvider serviceProvider)
                : base(() => serviceProvider.GetRequiredService<T>())
            {
            }
        }
    }
}
