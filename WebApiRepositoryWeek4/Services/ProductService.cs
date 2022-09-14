using WebApiRepositoryWeek4.Data;
using WebApiRepositoryWeek4.Dtos.ProductDto;
using WebApiRepositoryWeek4.Models;
using WebApiRepositoryWeek4.Repositories.ProductRepository;
using WebApiRepositoryWeek4.Repositories.RepositoryBase;

namespace WebApiRepositoryWeek4.Services
{ 
    public class ProductService : IProductRepository
    {

        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Delete(Products obj)
        {
            _productRepository.Delete(obj);
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
            _productRepository.Save();
        }

        public IEnumerable<Products> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Products GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public IEnumerable<ProductDetailDto> GetProductDetailDtos()
        {
            return _productRepository.GetProductDetailDtos();
        }

        public void Insert(Products obj)
        {
            _productRepository.Insert(obj);
            _productRepository.Save();
        }

        public void Save()
        {
            _productRepository.Save();
        }

        public void Update(Products obj)
        {
            _productRepository.Update(obj);
            _productRepository.Save();
        }

    }
}
