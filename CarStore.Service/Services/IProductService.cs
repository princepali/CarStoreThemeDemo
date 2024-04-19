

using Car_store_theme.Entity;
using CarStore.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_store_theme.Service
{
    public interface IProductService
    {
        List<Product> Getproducts(Product productData);
        List<Product> GetProductcategory(Product productData);
        List<Product> GetFilters(string filterData);
        Product GetProductById(Guid Id);
        List<Product> GetProductCart(List<Guid> pids);
        BoolResponse UploadProducts(Product uploadproducts);
        List<Product> DeleteProducts(Guid ProductDelete);
    }
}
