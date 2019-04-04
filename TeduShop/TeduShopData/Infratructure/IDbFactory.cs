using System;

namespace TeduShopData.Infratructure
{
    public interface IDbFactory : IDisposable
    {
        TeduShopDbContext Init();
    }
}