using StackExchange.Redis;

namespace RedisCacheExample.Cache
{
    public class ConnectionHelper
    {
        private static readonly Lazy<ConnectionMultiplexer> lazyConnection = new Lazy<ConnectionMultiplexer>(() =>
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            var redisUrl = configuration["RedisURL"];
            return ConnectionMultiplexer.Connect(redisUrl);
        });

        public static ConnectionMultiplexer Connection => lazyConnection.Value;
    }
}
