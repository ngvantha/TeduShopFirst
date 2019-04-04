using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Model;
using TeduShopData.Infratructure;

namespace TeduShopData.Repositoris
{
    public interface ITagRepository { }
    class TagRepository:RepositoryBase<Tag>,ITagRepository
    {
        public TagRepository(DbFactory dbFactory) : base(dbFactory) { }
    }
}
