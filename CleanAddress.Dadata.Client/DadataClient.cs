using CleanAddress.Dadata.Client.Dto;
using Microsoft.Extensions.Logging;
using System.Net.Http.Json;

namespace CleanAddress.Dadata.Client
{
    /// <summary>
    /// Клиент стандартизации адресов.
    /// </summary>
    public class DadataClient : IDadataClient
    {
        /// <summary>
        /// http клиент.
        /// </summary>
        private readonly HttpClient client;

        /// <summary>
        /// Настройки клиента.
        /// </summary>
        private readonly DadataClientSettings clientSettings;

        /// <summary>
        /// Логер.
        /// </summary>
        ILogger<DadataClient> logger;

        public DadataClient(HttpClient client, DadataClientSettings clientSetting, ILogger<DadataClient> logger)
        {
            this.client = client;
            this.clientSettings = clientSetting;
            this.logger = logger;
        }

        /// <summary>
        /// Метод получение подробной информации адреса.
        /// </summary>
        /// <param name="address">адрес.</param>       
        public async Task<CleanAddressDto?> SendAddressToClean(string address, CancellationToken cancellationToken)
        {

            this.client.DefaultRequestHeaders.Add("Authorization", $"Token {clientSettings.Token}");
            this.client.DefaultRequestHeaders.Add("X-Secret", clientSettings.Secret);

            try
            {
                var response = await this.client.PostAsJsonAsync(clientSettings.BaseUrl, new List<string> { address }, cancellationToken);

                var cleanAddres = await response.Content.ReadFromJsonAsync<List<CleanAddressDto>>();

                return cleanAddres!.FirstOrDefault();
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                throw;
            }
        }

    }
}