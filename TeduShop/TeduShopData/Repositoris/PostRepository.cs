using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Model;
using TeduShopData.Infratructure;

namespace TeduShopData.Repositoris
{
    public interface IPostRepository { }
    public class PostRepository: RepositoryBase<Post>,IPageRepository
    {
        public PostRepository(DbFactory dbFactory) : base(dbFactory) { }
    }
}
