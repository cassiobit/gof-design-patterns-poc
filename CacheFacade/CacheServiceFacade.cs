using System;
using CacheFacade.CacheProvider;
using CacheFacade.ConfigurationFileManager;

namespace CacheFacade
{
    class CacheServiceFacade
    {
        private readonly IRedis _redis;
        private readonly IConfigurationManager _configurationManager;

        public CacheServiceFacade(IRedis redis, IConfigurationManager configurationManager)
        {
            _redis = redis;
            _configurationManager = configurationManager;
        }

        public void ImplementCache()
        {
            string url = _configurationManager.GetValue("url");
            string secretKey = _configurationManager.GetValue("secretKey");

            bool connexionSuccessful = _redis.ConnectWithProvider(secretKey);

            if (connexionSuccessful)
            {
                _redis.RunCacheLevel1();
                _redis.RunCacheLevel2();
            }
            else
            {
                Console.WriteLine("Invalid Secret Key");
            }
        }
    }
}
