namespace CleanAddress.Dadata.Client
{
    /// <summary>
    /// Модель настройки клиента "Dadata"
    /// </summary>
    public class DadataClientSettings
    {
        /// <summary>
        /// URL к стороннему api.
        /// </summary>
        public string BaseUrl { get; set; }

        /// <summary>
        /// Токен доступа.
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Секретный ключ.
        /// </summary>
        public string Secret { get; set; }
    }
}
