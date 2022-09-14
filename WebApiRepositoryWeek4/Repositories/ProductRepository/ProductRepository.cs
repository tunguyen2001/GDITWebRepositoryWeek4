using WebApiRepositoryWeek4.Repositories.RepositoryBase;
using WebApiRepositoryWeek4.Models;
using WebApiRepositoryWeek4.Data;
using WebApiRepositoryWeek4.Dtos.ProductDto;

namespace WebApiRepositoryWeek4.Repositories.ProductRepository
{
    public class ProductRepository : RepositoryBase<Products>, IProductRepository
    {
        public ProductRepository(Context context) : base(context)
        {
        }

        public IEnumerable<ProductDetailDto> GetProductDetailDtos()
        {
            var query = from p in _context.Products
                        join c in _context.Categories
                        on p.CategoryId equals c.CategoryId
                        select new ProductDetailDto
                        {
                            ProductId = p.ProductId,
                            ProductName = p.ProductName,
                            ProductPrice = p.ProductPrice,
                            Image = p.Image,
                            CategoryName = c.CategoryName,
                        };

            return query;
        }
    }
}
