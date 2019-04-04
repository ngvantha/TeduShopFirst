using TeduShop.Model.Model;
using TeduShopData.Infratructure;

namespace TeduShopData.Repositoris
{
    public interface IPostRepository : IRepository<Post>
    {
        void Delete(int id);
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}