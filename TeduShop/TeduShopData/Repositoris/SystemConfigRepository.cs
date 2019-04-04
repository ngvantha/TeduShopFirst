using TeduShop.Model.Model;
using TeduShopData.Infratructure;

namespace TeduShopData.Repositoris
{
    public interface ISystemConfigRepository : IRepository<SystemConfig> { }

    public class SystemConfigRepository : RepositoryBase<SystemConfig>, ISystemConfigRepository
    {
        public SystemConfigRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}