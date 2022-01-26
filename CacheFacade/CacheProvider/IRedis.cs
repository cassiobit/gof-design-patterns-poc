namespace CacheFacade.CacheProvider
{
    internal interface IRedis
    {
        bool ConnectWithProvider(string secretKey);
        void RunCacheLevel1();
        void RunCacheLevel2();
    }
}