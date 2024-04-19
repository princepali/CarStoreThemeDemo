using Car_store_theme.Entity;

using CarStore.DataLayer.Repository;
using CarStore.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car_store_theme.Service
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository _ProductRepository;



        public ProductService(IProductRepository ProductRepository)
        {
            _ProductRepository = ProductRepository;
        }

        public List<Product> GetFilters(string filterData)
        {
            List<Product> sortFilter = _ProductRepository.GetFilters(filterData);
            return sortFilter;
        }


        public List<Product> GetProductcategory(Product productData)
        {
            List<Product> category = _ProductRepository.GetProductcategory(productData);
            return category;
        }

        public List<Product> Getproducts(Product productData)
        {
            List<Product> Product = _ProductRepository.Getproducts();
            return Product;
        }

        public Product GetProductById(Guid PropductId)
        {
            var PdpData = _ProductRepository.GetProductById(PropductId);
            return PdpData;
        }


        public List<Product> GetProductCart(List<Guid> pids)
        {
            List<Product> product = _ProductRepository.Getproducts();
            return product.Where(x => pids.Contains(x.ProductId)).ToList();
        }

        public BoolResponse UploadProducts(Product uploadproducts)
        {
            return _ProductRepository.UploadProducts(uploadproducts);
        }

        public List<Product> DeleteProducts(Guid ProductDelete)
        {
            List<Product> DeleteProducts =_ProductRepository.DeleteProducts(ProductDelete);
            return DeleteProducts;
        }

    }
}
