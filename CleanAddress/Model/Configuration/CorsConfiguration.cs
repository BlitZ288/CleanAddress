namespace CleanAddress.Model.Configuration
{
    public class CorsConfiguration
    {
        public static CorsConfiguration Default = new CorsConfiguration()
        {
            Origins = new[] { "*" },
            Methods = new[] { "GET", "POST", "PUT", "DELETE", "OPTIONS" },
            Headers = new[] { "*" },
            AllowCredentials = false,
        };

        /// <summary>
        /// Список источников, с которых разрешено делать запросы.
        /// </summary>
        public string[] Origins { get; set; }

        /// <summary>
        /// Список разрешенных HTTP-методов.
        /// </summary>
        public string[] Methods { get; set; }

        /// <summary>
        /// Список разрешенных HTTP-заголовков.
        /// </summary>
        public string[] Headers { get; set; }

        /// <summary>
        /// Признак, указывающий включен ли обмен учетными данными (в т.ч. cookie схемы) между клиентом и сервером.
        /// </summary>
        public bool AllowCredentials { get; set; }
    }
}
