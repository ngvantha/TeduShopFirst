using TeduShop.Model.Model;
using TeduShopData.Infratructure;

namespace TeduShopData.Repositoris
{
    public interface IErrorRepository :IRepository<Error>{ }

    public class ErrorRepository : RepositoryBase<Error>, IErrorRepository
    {
        public ErrorRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}