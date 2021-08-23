using Microsoft.Extensions.DependencyInjection;

namespace ReaderStackExchangeXml.Ioc
{
    /// <summary>
    /// Class registry to Dependecy injecation all interfaces
    /// </summary>
    public static class Registry
    {
        /// <summary>
        /// Adding ReaderStackExchangeXml classess
        /// </summary>
        public static IServiceCollection AddReaderStackXml(this IServiceCollection services)
        {
            return services.AddTransient(typeof(IReaderStackExchangeXml<>), typeof(ReaderStackExchangeXml<>));
        }
    }
}
