using Microsoft.Extensions.DependencyInjection;

namespace CleanAddress.Dadata.Client
{
    public static class Registration
    {

        /// <summary>
        /// Добавление клиента для стандартизации адресов.
        /// </summary>
        /// <param name="services">service collection</param>
        /// <param name="clientSettings">Настройки клиента</param>
        /// <returns></returns>
        public static IServiceCollection RegistarDadataClient(this IServiceCollection services, DadataClientSettings clientSettings)
        {
            services.AddSingleton(clientSettings);
            services.AddSingleton<IDadataClient>(x => x.GetRequiredService<DadataClient>());

            HttpClientFactoryServiceCollectionExtensions.AddHttpClient<DadataClient>(services);

            return services;
        }


    }
}
