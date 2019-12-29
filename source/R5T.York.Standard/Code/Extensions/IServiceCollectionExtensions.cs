using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.York.Newport;


namespace R5T.York.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddHttpJsonSource(this IServiceCollection services)
        {
            services.AddSingleton<IHttpJsonSource, NewtonsoftHttpJsonSource>();

            return services;
        }
    }
}
