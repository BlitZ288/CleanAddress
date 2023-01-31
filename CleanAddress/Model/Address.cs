namespace CleanAddress.Model
{
    /// <summary>
    /// Модель адреса.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Отформатированный адрес.
        /// </summary>
        public string CleanAddress { get; set; }

        /// <summary>
        /// Страна.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Почтовый код.
        /// </summary>
        public string PostalCode { get; set; }

    }
}
