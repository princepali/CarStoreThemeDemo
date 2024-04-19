using Car_store_theme.Entity;
using Car_store_theme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public interface IProductRepository
{
    List<Product> Getproducts();
    List<Product> GetProductcategory(Product productData);
    List<Product> GetFilters(string filterData);
    ProductModel GetProductById(int id);

}


