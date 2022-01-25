using System;

namespace CacheFacade.CacheProvider
{
    class Redis : IRedis
    {
        public bool ConectarComProvedor(string secretKey)
        {
            return new Random().NextDouble() > 0.5;
        }

        public void RealizarCacheNivel1()
        {
            Console.WriteLine("Implementando Cache nível 1");
        }

        public void RealizarCacheNivel2()
        {
            Console.WriteLine("Implementando Cache nível 2");
        }
    }
}
