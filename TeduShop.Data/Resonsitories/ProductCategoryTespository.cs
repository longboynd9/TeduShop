using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Resonsitories
{
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
    class ProductCategoryRespository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRespository(IDbFactory dbFactory)
            : base(dbFactory)
        {

        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(p => p.Alias == alias);
        }
    }
}
