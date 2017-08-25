using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Resonsitories
{
    public interface IProducRepository
    {

    }
    public class ProducRepository : RepositoryBase<Product>, IProducRepository
    {

        public ProducRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
