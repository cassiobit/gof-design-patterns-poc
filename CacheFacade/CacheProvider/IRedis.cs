namespace CacheFacade.CacheProvider
{
    internal interface IRedis
    {
        bool ConectarComProvedor(string secretKey);
        void RealizarCacheNivel1();
        void RealizarCacheNivel2();
    }
}