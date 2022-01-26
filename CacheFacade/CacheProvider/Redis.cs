using System;

namespace CacheFacade.CacheProvider
{
    class Redis : IRedis
    {
        public bool ConnectWithProvider(string secretKey)
        {
            return new Random().NextDouble() > 0.5;
        }

        public void RunCacheLevel1()
        {
            Console.WriteLine("Running cache level 1");
        }

        public void RunCacheLevel2()
        {
            Console.WriteLine("Running cache level 2");
        }
    }
}
