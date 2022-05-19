namespace Singleton
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class Logger
    {
        // Lazy<T>
        private static readonly Lazy<Logger> _lazyLogger = new Lazy<Logger>(() => new Logger());

        /// <summary>
        /// Instance
        /// </summary>
        public static Logger Instance
        {
            get
            {                
                return _lazyLogger.Value;
            }
        }

        protected Logger()
        {
        }

        /// <summary>
        /// SingletonOperation
        /// </summary> 
        public void Log(string message)
        {
            Console.WriteLine($"Wiadomość do logowania: {message}");
        }
    }
}
