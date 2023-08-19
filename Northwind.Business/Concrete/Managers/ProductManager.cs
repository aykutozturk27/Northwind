using AutoMapper;
using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using Northwind.Entities.Dtos;

namespace Northwind.Business.Concrete.Managers
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        private readonly IMapper _mapper;

        public ProductManager(IProductDal productDal, IMapper mapper)
        {
            _productDal = productDal;
            _mapper = mapper;
        }

        public ProductAddDto Add(Product product)
        {
            var addedProduct = _productDal.Add(product);
            var mappedProduct = _mapper.Map<ProductAddDto>(addedProduct);
            return mappedProduct;
        }

        //public Product Add(Product product)
        //{
        //    return _productDal.Add(product);
        //}

        public ProductListDto GetAll()
        {
            var productList = _productDal.GetList();
            var mappedProduct = new ProductListDto { Products = productList };
            return _mapper.Map<ProductListDto>(mappedProduct);
        }

        //public List<Product> GetAll()
        //{
        //    return _productDal.GetList();
        //}

        public async Task<List<Product>> GetAllAsync()
        {
            return await _productDal.GetListAsync();
        }
    }
}
