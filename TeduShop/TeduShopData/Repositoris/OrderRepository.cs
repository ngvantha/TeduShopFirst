using TeduShop.Model.Model;
using TeduShopData.Infratructure;

namespace TeduShopData.Repositoris
{
    public interface IOrderRepository : IRepository<Order>
    {
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}