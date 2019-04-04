using TeduShop.Model.Model;
using TeduShopData.Infratructure;

namespace TeduShopData.Repositoris
{
    public interface IPostTagRepository : IRepository<PostTag> { }

    public class PostTagRepository : RepositoryBase<PostTag>, IPostTagRepository
    {
        public PostTagRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}