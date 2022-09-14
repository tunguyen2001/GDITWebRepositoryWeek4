using WebApiRepositoryWeek4.Models;
using WebApiRepositoryWeek4.Repositories.RepositoryBase;
using WebApiRepositoryWeek4.Dtos.ProductDto;

namespace WebApiRepositoryWeek4.Repositories.ProductRepository
{
    public interface IProductRepository : IRepositoryBase<Products>  
    {
        IEnumerable<ProductDetailDto> GetProductDetailDtos();
    }
}
