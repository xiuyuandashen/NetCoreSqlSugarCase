using NetCoreSqlSugarCase.Common;

namespace NetCoreSqlSugarCase.config
{
    public static class RedisConfig
    {

        public static void AppRedisConfig(this IServiceCollection service, IConfiguration configuration)
        {
            var csredis = new CSRedis.CSRedisClient(configuration["Redis:RedisConnectionString"]);
            RedisHelper.Initialization(csredis);
            service.AddSingleton<ICache, RedisCache>();
        }
    }
}
