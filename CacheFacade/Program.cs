using CacheFacade.CacheProvider;
using CacheFacade.ConfigurationFileManager;

namespace CacheFacade
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var cacheService = new CacheServiceFacade(new Redis(), new ConfigurationManager());
            cacheService.ImplementarCache();
        }
    }
}
