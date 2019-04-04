using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Model;
using TeduShopData.Infratructure;

namespace TeduShopData.Repositoris
{
    public interface IPageRepository { }
    public class PageRepository: RepositoryBase<Page>,IPageRepository
    {
        public PageRepository(DbFactory dbFactory) : base(dbFactory) { }
    }
}
