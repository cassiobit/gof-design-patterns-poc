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

        public void ImplementarCache()
        {
            string url = _configurationManager.ObterValor("url");
            string secretKey = _configurationManager.ObterValor("secretKey");

            bool sucessoConexao = _redis.ConectarComProvedor(secretKey);

            if (sucessoConexao)
            {
                _redis.RealizarCacheNivel1();
                _redis.RealizarCacheNivel2();
            }
            else
            {
                Console.WriteLine("Secret Key inválida");
            }
        }
    }
}
