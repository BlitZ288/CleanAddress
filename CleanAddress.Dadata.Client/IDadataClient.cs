using CleanAddress.Dadata.Client.Dto;

namespace CleanAddress.Dadata.Client
{
    /// <summary>
    /// Контракт клиента "DadataClient"
    /// </summary>
    internal interface IDadataClient
    {

        /// <summary>
        /// Метод получение подробной информации адреса.
        /// </summary>
        /// <param name="address">адрес.</param
        Task<CleanAddressDto?> SendAddressToClean(string address, CancellationToken cancellationToken);
    }
}
