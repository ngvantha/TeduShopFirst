using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShopData.Infratructure
{
    public interface IDbFactory: IDisposable
    {
        TeduShopDbContext Init();
    }
}
