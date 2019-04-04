using TeduShop.Model.Model;
using TeduShopData.Infratructure;

namespace TeduShopData.Repositoris
{
    public interface IVisitorStatisticRepository : IRepository<VisitorStatistic> { }

    public class VisitorStatisticRepository : RepositoryBase<VisitorStatistic>, IVisitorStatisticRepository
    {
        public VisitorStatisticRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}