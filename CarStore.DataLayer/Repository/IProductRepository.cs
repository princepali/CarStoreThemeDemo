using Car_store_theme.Entity;
using CarStore.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.DataLayer.Repository
{
    public interface IProductRepository
    {
        List<Product> Getproducts();
        List<Product> GetProductcategory(Product productData);
        List<Product> GetFilters(string filterData);
        Product GetProductById(Guid id);
        BoolResponse UploadProducts(Product upldProducts);
        List<Product> DeleteProducts(Guid ProductDelete);
    }
}
