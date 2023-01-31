namespace CleanAddress.Middlewares
{
    /// <summary>
    ///  Middleware для обработки исключений.
    /// </summary>
    public class ExceptionHandlerMiddleware
    {
        /// <summary>
        /// Следующий  middleware
        /// </summary>
        private readonly RequestDelegate _next;

        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        /// <summary>
        /// Выполнение middleware.
        /// </summary>
        /// <param name="context">Http-контекст.</param>
        /// <param name="logger">Логгер.</param>
        public async Task Invoke(HttpContext context, ILogger<ExceptionHandlerMiddleware> logger)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (Exception ex)
            {
                var innerException = string.Empty;

                var exception = ex.InnerException;

                while (exception is not null)
                {
                    innerException += $"\n {exception.Message}\n StackTrace - {ex.StackTrace}";
                    exception = exception.InnerException;
                }

                logger.LogError($"ErrorMesage - {ex.Message}\nStackTrace - {ex.StackTrace}\nInnerException {innerException}");
            }
        }
    }
}
